using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using PersonInformationProject.Contexts;
using PersonInformationProject.Interfaces;
using PersonInformationProject.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

using PersonInformationProject.Repository;
using FluentValidation.AspNetCore;

namespace PersonInformationProject
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddFluentValidation(opt=>
            {
                opt.RegisterValidatorsFromAssemblyContaining<Startup>();
            });
            services.AddDbContext<AppDbContext>(opt =>
            {
                object p = opt.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database = PersonDB;Integrated Security=True;");
            });
            
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUow, Uow>();
            services.AddAutoMapper(typeof(Startup));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "node_modules")),
                RequestPath = "/node_modules"
            });
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
