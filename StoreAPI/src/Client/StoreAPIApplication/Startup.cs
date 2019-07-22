using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StoreAPIApplication.Config;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StoreAPIApplication
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
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

            services.AddAuthentication(opts =>
            {
                opts.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                opts.DefaultChallengeScheme = "oidc";
            }).AddCookie(CookieAuthenticationDefaults.AuthenticationScheme)
              .AddOpenIdConnect("oidc", options =>
              {
                  options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme; 
                  options.Authority = Configuration["AuthenticationClient:URL"]; //URL de nuestro servidor de autenticacion obtenido del appsettings
                  options.RequireHttpsMetadata = false;
                  options.GetClaimsFromUserInfoEndpoint = true;
                  options.ClientId = Configuration["AuthenticationClient:ClientId"]; //ClientID de nuestro servidor de autenticacion obtenido del appsettings
                  options.ClientSecret = Configuration["AuthenticationClient:SecretKey"]; //SecretKey de nuestro servidor de autenticacion obtenido del appsettings
                  options.ResponseType = "code id_token";
                  options.Scope.Add("StoreAPI");
                  options.SaveTokens = true;
                  options.ClaimActions.Add(new JsonKeyClaimAction(ClaimTypes.Uri, ClaimTypes.Uri, ClaimTypes.Uri));
                  options.ClaimActions.Add(new JsonKeyClaimAction(ClaimTypes.Email, ClaimTypes.Email, ClaimTypes.Email));
                  options.ClaimActions.Add(new JsonKeyClaimAction("ImageProfile", "ImageProfile", "ImageProfile"));
                  options.ClaimActions.Add(new JsonKeyClaimAction("UserName", "UserName", "UserName"));

                  options.Events = new OpenIdConnectEvents
                  {
                      OnUserInformationReceived = async context =>
                      {
                          var ListadoClaims = new List<Claim>();

                          if (context.Properties.Items.Keys.Contains(".Token.access_token"))
                          {
                              var token = context.Properties.Items[".Token.access_token"].ToString();
                              ListadoClaims.Add(new Claim("access_token", token));

                              var id = context.Principal.Identity as ClaimsIdentity;
                              id.AddClaims(ListadoClaims);
                          }
                          await Task.FromResult(0);
                      }
                  };
              });


            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            //    options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.None;
            //});

            services.AddMyDependencies(Configuration);

            Parameters.ApiURL = Configuration["Api:URL"];

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
