using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TourGuide.Web.Startup))]
namespace TourGuide.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
