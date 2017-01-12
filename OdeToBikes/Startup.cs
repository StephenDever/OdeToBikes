using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OdeToBikes.Startup))]
namespace OdeToBikes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
