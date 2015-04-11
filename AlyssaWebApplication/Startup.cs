using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlyssaWebApplication.Startup))]
namespace AlyssaWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
