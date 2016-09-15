using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tunti1509.Startup))]
namespace Tunti1509
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
