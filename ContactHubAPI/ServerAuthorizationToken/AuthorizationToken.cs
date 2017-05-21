using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.Owin.Security;
using System.Collections.Generic;
using Microsoft.Owin.Security.OAuth;

namespace ContactHubAPI.ServerAuthorizationToken
{
    public class AuthorizationToken : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            await Task.FromResult(context.Validated());
        }
        public override Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            return Task.Run(() =>
            {
                var username = context.UserName;
                var password = context.Password;
                switch ((username == "mudit" && password == "mudit"))
                {
                    case true:
                        var claims = new List<Claim>()
                        {
                            new Claim(ClaimTypes.NameIdentifier,"1"),
                            new Claim(ClaimTypes.Email,"mudit@gmail.com"),
                            new Claim(ClaimTypes.Name,"Mudit Kaushik")
                        };
                        var claimIdentity = new ClaimsIdentity(claims, ContactHubApi_Auth_Startup.OAuthOptions.AuthenticationType);
                        context.Validated(new AuthenticationTicket(claimIdentity, new AuthenticationProperties() { }));
                        break;
                    case false:
                        context.SetError("invalid user", "Username or Password invalid.");
                        break;
                }
            });
        }
    }
}