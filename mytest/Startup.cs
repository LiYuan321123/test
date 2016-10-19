using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mytest.Startup))]
namespace mytest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
