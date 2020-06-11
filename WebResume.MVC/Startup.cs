using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Reflection;
using WebResume.Auth;
using WebResume.Auth.Extensions;
using WebResume.Auth.Graph; 
//using WebResume.DataAccess;
//using WebResume.MVC.DataAccess.MVC.Repository;
//using WebResume.DataAccess.MVC.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using WebResume.MVC.DataAccess.Repository.IRepository;
using WebResume.MVC.DataAccess.Repository;
using WebResume.MVC.DataAccess;
using System.IO;

namespace WebResume.MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration, Microsoft.AspNetCore.Hosting.IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false)
                .AddJsonFile("appsettings.Development.json", optional: true)
                .AddJsonFile("appsettings.Local.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
            }
            else
            {
                Configuration = configuration;
            }
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            /*****************************************************************************
             * Authentication Section
            ******************************************************************************/
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddAuthentication(sharedOptions =>
            {
                sharedOptions.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                sharedOptions.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                sharedOptions.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
            })
            .AddAzureAd(options => Configuration.Bind("AzureAd", options))
            .AddCookie(options => {
                options.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/Error/AccessDenied");
            });

            services.AddMvc(options => options.EnableEndpointRouting = false)
                .AddWebApiConventions()
                .AddApplicationPart(Assembly.Load("WebResume.Auth"))
                .AddControllersAsServices();

            services.AddSession();

            services.AddSingleton<IGraphAuthProvider, GraphAuthProvider>();
            services.AddTransient<IGraphSdkHelper, GraphSdkHelper>();

            services.AddControllersWithViews(options =>
            {
                //var policy = new AuthorizationPolicyBuilder()
                //    //.RequireAuthenticatedUser().RequireClaim("groups", new string[]{
                //    ////Configuration.GetValue<string>("Groups:AdminGroup"),
                //    ////Configuration.GetValue<string>("Groups:UserGroup")})
                //    //"22972484-b1f8-466c-9767-ef4efbac5a00",
                //    //"e4391d60-4cd4-45b7-9678-bb09eedf1600"})
                //    .Build();
                //options.Filters.Add(new AuthorizeFilter(policy));

            });

            services.Configure<HstsOptions>(options =>
            {
                options.IncludeSubDomains = true;
                options.MaxAge = TimeSpan.FromDays(365);
            });

            /*****************************************************************************
             * DB Section
            *****************************************************************************/
            services.AddDbContext<WRDbContext>(options =>
                //options.UseSqlServer(
                //    Configuration.GetConnectionString("DefaultConnection"), db =>
                //    db.MigrationsAssembly("WebResume.DataAccess")
                //    ));
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")
                ));

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
