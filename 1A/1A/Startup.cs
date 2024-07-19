using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1A.Startup))]
namespace _1A
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
