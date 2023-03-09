using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using MovieList.Models;
using Newtonsoft.Json;
public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<MovieContext>(options =>
            options.UseSqlServer(
                Configuration.GetConnectionString("MovieContext")));
        services.AddMemoryCache();
        services.AddSession();
        services.AddControllersWithViews();
        services.AddSession(options => {
            options.IdleTimeout = TimeSpan.FromSeconds(60 * 5); 
            options.Cookie.HttpOnly = false;
            options.Cookie.IsEssential = true; 
        services.AddMemoryCache(); services.AddSession();
        services.AddControllersWithViews().AddNewtonsoftJson(); 
        });
    }
}