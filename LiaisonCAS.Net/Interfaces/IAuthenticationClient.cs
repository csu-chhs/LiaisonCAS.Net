using LiaisonCAS.Net.ResourceModels;

namespace LiaisonCAS.Net.Interfaces
{
    public interface IAuthenticationClient
    {
        /// <summary>
        /// Fetches and returns a token for use with other API
        /// endpoint calls.
        /// </summary>
        /// <param name="resourceModel"></param>
        /// <returns></returns>
        AuthenticationTokenResponseResourceModel FetchAuthenticationToken(
            AuthenticationTokenResourceModel resourceModel);

        /// <summary>
        /// Fetches and returns a token for use with other API
        /// endpoint calls.
        /// </summary>
        /// <param name="resourceModel"></param>
        /// <returns></returns>
        Task<AuthenticationTokenResponseResourceModel> FetchAuthenticationTokenAsync(AuthenticationTokenResourceModel resourceModel);
    }
}
