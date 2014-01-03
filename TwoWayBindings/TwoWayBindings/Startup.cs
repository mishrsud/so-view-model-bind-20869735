using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwoWayBindings.Startup))]
namespace TwoWayBindings
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
