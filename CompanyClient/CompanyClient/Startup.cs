using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CompanyClient.Startup))]
namespace CompanyClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
