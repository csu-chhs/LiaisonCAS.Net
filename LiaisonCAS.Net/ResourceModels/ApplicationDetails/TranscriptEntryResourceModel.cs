using System;
using System.Collections.Generic;
using System.Text;

namespace LiaisonCAS.Net.ResourceModels.ApplicationDetails
{
    public class TranscriptEntryResourceModel
    {
        public TranscriptEntryResourceModel()
        {
            GPAwes = new List<GPAwesResourceModel>();
            MgmtGpaResults = new List<MgmtGpaResultsResourceModel>();
            Transcripts = new List<TranscriptResourceModel>();
        }
        public string? CompletionStatus { get; set; }
        public List<GPAwesResourceModel> GPAwes { get; set; }
        public List<MgmtGpaResultsResourceModel> MgmtGpaResults { get; set; }
        public MgmtTranscriptSummarTotalResourceModel? MgmtTranscriptSummaryTotal { get; set; }
        public List<TranscriptResourceModel>? Transcripts { get; set; }
    }
}
