using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LV3_Remastered.Startup))]
namespace LV3_Remastered
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
