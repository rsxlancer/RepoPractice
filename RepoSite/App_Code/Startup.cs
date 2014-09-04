using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RepoSite.Startup))]
namespace RepoSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
