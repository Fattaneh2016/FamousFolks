using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFamousFolks.Startup))]
namespace WebFamousFolks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
