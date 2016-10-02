using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemonCRUD.Startup))]
namespace DemonCRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
