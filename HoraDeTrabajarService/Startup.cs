using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(HoraDeTrabajarService.Startup))]

namespace HoraDeTrabajarService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}