using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(try3MVC.Startup))]
namespace try3MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
