using mendes.Api.Registrars;
using mendes.Application.Services;

namespace mendesSocial.Api.Registrars
{
    public class ApplicationLayerRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IdentityService>();
        }
    }
}
