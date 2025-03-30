using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WinWagers.Startup))]
namespace WinWagers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
