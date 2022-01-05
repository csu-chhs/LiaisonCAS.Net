using System.Net;
using LiaisonCAS.Net.Exceptions;
using LiaisonCAS.Net.Interfaces;
using LiaisonCAS.Net.ResourceModels;
using LiaisonCAS.Net.ResourceModels.AggregateModels;
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

        /// <summary>
        /// Fetch a given application.
        /// </summary>
        /// <param name="applicationFormId"></param>
        /// <param name="applicationId"></param>
        /// <returns></returns>
        public async Task<ApplicationResourceModel> GetApplicationAsync(int applicationFormId, long applicationId)
        {
            var request = new RestRequest($"applicationForms/{applicationFormId}/applications/{applicationId}");
            var response = await _client.ExecuteAsync<ApplicationResourceModel>(request);
            if (response.IsSuccessful)
            {
                return response.Data;
            }

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new LiaisonClientNotAuthorized($"Application ID {applicationId} Unauthorized");
            }

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                throw new LiaisonClientNotFound($"Application ID {applicationId} not found");
            }

            throw new LiaisonClientException($"Failed to fetch application {applicationId} {response.StatusCode}",
                response.ErrorException);

        }

        public async Task<ApplicationResourceModel> GetApplicationAsync(int applicationFormId, int organizationId, 
            int programId, long applicationId, string expand = "all")
        {
            var request =
                new RestRequest(
                    $"applicationForms/{applicationFormId}/organizations/{organizationId}/programs/{programId}/applications/{applicationId}");
            request.AddParameter("expand", expand);
            var response = await _client.ExecuteAsync<ApplicationResourceModel>(request);
            if (response.IsSuccessful)
            {
                return response.Data;
            }

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new LiaisonClientNotAuthorized($"Application ID {applicationId} Unauthorized");
            }

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                throw new LiaisonClientNotFound($"Application ID {applicationId} not found");
            }

            throw new LiaisonClientException($"Failed to fetch application {applicationId} {response.StatusCode}",
                response.ErrorException);
        }

        public ApplicationResourceModel GetApplication(int applicationFormId, int organizationId, 
            int programId, long applicationId, string expand = "all")
        {
            var request =
                new RestRequest(
                    $"applicationForms/{applicationFormId}/organizations/{organizationId}/programs/{programId}/applications/{applicationId}");
            request.AddParameter("expand", expand);
            var response = _client.Execute<ApplicationResourceModel>(request);
            if (response.IsSuccessful)
            {
                return response.Data;
            }

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new LiaisonClientNotAuthorized($"Application ID {applicationId} Unauthorized");
            }

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                throw new LiaisonClientNotFound($"Application ID {applicationId} not found");
            }

            throw new LiaisonClientException($"Failed to fetch application {applicationId} {response.StatusCode}",
                response.ErrorException);
        }

        /// <summary>
        /// Fetch a given application
        /// </summary>
        /// <param name="applicationFormId"></param>
        /// <param name="applicationId"></param>
        /// <returns></returns>
        public ApplicationResourceModel GetApplication(int applicationFormId, long applicationId)
        {
            var request = new RestRequest($"applicationForms/{applicationFormId}/applications/{applicationId}");
            var response = _client.Execute<ApplicationResourceModel>(request);
            if (response.IsSuccessful)
            {
                return response.Data;
            }

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new LiaisonClientNotAuthorized($"Application ID {applicationId} Unauthorized");
            }

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                throw new LiaisonClientNotFound($"Application ID {applicationId} not found");
            }

            throw new LiaisonClientException($"Failed to fetch application {applicationId} {response.StatusCode}",
                response.ErrorException);
        }

        /// <summary>
        /// Fetch all applications by organization/program.
        /// </summary>
        /// <param name="applicationFormId"></param>
        /// <param name="organizationId"></param>
        /// <param name="programId"></param>
        /// <returns></returns>
        public async Task<ListApplicationsResourceModel> GetApplicationsAsync(int applicationFormId, 
            int organizationId, int programId)
        {
            var request =
                new RestRequest(
                    $"applicationForms/{applicationFormId}/organizations/{organizationId}/programs/{programId}/applications");
            var response = await _client.ExecuteAsync<ListApplicationsResourceModel>(request);
            if (response.IsSuccessful)
            {
                return response.Data;
            }

            throw new LiaisonClientException("Failed to fetch applications",
                response.ErrorException);
        }

        /// <summary>
        /// Fetch all applications by organization/program.
        /// </summary>
        /// <param name="applicationFormId"></param>
        /// <param name="organizationId"></param>
        /// <param name="programId"></param>
        /// <returns></returns>
        public ListApplicationsResourceModel GetApplications(int applicationFormId, int organizationId, int programId)
        {
            var request =
                new RestRequest(
                    $"applicationForms/{applicationFormId}/organizations/{organizationId}/programs/{programId}/applications");
            var response = _client.Execute<ListApplicationsResourceModel>(request);
            if (response.IsSuccessful)
            {
                return response.Data;
            }

            throw new LiaisonClientException("Failed to fetch applications",
                response.ErrorException);
        }
    }
}
