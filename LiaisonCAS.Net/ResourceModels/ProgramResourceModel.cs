﻿namespace LiaisonCAS.Net.ResourceModels
{
    public class ProgramResourceModel
    {
        public ProgramResourceModel()
        {
            Name = string.Empty;
            Code = string.Empty;
            OrgName = string.Empty;
            Status = string.Empty;
            UniqueIdentifierString = string.Empty;
            WebadmitName = string.Empty;
        }
        public string Code { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? Deadline { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int OrgId { get; set; }
        public string OrgName { get; set; }
        public DateTime? StartDate { get; set; }
        public string Status { get; set; }
        public string UniqueIdentifierString { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string WebadmitName { get; set; }
    }
}
