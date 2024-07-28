using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_5A.Startup))]
namespace _5A
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
