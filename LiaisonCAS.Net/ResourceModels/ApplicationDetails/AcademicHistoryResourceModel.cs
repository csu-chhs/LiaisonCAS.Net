using System;
using System.Collections.Generic;
using System.Text;

namespace LiaisonCAS.Net.ResourceModels.ApplicationDetails
{
    public class AcademicHistoryResourceModel
    {
        public string CompletionStatus { get; set; }
        public GpaEntriesResourceModel? GpaEntries { get; set; }
        public CollegesAttendedResourceModel? CollegesAttended { get; set; }
        public TranscriptEntryResourceModel? TranscriptEntry { get; set; }

    }
}
