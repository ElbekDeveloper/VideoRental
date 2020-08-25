using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoStoreUI.Startup))]
namespace VideoStoreUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
