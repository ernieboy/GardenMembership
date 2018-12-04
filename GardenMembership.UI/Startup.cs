using System;
using GardenMembership.Application.CommandHandlers;
using GardenMembership.Domain.DomainEvents;
using GardenMembership.Infrastructure.Persistence.Implementations;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using StructureMap;
using StructureMap.Pipeline;

namespace GardenMembership.UI
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<GardenMembershipDbContext>( 
                options => options.UseMySql(_configuration["ConnectionString"],
                    mySqlOptions =>
                    {
                        mySqlOptions.ServerVersion(new Version(5, 7, 22), ServerType.MySql);
                    }
            ));
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public IServiceProvider ConfigureIoc(IServiceCollection services)
        {
            var container = new Container();

            container.Configure(config =>
            {
                config.Scan(_ =>
                {
                    _.AssemblyContainingType(typeof(Startup));
                    _.AssemblyContainingType(typeof(NewMembershipCreatedEvent));
                    _.AssemblyContainingType(typeof(NewMembershipCommanHandler));
                    _.WithDefaultConventions();

                    _.ConnectImplementationsToTypesClosing(typeof(IRequestHandler<>)); // Handlers with no response
                    _.ConnectImplementationsToTypesClosing(typeof(IRequestHandler<,>)); // Handlers with a response                  
                    _.ConnectImplementationsToTypesClosing(typeof(INotificationHandler<>));

                });

                //Populate the container using the service collection
                config.Populate(services);

                // This is the default but let's be explicit. At most we should be container scoped.
                config.For<IMediator>().LifecycleIs<TransientLifecycle>().Use<Mediator>();

            });

            return container.GetInstance<IServiceProvider>();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc();
        }
    }
}
