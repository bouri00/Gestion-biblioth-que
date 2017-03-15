using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Library_And_Education.Startup))]
namespace Library_And_Education
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
