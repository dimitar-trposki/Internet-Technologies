using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AV8.Startup))]
namespace AV8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
