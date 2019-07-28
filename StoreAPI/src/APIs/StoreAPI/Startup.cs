using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PersistenceStoreAPI;
using Microsoft.EntityFrameworkCore;
using StoreAPI.Config;
using System.Security.Claims;

namespace StoreAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDB>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddMyDependencies(Configuration);

            services.AddAuthentication("Bearer").AddIdentityServerAuthentication(options =>
            {
                options.Authority = Configuration["AuthenticationStoreAPI:URL"];
                options.RequireHttpsMetadata = false;
                options.ApiName = Configuration["AuthenticationStoreAPI:APIName"];

                options.RoleClaimType = ClaimTypes.Role;
            });

            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin", builder =>
                    builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()
                );
            });

            StoreAPIMapps.Initialize();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //else
            //{
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //}

            app.UseAuthentication();
            app.UseCors("AllowSpecificOrigin");
            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
