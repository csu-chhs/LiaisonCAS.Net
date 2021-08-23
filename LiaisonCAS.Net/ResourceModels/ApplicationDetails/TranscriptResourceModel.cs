using System;
using System.Collections.Generic;
using System.Text;

namespace LiaisonCAS.Net.ResourceModels.ApplicationDetails
{
    public class TranscriptResourceModel
    {
        public bool AdditionalTranscript { get; set; }
        public string? BarCode { get; set; }
        public long? CollegeAttendedId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? Id { get; set; }
        public bool IsAcademicUpdate { get; set; }
        public bool IsForeign { get; set; }
        public bool IsVerified { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public bool ReceivedStatus { get; set; }
        public bool TranscriptRequired { get; set; }
        public string? TranscriptType { get; set; }
    }
}
