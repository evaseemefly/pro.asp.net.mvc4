using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Filter.Startup))]
namespace Filter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
