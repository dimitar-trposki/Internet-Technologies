using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LV2.Startup))]
namespace LV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
