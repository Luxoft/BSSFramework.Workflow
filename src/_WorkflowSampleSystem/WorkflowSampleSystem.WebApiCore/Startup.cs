﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

using Framework.DependencyInjection;
using Framework.DomainDriven.WebApiNetCore;
using Framework.WebApi.Utils;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

using Newtonsoft.Json;

using WorkflowSampleSystem.ServiceEnvironment;
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
            if (this.HostingEnvironment.IsProduction())
            {
                services.AddMetricsBss(this.Configuration, 0.5);
            }

            services.RegisterGeneralDependencyInjection(this.Configuration)
                    .AddApiVersion()
                    .AddSwaggerBss(
                                   new OpenApiInfo { Title = "WorkflowSampleSystem", Version = "v1" },
                                   new List<string> { Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml") });

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
                AppMetricsServiceCollectionExtensions.AddMetrics(services);
            }

            services.ValidateDuplicateDeclaration(typeof(ILoggerFactory));

            services.AddCap(x => x.UseDashboard());
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

            app.UseHttpsRedirection()
               .UseRouting()

               .UseDefaultExceptionsHandling()
               .UseCorrelationId("WorkflowSampleSystem_{0}")
               .UseTryProcessDbSession()
               .UseWebApiExceptionExpander()

               .UseEndpoints(z => z.MapControllers());

            if (env.IsProduction())
            {
                app.UseMetricsAllMiddleware();
            }
        }
    }
}
