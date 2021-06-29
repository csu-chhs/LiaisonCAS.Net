using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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

            throw new LiaisonClientException($"Failed to fetch programs",
                response.ErrorException);
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
            var response = _client.Execute<List<ProgramResourceModel>>(request);
            if (response.IsSuccessful)
            {
                return response.Data;
            }

            throw new LiaisonClientException($"Failed to fetch programs",
                response.ErrorException);
        }
    }
}
