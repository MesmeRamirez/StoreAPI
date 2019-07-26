using AuthenticationStoreAPI.Config;
using AuthenticationStoreAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ModelStoreAPI;
using PersistenceStoreAPI;

namespace AuthenticationStoreAPI
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

            //Se setean las consideraciones para las contrasenas.
            services.AddIdentity<CUser, IdentityRole>
                (
                    identityoptions =>
                    {
                        identityoptions.Password.RequireDigit = true;
                        identityoptions.Password.RequiredLength = 6;
                        identityoptions.Password.RequireNonAlphanumeric = false;
                        identityoptions.Password.RequireUppercase = true;
                        identityoptions.Password.RequireLowercase = false;
                        identityoptions.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.";
                        identityoptions.User.RequireUniqueEmail = true;
                    }
                ).AddEntityFrameworkStores<AppDB>().AddDefaultTokenProviders();

            services.AddIdentityServer()
                .AddDeveloperSigningCredential()
                .AddInMemoryIdentityResources(IdentityConfig.GetIdentityResources())
                .AddInMemoryApiResources(IdentityConfig.GetAPIResources())
                .AddInMemoryClients(IdentityConfig.GetClients(
                        Configuration
                    ))
                .AddAspNetIdentity<CUser>()
                .AddProfileService<ProfileService>();

            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            //    options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.None;
            //});


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseIdentityServer();
            //app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }

    }
}
