using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1B_DatabaseFirst.Startup))]
namespace _1B_DatabaseFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
