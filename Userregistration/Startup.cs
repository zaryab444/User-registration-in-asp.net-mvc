using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Userregistration.Startup))]
namespace Userregistration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
