﻿using LiaisonCAS.Net.ResourceModels;

namespace LiaisonCAS.Net.Interfaces
{
    public interface IFileClient
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="applicationFormId"></param>
        /// <param name="organizationId"></param>
        /// <param name="fileId"></param>
        /// <param name="documentType"></param>
        /// <returns></returns>
        FileResourceModel GetFileContent(int applicationFormId,
            int organizationId, long fileId, string documentType);

        /// <summary>
        /// Async version
        /// </summary>
        /// <param name="applicationFormId"></param>
        /// <param name="organizationId"></param>
        /// <param name="fileId"></param>
        /// <param name="documentType"></param>
        /// <returns></returns>
        Task<FileResourceModel> GetFileContentAsync(int applicationFormId,
            int organizationId, long fileId, string documentType);
    }
}
