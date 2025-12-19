using Microsoft.OpenApi.Models;

namespace ApiVeiculos.WebApi.OpenAPI;

public static class SwaggerConfig
{
    public static IServiceCollection AdicionarSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "API de Veículos",
                Version = "v1",
                Description = "API para cadastro, consulta, atualização e remoção de veículos",
            });
            
            var xmlFile = $"{AppDomain.CurrentDomain.FriendlyName}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

            if (File.Exists(xmlPath))
            {
                options.IncludeXmlComments(xmlPath);
            }
        });

        return services;
    }

    public static IApplicationBuilder UsarSwagger(this IApplicationBuilder app)
    {
        app.UseSwagger();

        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "API de Veículos v1");
            options.RoutePrefix = string.Empty;
        });

        return app;
    }
}
