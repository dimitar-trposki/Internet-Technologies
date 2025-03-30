using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AV9_Dimitar.Startup))]
namespace AV9_Dimitar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
