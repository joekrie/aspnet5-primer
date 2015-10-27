using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Dnx.Runtime;
using System.IO;
using Raven.Client;
using Raven.Client.Embedded;
using Microsoft.AspNet.StaticFiles;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace AspNet5Primer.SPA
{
    public class Startup
    {
        private readonly string appPath;

        public Startup(IApplicationEnvironment appEnv)
        {
            appPath = appEnv.ApplicationBasePath;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(provider => {
                var store = new EmbeddableDocumentStore
                {
                    DataDirectory = Path.Combine(appPath, "db")
                }.Initialize();

                store.Conventions.IdentityPartsSeparator = "-";
                return store;
            });

            services.AddScoped(provider => 
                provider.GetRequiredService<IDocumentStore>().OpenAsyncSession());

            services.AddMvc()
                .AddJsonOptions(setup =>
                {
                    setup.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}
