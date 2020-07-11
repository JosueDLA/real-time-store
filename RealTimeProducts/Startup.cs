using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RealTimeProducts.Startup))]
namespace RealTimeProducts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
