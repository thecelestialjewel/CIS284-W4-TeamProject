using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DogRescue.Startup))]
namespace DogRescue
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
