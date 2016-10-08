using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HttpRequests.Startup))]
namespace HttpRequests
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
