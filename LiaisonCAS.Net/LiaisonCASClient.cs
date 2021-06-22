using System.Threading.Tasks;
using LiaisonCAS.Net.Clients;
using LiaisonCAS.Net.Interfaces;
using LiaisonCAS.Net.ResourceModels;
using RestSharp;

namespace LiaisonCAS.Net
{
    public class LiaisonCASClient : ILiaisonCASClient
    {
        private RestClient _client;
        private readonly string _username;
        private readonly string _password;

        public LiaisonCASClient(string apiKey, 
            string username,
            string password)
        {
            RestClient client = new RestClient();
            client.AddDefaultHeader("x-api-key", apiKey);
            _client = client;
            _username = username;
            _password = password;

            Application = new ApplicationClient(_client);
        }

        public void SetupAuthenticationHeaders()
        {
            // This method specifically gets placed outside of the 
            // constructor so that it does not run every time a new object 
            // is constructed.  DI creates a new object on every page load
            // in an app, and that would quickly increase the number of 
            // calls we are making.


            // Fetch and set the token.
            IAuthenticationClient authenticationClient = new AuthenticationClient(_client);
            AuthenticationTokenResourceModel tokenResourceModel = new AuthenticationTokenResourceModel(_username, _password);

            AuthenticationTokenResponseResourceModel tokenResponse = authenticationClient
                .FetchAuthenticationToken(tokenResourceModel);
            _client.AddDefaultHeader("Authorization", tokenResponse.Token);
        }

        public async Task SetupAuthenticationHeadersAsync()
        {
            // Fetch and set the token.
            IAuthenticationClient authenticationClient = new AuthenticationClient(_client);
            AuthenticationTokenResourceModel tokenResourceModel = new AuthenticationTokenResourceModel(_username, _password);

            AuthenticationTokenResponseResourceModel tokenResponse = await authenticationClient
                .FetchAuthenticationTokenAsync(tokenResourceModel);
            _client.AddDefaultHeader("Authorization", tokenResponse.Token);
        }

        public IApplicationClient Application { get; }
    }
}
