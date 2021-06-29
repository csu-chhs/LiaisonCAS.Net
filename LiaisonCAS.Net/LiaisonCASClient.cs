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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public LiaisonCASClient(string apiKey, 
            string username,
            string password)
        {
            RestClient client = new RestClient("https://api.liaisonedu.com/v1/");
            client.AddDefaultHeader("x-api-key", apiKey);
            _client = client;
            _username = username;
            _password = password;

            Application = new ApplicationClient(_client);
            File = new FileClient(_client);
            Program = new ProgramClient(_client);
        }

        /// <summary>
        /// This method specifically gets placed outside of the 
        /// constructor so that it does not run every time a new object 
        /// is constructed.  DI creates a new object on every page load
        /// in an app, and that would quickly increase the number of 
        /// calls we are making.
        /// </summary>
        public void SetupAuthenticationHeaders()
        {
            // Fetch and set the token.
            IAuthenticationClient authenticationClient = new AuthenticationClient(_client);
            AuthenticationTokenResourceModel tokenResourceModel = new AuthenticationTokenResourceModel(_username, _password);

            AuthenticationTokenResponseResourceModel tokenResponse = authenticationClient
                .FetchAuthenticationToken(tokenResourceModel);
            _client.AddDefaultHeader("Authorization", tokenResponse.Token);
        }

        /// <summary>
        /// This method specifically gets placed outside of the 
        /// constructor so that it does not run every time a new object 
        /// is constructed.  DI creates a new object on every page load
        /// in an app, and that would quickly increase the number of 
        /// calls we are making.
        /// </summary>
        public async Task SetupAuthenticationHeadersAsync()
        {
            // Fetch and set the token.
            IAuthenticationClient authenticationClient = new AuthenticationClient(_client);
            AuthenticationTokenResourceModel tokenResourceModel = new AuthenticationTokenResourceModel(_username, _password);

            AuthenticationTokenResponseResourceModel tokenResponse = await authenticationClient
                .FetchAuthenticationTokenAsync(tokenResourceModel);
            _client.AddDefaultHeader("Authorization", tokenResponse.Token);
        }

        /// <summary>
        /// Access the Applications API
        /// </summary>
        public IApplicationClient Application { get; }

        /// <summary>
        /// Access the File API
        /// </summary>
        public IFileClient File { get; }

        /// <summary>
        /// Access the Program API
        /// </summary>
        public IProgramClient Program { get; }
    }
}
