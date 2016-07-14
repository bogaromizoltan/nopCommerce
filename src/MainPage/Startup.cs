using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MainPage.Startup))]
namespace MainPage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
