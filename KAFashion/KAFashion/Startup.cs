using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KAFashion.Startup))]
namespace KAFashion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
