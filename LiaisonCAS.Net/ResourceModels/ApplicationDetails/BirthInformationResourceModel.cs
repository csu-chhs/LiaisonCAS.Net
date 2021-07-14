using System;
using System.Collections.Generic;
using System.Text;

namespace LiaisonCAS.Net.ResourceModels.ApplicationDetails
{
    public class BirthInformationResourceModel
    {
        public DateTime? Dob { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? CountryIsoCode2 { get; set; }
        public string? CountryCode { get; set; }
        public string? CountryIsoCode3 { get; set; }
        public long? CountryId { get; set; }
        public string? County { get; set; }
        public string? CountyAbbreviation { get; set; }
        public long? CountyId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long Id { get; set; }
        public string? State { get; set; }
        public string? StateAbbreviation { get; set; }
        public string? StateIsoCode2 { get; set; }
        public long? StateId { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
