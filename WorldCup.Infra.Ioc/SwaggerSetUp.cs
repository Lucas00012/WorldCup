using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace WorldCup.Infra.Ioc
{
    public static class SwaggerSetUp
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {

            return services.AddSwaggerGen(opt =>
            {
                opt.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Template .Net Core",
                    Version = "v1",
                    Description = "API project World Cup",
                    Contact = new OpenApiContact
                    {
                        Name = "Marcelo Oliveira",
                        Email = "marcelo.olisi@gmail.com"
                    }
                });

                string xmlPath = Path.Combine("wwwroot", "api-doc.xml");
                opt.IncludeXmlComments(xmlPath);
            });
        }

        //Route and search Json to export information   
        public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            return app.UseSwagger().UseSwaggerUI(c =>
            {
                c.RoutePrefix = "documentation";
                c.SwaggerEndpoint("../swagger/v1/swagger.json", "API v1");

            });
        }

    }


}
