using mendesSocial.Api.Options;

namespace mendesSocial.Api.Registrars
{
    public class SwaggerRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen();
            builder.Services.ConfigureOptions<ConfigureSwaggerOpitions>();
        }
    }
}
