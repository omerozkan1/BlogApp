using Blog.WebUI.ApiServices.Concrate;
using Blog.WebUI.ApiServices.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Blog.WebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddSession();
            services.AddHttpClient<IBlogApiService, BlogApiManager>();
            services.AddHttpClient<ICategoryApiService, CategoryApiManager>();
            services.AddHttpClient<IimageApiService, ImageApiManager>();
            services.AddHttpClient<IAuthApiService, AuthApiManager>();
            services.AddHttpClient<INewsApiService, NewsApiManager>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseSession();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name:"areas", pattern: "{area}/{controller=Blog}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
