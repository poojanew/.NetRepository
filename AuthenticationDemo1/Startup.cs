using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthenticationDemo1.Startup))]
namespace AuthenticationDemo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
