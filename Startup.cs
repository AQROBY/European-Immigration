using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(European_Immigration.Startup))]
namespace European_Immigration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
