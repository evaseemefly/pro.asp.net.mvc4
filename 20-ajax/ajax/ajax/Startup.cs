using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ajax.Startup))]
namespace ajax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
