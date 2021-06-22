using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LiaisonCAS.Net.Interfaces
{
    public interface IFileClient
    {
        /// <summary>
        /// Fetch the contents of a file.
        /// </summary>
        /// <param name="applicationFormId"></param>
        /// <param name="organizationId"></param>
        /// <param name="fileId"></param>
        /// <returns></returns>
        Task<byte[]> GetFileContentAsync(int applicationFormId,
            int organizationId, int fileId);
    }
}
