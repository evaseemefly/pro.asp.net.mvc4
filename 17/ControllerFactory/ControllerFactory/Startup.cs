using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControllerFactory.Startup))]
namespace ControllerFactory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
