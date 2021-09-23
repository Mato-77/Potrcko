using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pottrcko.Startup))]
namespace Pottrcko
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
