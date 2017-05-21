using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(ContactHubAPI.ContactHubApi_Auth_Startup))]

namespace ContactHubAPI
{
    public partial class ContactHubApi_Auth_Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            ContactHubApi_TokenGeneration(app);
        }
    }
}
