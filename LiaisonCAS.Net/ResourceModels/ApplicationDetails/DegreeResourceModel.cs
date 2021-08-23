using System;

namespace LiaisonCAS.Net.ResourceModels.ApplicationDetails
{
    public class DegreeResourceModel
    {
        public DateTime? CreatedDate { get; set; }
        public string? DegreeStatus { get; set; }
        public long? DegreeStatusId { get; set; }
        public long? Id { get; set; }
        public string? Major { get; set; }
        public long? MajorId { get; set; }
        public string? Minor { get; set; }
        public long? MinorId { get; set; }
        public string? Month { get; set; }
        public long? MonthId { get; set; }
        public int MonthNumber { get; set; }
        public string? SecondMajor { get; set; }
        public long? SecondMajorId { get; set; }
      
        public string? Type { get; set; }
        public long? TypeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? Year { get; set; }
        public long? YearId { get; set; }
    }
}
