using System.Threading.Tasks;
using LiaisonCAS.Net.ResourceModels;
using LiaisonCAS.Net.ResourceModels.AggregateModels;

namespace LiaisonCAS.Net.Interfaces
{
    public interface IApplicationClient
    {
        /// <summary>
        /// Fetch a given application.
        /// </summary>
        /// <param name="applicationFormId"></param>
        /// <param name="applicationId"></param>
        /// <returns></returns>
        Task<ApplicationResourceModel> GetApplicationAsync(int applicationFormId, 
            long applicationId);

        Task<ApplicationResourceModel> GetApplicationAsync(int applicationFormId,
            int organizationId, int programId, long applicationId);

        ApplicationResourceModel GetApplication(int applicationFormId,
            int organizationId, int programId, long applicationId);
        
        /// <summary>
        /// Fetch a given application
        /// </summary>
        /// <param name="applicationFormId"></param>
        /// <param name="applicationId"></param>
        /// <returns></returns>
        ApplicationResourceModel GetApplication(int applicationFormId,
            int applicationId);
        
        /// <summary>
        /// Fetch all applications by organization/program.
        /// </summary>
        /// <param name="applicationFormId"></param>
        /// <param name="organizationId"></param>
        /// <param name="programId"></param>
        /// <returns></returns>
        Task<ListApplicationsResourceModel> GetApplicationsAsync(int applicationFormId,
            int organizationId, int programId);
        
        /// <summary>
        /// Fetch all applications by organization/program.
        /// </summary>
        /// <param name="applicationFormId"></param>
        /// <param name="organizationId"></param>
        /// <param name="programId"></param>
        /// <returns></returns>
        ListApplicationsResourceModel GetApplications(int applicationFormId,
            int organizationId, int programId);
    }
}
