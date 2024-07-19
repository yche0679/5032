using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2_MyCodeSnippet.Startup))]
namespace _2_MyCodeSnippet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
