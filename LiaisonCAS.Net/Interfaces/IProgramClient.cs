using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LiaisonCAS.Net.ResourceModels;

namespace LiaisonCAS.Net.Interfaces
{
    public interface IProgramClient
    {
        /// <summary>
        /// Get a list of programs for the given
        /// requested application form id and organization id.
        /// </summary>
        /// <param name="applicationFormId"></param>
        /// <param name="organizationId"></param>
        /// <returns></returns>
        Task<List<ProgramResourceModel>> GetProgramsAsync(int applicationFormId, int organizationId);

        /// <summary>
        /// Get a list of programs for the given
        /// requested application form id and organization id.
        /// </summary>
        /// <param name="applicationFormId"></param>
        /// <param name="organizationId"></param>
        /// <returns></returns>
        List<ProgramResourceModel> GetPrograms(int applicationFormId, int organizationId);
    }
}
