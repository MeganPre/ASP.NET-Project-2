using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_10207_Megan_Pretorius_SLD521_SA.Startup))]
namespace _10207_Megan_Pretorius_SLD521_SA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
