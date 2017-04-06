using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gihubejemplo.Startup))]
namespace Gihubejemplo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
