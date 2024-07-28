using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_4.Startup))]
namespace _4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
