using LiaisonCAS.Net.Clients;
using LiaisonCAS.Net.Exceptions;
using LiaisonCAS.Net.Interfaces;
using LiaisonCAS.Net.ResourceModels;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace LiaisonCAS.Net
{
    public class LiaisonCASClient : ILiaisonCASClient
    {
        private RestClient _client;
        private readonly string _username;
        private readonly string _password;
        private string _token;
        private string _refreshToken;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="autoRegisterAuthHeader"></param>
        public LiaisonCASClient(string apiKey, 
            string username,
            string password,
            bool autoRegisterAuthHeader = false)
        {
            RestClient client = new RestClient("https://api.liaisonedu.com/v1/",
                configureSerialization: s => s.UseNewtonsoftJson());
            client.AddDefaultHeader("x-api-key", apiKey);
            _client = client;
            _username = username;
            _password = password;
            _token = string.Empty;
            _refreshToken = string.Empty;

            Application = new ApplicationClient(_client);
            File = new FileClient(_client);
            Program = new ProgramClient(_client);
            Account = new AccountClient(_client);

            if (autoRegisterAuthHeader)
            {
                SetupAuthenticationHeaders();
            }
        }

        /// <summary>
        /// Attempts to remove the previous auth headers.
        /// </summary>
        private void _CleanAuthHeader()
        {
            _client.DefaultParameters.RemoveParameter("Authorization", ParameterType.HttpHeader);
        }

        /// <summary>
        /// 
        /// </summary>
        public async Task RefreshToken()
        {
            IAuthenticationClient authenticationClient = new AuthenticationClient(_client);
            AuthenticationTokenRefreshResourceModel refreshModel = new(_refreshToken);
            AuthenticationTokenRefreshResponseResourceModel? responseToken =
                await authenticationClient.GetTokenRefreshAsync(refreshModel, default);

            if (responseToken != null)
            {
                _token = responseToken.Token;
            }
            _CleanAuthHeader();
            _SetHeader();
        }

        private void _SetHeader()
        {
            _client.AddDefaultHeader("Authorization", $"{_token}");
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
            _CleanAuthHeader();
            // Fetch and set the token.
            IAuthenticationClient authenticationClient = new AuthenticationClient(_client);
            AuthenticationTokenResourceModel tokenResourceModel = new AuthenticationTokenResourceModel(_username, 
                _password);

            AuthenticationTokenResponseResourceModel? tokenResponse = authenticationClient
                .FetchAuthenticationToken(tokenResourceModel);

            if (tokenResponse != null)
            {
                _token = tokenResponse.Token;
                _refreshToken = tokenResponse.RefreshToken;
                _SetHeader();
            }
            else
            {
                var ex = new LiaisonClientNotAuthorized("Failed to fetch token header");
                throw ex;
            }
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
            _CleanAuthHeader();
            // Fetch and set the token.
            IAuthenticationClient authenticationClient = new AuthenticationClient(_client);
            AuthenticationTokenResourceModel tokenResourceModel = new AuthenticationTokenResourceModel(_username, _password);

            AuthenticationTokenResponseResourceModel? tokenResponse = await authenticationClient
                .FetchAuthenticationTokenAsync(tokenResourceModel);
            if (tokenResponse != null)
            {
                _token = tokenResponse.Token;
                _refreshToken = tokenResponse.RefreshToken;
                _SetHeader();
            }
            else
            {
                var ex = new LiaisonClientNotAuthorized("Failed to fetch token header");
                throw ex;
            }
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

        /// <summary>
        /// Access the Account API
        /// </summary>
        public IAccountClient Account { get; }
    }
}
