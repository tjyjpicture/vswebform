using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VSWebform.Startup))]
namespace VSWebform
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
