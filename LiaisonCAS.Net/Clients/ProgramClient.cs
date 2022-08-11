using System.Net;
using LiaisonCAS.Net.Exceptions;
using LiaisonCAS.Net.Interfaces;
using LiaisonCAS.Net.ResourceModels;
using RestSharp;

namespace LiaisonCAS.Net.Clients
{
    public class ProgramClient : IProgramClient
    {
        private readonly RestClient _client;

        public ProgramClient(RestClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Get a list of programs for the given
        /// requested application form id and organization id.
        /// </summary>
        /// <param name="applicationFormId"></param>
        /// <param name="organizationId"></param>
        /// <returns></returns>
        public async Task<List<ProgramResourceModel>> GetProgramsAsync(int applicationFormId, int organizationId)
        {
            var request =
                new RestRequest($"applicationForms/{applicationFormId}/organizations/{organizationId}/programs");
            var response = await _client.ExecuteAsync<List<ProgramResourceModel>>(request);

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                throw new LiaisonClientNotFound("Object not found");
            }

            if (response.IsSuccessful)
            {
                return response.Data;
            }

            var ex = new LiaisonClientException($"Failed to fetch programs",
                response.ErrorException);
            if (response.Content != null)
            {
                ex.AddWebTrace(response.Content);
            }
            
            throw ex;
        }

        /// <summary>
        /// Get a list of programs for the given
        /// requested application form id and organization id.
        /// </summary>
        /// <param name="applicationFormId"></param>
        /// <param name="organizationId"></param>
        /// <returns></returns>
        public List<ProgramResourceModel> GetPrograms(int applicationFormId, int organizationId)
        {
            var request =
                new RestRequest($"applicationForms/{applicationFormId}/organizations/{organizationId}/programs");
            var response = _client.ExecuteAsync<List<ProgramResourceModel>>(request).Result;
            if (response.IsSuccessful)
            {
                return response.Data;
            }

            var ex = new LiaisonClientException($"Failed to fetch programs",
                response.ErrorException);
            if (response.Content != null)
            {
                ex.AddWebTrace(response.Content);
            }

            throw ex;
        }
    }
}
