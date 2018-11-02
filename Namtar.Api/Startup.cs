using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Namtar.Api.Mappings;
using Namtar.Crosscutting;
using Swashbuckle.AspNetCore.Swagger;

namespace Namtar.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Injeção de dependencias
            Injections.Register(services);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //registrando a classe DomainProfile do AutoMapper
            Mapper.Initialize(m => m.AddProfile<DomainToEntityProfile>());

            //Incluir Swagger
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1",
                new Info
                {
                    Title = "Projeto Asp.Net Core WEB API",
                    Version = "v1",
                    Description = "Namtar - Deus Sumério do Destino",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "Nelson Neto",
                        Email = "nelson.ash@outlook.com"//,
                        //Url = "https://twitter.com/spboyer"
                    },
                    //License = new License
                    //{
                    //    Name = "Use under LICX",
                    //    Url = "https://example.com/license"
                    //}
                });
            });
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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json",
                "Projeto Asp.Net Core WEB API");
                s.RoutePrefix = string.Empty;
            });
        }
    }
}
