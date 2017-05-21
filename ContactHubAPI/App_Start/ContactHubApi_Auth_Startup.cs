using Owin;
using System;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using ContactHubAPI.ServerAuthorizationToken;

namespace ContactHubAPI
{
    public partial class ContactHubApi_Auth_Startup
    {
        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }
        static ContactHubApi_Auth_Startup()
        {
            OAuthOptions = new OAuthAuthorizationServerOptions() {
                TokenEndpointPath = new PathString("/api/token"),
                Provider = new AuthorizationToken(),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(20),
                AllowInsecureHttp = true
            };
        }
        public void ContactHubApi_TokenGeneration(IAppBuilder app)
        {
            app.UseOAuthAuthorizationServer(OAuthOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}