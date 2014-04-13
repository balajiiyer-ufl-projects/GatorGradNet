using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GatorGradNetWebLayer.Startup))]
namespace GatorGradNetWebLayer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}