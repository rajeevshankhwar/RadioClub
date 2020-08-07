using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RadioClub.Startup))]
namespace RadioClub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
