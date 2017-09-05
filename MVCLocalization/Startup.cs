using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCLocalization.Startup))]
namespace MVCLocalization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
