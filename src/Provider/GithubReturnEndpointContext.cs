using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Provider;

namespace OwinContrib.Security.Github
{
    public class GithubReturnEndpointContext : ReturnEndpointContext
    {
        public GithubReturnEndpointContext(
            IOwinContext context,
            AuthenticationTicket ticket)
            : base(context, ticket)
        {
        }
    }
}
