using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Heat.Startup))]
namespace Heat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
