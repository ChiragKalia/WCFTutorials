using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloClient.Startup))]
namespace HelloClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
