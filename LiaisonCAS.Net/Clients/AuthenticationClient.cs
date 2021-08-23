using System.Threading.Tasks;
using LiaisonCAS.Net.Exceptions;
using LiaisonCAS.Net.Interfaces;
using LiaisonCAS.Net.ResourceModels;
using RestSharp;

namespace LiaisonCAS.Net.Clients
{
    public class AuthenticationClient : IAuthenticationClient
    {
        private readonly string _url;
        private readonly RestClient _client;

        public AuthenticationClient(RestClient client)
        {
            _url = "auth/token";
            _client = client;
        }

        /// <summary>
        /// Fetches and returns a token for use with other API
        /// endpoint calls.
        /// </summary>
        /// <param name="resourceModel"></param>
        /// <returns></returns>
        public AuthenticationTokenResponseResourceModel FetchAuthenticationToken(AuthenticationTokenResourceModel resourceModel)
        {
            var request = new RestRequest($"{_url}", Method.POST);
            request.AddJsonBody(resourceModel);
            var response = _client.Execute<AuthenticationTokenResponseResourceModel>(request);
            if (response.IsSuccessful)
            {
                return response.Data;
            }

            throw new LiaisonClientException("Failed to fetch auth token.");
        }

        /// <summary>
        /// Fetches and returns a token for use with other API
        /// endpoint calls.
        /// </summary>
        /// <param name="resourceModel"></param>
        /// <returns></returns>
        public async Task<AuthenticationTokenResponseResourceModel> FetchAuthenticationTokenAsync(AuthenticationTokenResourceModel resourceModel)
        {
            var request = new RestRequest($"{_url}", Method.POST);
            request.AddJsonBody(resourceModel);
            var response = await _client.ExecuteAsync<AuthenticationTokenResponseResourceModel>(request);
            if (response.IsSuccessful)
            {
                return response.Data;
            }

            throw new LiaisonClientException("Failed to fetch auth token.");
        }
    }
}
