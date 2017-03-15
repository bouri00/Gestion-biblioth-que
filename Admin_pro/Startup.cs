using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Admin_pro.Startup))]
namespace Admin_pro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
