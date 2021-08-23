using System;

namespace LiaisonCAS.Net.ResourceModels.ApplicationDetails
{
    public class ApplicationSubmissionResourceModel
    {
        public bool AboutMeCompleted { get; set; }
        public string? AllTxReceived { get; set; }
        public string? ApplicationLorsReceived { get; set; }
        public string? ApplicationStatus { get; set; }
        public string? AuStatus { get; set; }
        public DateTime? AuVerifiedDate { get; set; }
        public string? CasName { get; set; }
        public DateTime? CompletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? DesStatus { get; set; }
        public long? Id { get; set; }
        public string? IntentApplyResponse { get; set; }
        public DateTime? IntentApplyResponseDate { get; set; }
        public bool OnHold { get; set; }
        public bool ReAppDataRollover { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public bool Undelivered { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? VerifiedDate { get; set; }
    }
}
