using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1B_MyCSS.Startup))]
namespace _1B_MyCSS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
