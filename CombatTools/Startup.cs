using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CombatTools.Startup))]
namespace CombatTools
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
