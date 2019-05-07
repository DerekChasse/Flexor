using Blazorise;
using Blazorise.Material;
using Blazorise.Icons.Material;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Flexor.Demo
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddFlexor()
                .AddBlazorise(options =>
                {
                    options.ChangeTextOnKeyPress = true;
                })
                .AddMaterialProviders()
                .AddMaterialIcons(); ;
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
