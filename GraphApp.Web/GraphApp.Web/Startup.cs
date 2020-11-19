using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

namespace GraphApp.Web
{

    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {

        #region Fields
        //No Fields
        #endregion

        #region Events
        //No Events
        #endregion

        #region Enums
        //No Enums
        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        #endregion

        #region Destructors
        //No Destructors
        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public IConfiguration Configuration { get; }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        /// <remarks>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </remarks>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            //This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <remarks>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </remarks>
        public void ConfigureServices(IServiceCollection services)
        {

            //
            const string connectionStringKey = "databaseConnectionString";

            //This method gets called by the runtime. Use this method to add services to the container.

            //
            services.AddDbContext<Infrastructure.Contexts.ApplicationContext>(item =>
                item.UseSqlite(Configuration.GetConnectionString(connectionStringKey)));

            services.AddScoped<Core.Interfaces.IOwnerRepository, Infrastructure.Repositories.OwnerRepository>();
            services.AddScoped<Core.Interfaces.IAccountRepository, Infrastructure.Repositories.AccountRepository>();

            services.AddControllersWithViews();

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });
        }

        #endregion

        #region Event Handlers
        //No Event Handlers
        #endregion

    }

}
