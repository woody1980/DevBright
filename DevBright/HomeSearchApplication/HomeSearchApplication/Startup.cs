using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeSearchApplication.Startup))]
namespace HomeSearchApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
