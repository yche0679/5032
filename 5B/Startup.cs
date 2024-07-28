using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_5B.Startup))]
namespace _5B
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
