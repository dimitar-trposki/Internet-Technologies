using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_MusicShop.Startup))]
namespace MVC_MusicShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
