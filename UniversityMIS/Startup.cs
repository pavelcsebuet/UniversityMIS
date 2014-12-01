using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniversityMIS.Startup))]
namespace UniversityMIS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
