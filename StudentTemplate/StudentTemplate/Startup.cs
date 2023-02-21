using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using StudentTemplate.Models;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    public IConfiguration Configuration { get; }
 
    // Use this method to configure the HTTP request pipeline. 
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseDeveloperExceptionPage();
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting(); // mark where routing decisions are made

        // configure middleware that runs after routing decisions have been made

        app.UseEndpoints(endpoints => // map the endpoints 
        {
            endpoints.MapControllerRoute(
               name: "AccessLevel3",
               pattern: "AccessLevel3/{controller=Home}/{action=Index}/{id}");

            endpoints.MapControllerRoute(
                name: "AccessLevel2",
                pattern: "AccessLevel2/{controller=Home}/{action=Index}/{id}");

            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}