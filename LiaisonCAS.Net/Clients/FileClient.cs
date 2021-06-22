using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LiaisonCAS.Net.Interfaces;
using RestSharp;

namespace LiaisonCAS.Net.Clients
{
    public class FileClient : IFileClient
    {
        private readonly RestClient _client { get; set; }

        public FileClient(RestClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Fetch the contents of a file.
        /// </summary>
        /// <param name="applicationFormId"></param>
        /// <param name="organizationId"></param>
        /// <param name="fileId"></param>
        /// <returns></returns>
        public async Task<byte[]> GetFileContentAsync(int applicationFormId, int organizationId, int fileId)
        {
            return TODO_IMPLEMENT_ME;
        }
    }
}
