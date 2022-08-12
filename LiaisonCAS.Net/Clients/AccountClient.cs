using LiaisonCAS.Net.Exceptions;
using LiaisonCAS.Net.Interfaces;
using LiaisonCAS.Net.ResourceModels;
using RestSharp;

namespace LiaisonCAS.Net.Clients
{
    public class AccountClient : IAccountClient
    {
        private readonly RestClient _client;

        public AccountClient(RestClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Fetch current Account Information
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<AccountInformationResourceModel?> GetAccountInformationAsync(CancellationToken token)
        {
            var request = new RestRequest("accounts/info");
            var response = await _client.ExecuteAsync<AccountInformationResourceModel>(request, token);
            if (response.IsSuccessful)
            {
                return response.Data;
            }

            var ex = new LiaisonClientException("Error fetching account information",
                response.ErrorException);
            
            ex.AddWebTrace(response.Content);
            throw ex;
        }

    }
}
