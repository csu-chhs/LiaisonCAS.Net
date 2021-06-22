using System.Threading.Tasks;
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
        public async Task<ApplicationResourceModel> GetApplicationAsync(int applicationFormId, int applicationId)
        {
            return TODO_IMPLEMENT_ME;
        }

        /// <summary>
        /// Fetch a given application
        /// </summary>
        /// <param name="applicationFormId"></param>
        /// <param name="applicationId"></param>
        /// <returns></returns>
        public ApplicationResourceModel GetApplication(int applicationFormId, int applicationId)
        {
            return TODO_IMPLEMENT_ME;
        }

        /// <summary>
        /// Fetch all applications by organization/program.
        /// </summary>
        /// <param name="applicationFormId"></param>
        /// <param name="organizationId"></param>
        /// <param name="programId"></param>
        /// <returns></returns>
        public async Task<ListApplicationsResourceModel> GetApplicationsAsync(int applicationFormId, int organizationId, int programId)
        {
            return TODO_IMPLEMENT_ME;
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
            return TODO_IMPLEMENT_ME;
        }
    }
}
