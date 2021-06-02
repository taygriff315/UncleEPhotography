using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UncleEPhotography.Startup))]
namespace UncleEPhotography
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
