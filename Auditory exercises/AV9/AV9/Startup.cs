using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AV9.Startup))]
namespace AV9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
