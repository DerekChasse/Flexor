using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Flexor.Demo
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddFlexor();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
