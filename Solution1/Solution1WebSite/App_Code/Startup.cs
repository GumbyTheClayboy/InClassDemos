using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Solution1WebSite.Startup))]
namespace Solution1WebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
