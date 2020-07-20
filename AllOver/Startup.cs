using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AllOver.Startup))]
namespace AllOver
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
