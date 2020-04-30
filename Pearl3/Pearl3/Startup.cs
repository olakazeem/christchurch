using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pearl3.Startup))]
namespace Pearl3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
