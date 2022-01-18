using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(collegeManagementSystem.net.Startup))]
namespace collegeManagementSystem.net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
