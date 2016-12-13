using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Impact.Mvc.Startup))]
namespace Impact.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
        }
    }
}
