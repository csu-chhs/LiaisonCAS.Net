using System;
using System.Collections.Generic;
using System.Text;

namespace LiaisonCAS.Net.ResourceModels.ApplicationDetails
{
    public class GpaEntriesResourceModel
    {
        public GpaEntriesResourceModel()
        {
            MgmtTranscriptSummaries = new List<ManagementTranscriptSummariesResourceModel>();
        }
        public List<ManagementTranscriptSummariesResourceModel> MgmtTranscriptSummaries { get; set; }
    }
}
