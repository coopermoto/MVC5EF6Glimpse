using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5EF6Glimpse.Startup))]
namespace MVC5EF6Glimpse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
