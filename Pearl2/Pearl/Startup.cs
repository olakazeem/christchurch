using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pearl.Startup))]
namespace Pearl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
