using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(anotherTwoSide.Startup))]
namespace anotherTwoSide
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
