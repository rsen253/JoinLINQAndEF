using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JoiningEntityFramework.Startup))]
namespace JoiningEntityFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
