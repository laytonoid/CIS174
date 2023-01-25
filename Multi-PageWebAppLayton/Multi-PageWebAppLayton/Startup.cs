﻿using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Multi_PageWebAppLayton.Models;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    public IConfiguration Configuration { get; }
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<ContactContext>(options => 
            options.UseSqlServer(
                Configuration.GetConnectionString("ContactContext")));
    }
}