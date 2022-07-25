﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

using DotNetCore.CAP;

using Framework.WebApi.Utils;

using MediatR;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

using Newtonsoft.Json;

using WorkflowSampleSystem.BLL;
using WorkflowSampleSystem.WebApiCore.NewtonsoftJson;

namespace WorkflowSampleSystem.WebApiCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            this.Configuration = configuration;
            this.HostingEnvironment = env;
        }

        public IWebHostEnvironment HostingEnvironment { get; }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            if(this.HostingEnvironment.IsProduction())
            {
                services
                    .AddMetricsBss(this.Configuration, 0.5);
            }

            services
                .RegisterDependencyInjections(this.Configuration)
                .AddApiVersion()
                .AddSwaggerBss(
                    new OpenApiInfo { Title = "WorkflowSampleSystem", Version = "v1" },
                    new List<string> { Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml") });

            services.AddMediatR(Assembly.GetAssembly(typeof(EmployeeBLL)));

            services
                .AddMvcBss()
                .AddNewtonsoftJson(
                    z =>
                    {
                        z.SerializerSettings.Converters.Add(new UtcDateTimeJsonConverter());
                        z.SerializerSettings.TypeNameHandling = TypeNameHandling.Auto;
                    });

            if (this.HostingEnvironment.IsProduction())
            {
                services.AddMetrics();

            }

            services.RegisterLegacyBLLContext();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider versionProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwaggerBss(versionProvider);
            }
            else
            {
                app.UseHsts();
            }

            app
                .UseDefaultExceptionsHandling()
                .UseCorrelationId("WorkflowSampleSystem_{0}")

                .UseHttpsRedirection()
                .UseRouting()
                .UseEndpoints(z => z.MapControllers());

            if (env.IsProduction())
            {
                app.UseMetricsAllMiddleware();
            }

            app.UseCapDashboard();

        }
    }
}
