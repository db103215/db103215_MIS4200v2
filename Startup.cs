using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(db103215_MIS4200v2.Startup))]
namespace db103215_MIS4200v2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
