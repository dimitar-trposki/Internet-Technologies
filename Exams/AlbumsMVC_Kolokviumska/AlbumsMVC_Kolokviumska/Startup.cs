using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlbumsMVC_Kolokviumska.Startup))]
namespace AlbumsMVC_Kolokviumska
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
