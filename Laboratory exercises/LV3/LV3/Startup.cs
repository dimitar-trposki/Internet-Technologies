using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LV3.Startup))]
namespace LV3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
