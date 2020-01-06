using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SellIt_ASP.Startup))]
namespace SellIt_ASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
