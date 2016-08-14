using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TridomiDesign.Startup))]
namespace TridomiDesign
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
