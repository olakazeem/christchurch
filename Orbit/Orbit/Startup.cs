using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Orbit.Startup))]
namespace Orbit
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
