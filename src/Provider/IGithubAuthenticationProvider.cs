using System.Threading.Tasks;

namespace OwinContrib.Security.Github
{
    public interface IGithubAuthenticationProvider
    {
        Task Authenticated(GithubAuthenticatedContext context);
        Task ReturnEndpoint(GithubReturnEndpointContext context);
    }
}
