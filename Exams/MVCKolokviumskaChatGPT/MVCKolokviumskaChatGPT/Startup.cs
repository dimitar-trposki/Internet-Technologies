using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCKolokviumskaChatGPT.Startup))]
namespace MVCKolokviumskaChatGPT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
