using System;

namespace LiaisonCAS.Net.ResourceModels.ApplicationDetails
{
    public class CollegeAttendedResourceModel
    {
        public bool AcademicUpdate { get; set; }
        public string? AccreditingAgency { get; set; }
        public string? CeebCode { get; set; }
        public string? CollegeCode { get; set; }
        public string? CollegeEndMonth { get; set; }
        public long CollegeEndMonthId { get; set; }
        public int CollegeEndMonthNumber { get; set; }
        public string? CollegeEndTerm { get; set; }
        public long? CollegeEndTermId { get; set; }
        public string CollegeEndYear { get; set; }
        public long CollegeEndYearId { get; set; }

        public string? CollegeStartMonth { get; set; }
        public long? CollegeStartMonthId { get; set; }
        public int? CollegeStartMonthNumber { get; set; }
        public string? CollegeStartTerm { get; set; }
        public long? CollegeStartTermId { get; set; }
        public string? CollegeStartYear { get; set; }
        public long? CollegeStartYearId { get; set; }
        public string? Country { get; set; }
        public string? CountryCode { get; set; }
        public string? CountryIsoCode2 { get; set; }
        public string? CountryIsoCode3 { get; set; }
        public long? CountryId { get; set; }
        public bool DataRollover { get; set; }
        public string? DegreeObtained { get; set; }
        public string? FiceCode { get; set; }
        public bool Graduated { get; set; }
        public long? Id { get; set; }
        public string? IpedsCode { get; set; }
        public bool IsCwePaid { get; set; }
        public string? MdbCode { get; set; }
        public string? Name { get; set; }
        public string? SchoolCity { get; set; }
        public string? SchoolCountryCode { get; set; }
        public string? SchoolState { get; set; }
        public long? StateId { get; set; }
        public string? TermType { get; set; }
        public long? TermTypeId { get; set; }
        public string? TranscriptCode { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
