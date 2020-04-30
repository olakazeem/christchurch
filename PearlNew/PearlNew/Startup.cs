using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PearlNew.Startup))]
namespace PearlNew
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
