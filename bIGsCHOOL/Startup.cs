using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bIGsCHOOL.Startup))]
namespace bIGsCHOOL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
