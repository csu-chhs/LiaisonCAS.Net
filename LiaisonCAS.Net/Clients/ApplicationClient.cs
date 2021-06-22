using LiaisonCAS.Net.Interfaces;
using RestSharp;

namespace LiaisonCAS.Net.Clients
{
    public class ApplicationClient : IApplicationClient
    {
        private readonly RestClient _client;

        public ApplicationClient(RestClient client)
        {
            _client = client;
        }
        
    }
}
