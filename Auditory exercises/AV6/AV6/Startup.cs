using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AV6.Startup))]
namespace AV6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
