using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCASPNETIdentity.Startup))]
namespace MVCASPNETIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
