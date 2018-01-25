using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookStock.Startup))]
namespace BookStock
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
