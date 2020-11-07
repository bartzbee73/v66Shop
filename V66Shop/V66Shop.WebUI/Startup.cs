using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(V66Shop.WebUI.Startup))]
namespace V66Shop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
