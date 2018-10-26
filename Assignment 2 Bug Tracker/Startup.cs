using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment_2_Bug_Tracker.Startup))]
namespace Assignment_2_Bug_Tracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
