using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppSec.Startup))]
namespace WebAppSec
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
