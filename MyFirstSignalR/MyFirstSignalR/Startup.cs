using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstSignalR.Startup))]
namespace MyFirstSignalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
