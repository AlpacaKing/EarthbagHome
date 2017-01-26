using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EarthBagHome.Startup))]
namespace EarthBagHome
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
