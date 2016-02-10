using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestApplicatieGit.Startup))]
namespace TestApplicatieGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
