using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodingSchoolAppInsights.Startup))]
namespace CodingSchoolAppInsights
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
