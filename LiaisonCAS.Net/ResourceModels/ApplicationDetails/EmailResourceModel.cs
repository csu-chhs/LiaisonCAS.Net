using System;

namespace LiaisonCAS.Net.ResourceModels.ApplicationDetails
{
    public class EmailResourceModel
    {
        public DateTime? CreatedDate { get; set; }
        public string? EmailAddress { get; set; }
        public string? EmailType { get; set; }
        public long? EmailTypeId { get; set; }
        public long? Id { get; set; }
        public bool PreferredEmail { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
