using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestTourGuide.Startup))]
namespace TestTourGuide
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
