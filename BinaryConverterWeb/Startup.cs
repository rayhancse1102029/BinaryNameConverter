using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BinaryConverterWeb.Startup))]
namespace BinaryConverterWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
