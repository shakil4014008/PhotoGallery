using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC2017.Startup))]
namespace MVC2017
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
