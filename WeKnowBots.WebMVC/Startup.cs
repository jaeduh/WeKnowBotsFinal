using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeKnowBots.WebMVC.Startup))]
namespace WeKnowBots.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
