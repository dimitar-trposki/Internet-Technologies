using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCBooksChatGPT.Startup))]
namespace MVCBooksChatGPT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
