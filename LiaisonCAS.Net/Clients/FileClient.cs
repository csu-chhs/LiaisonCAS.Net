using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LiaisonCAS.Net.Exceptions;
using LiaisonCAS.Net.Interfaces;
using LiaisonCAS.Net.ResourceModels;
using RestSharp;

namespace LiaisonCAS.Net.Clients
{
    public class FileClient : IFileClient
    {
        private readonly RestClient _client;

        public FileClient(RestClient client)
        {
            _client = client;
        }


        /// <summary>
        /// This method returns a byte array OR
        /// a URL to the file depending on the content
        /// type.
        /// </summary>
        /// <param name="applicationFormId"></param>
        /// <param name="organizationId"></param>
        /// <param name="fileId"></param>
        /// <param name="documentType"></param>
        /// <returns></returns>
        public FileResourceModel GetFileContent(int applicationFormId, int organizationId, 
            long fileId, string documentType)
        {
            var request = new RestRequest($"applicationForms/{applicationFormId}/organizations/{organizationId}/files/{fileId}");
            request.AddParameter("docType", documentType);
            FileResourceModel resourceModel = new FileResourceModel();

            try
            {
                // Try to download data first? 
                byte[] data = _client.DownloadData(request);
                resourceModel.Data = data;
                Thread.Sleep(1025);
                var response = _client.Execute(request);
                resourceModel.ContentType = response.ContentType;

                return resourceModel;
            }
            catch (Exception ex)
            {
                try
                {
                    // Assume that this is a URL
                    Thread.Sleep(1025);
                    var response = _client.Execute(request);
                    if (response.ContentType == "text/plain")
                    {
                        resourceModel.Url = response.Content;
                    }

                    return resourceModel;
                }
                catch (Exception ex2)
                {
                    throw new LiaisonClientException($"Could not fetch document {fileId}");
                }
            }
        }
    }
}
