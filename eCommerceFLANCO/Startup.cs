using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eCommerceFLANCO.Startup))]
namespace eCommerceFLANCO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
