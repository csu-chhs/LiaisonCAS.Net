using System;
using System.Collections.Generic;
using System.Text;

namespace LiaisonCAS.Net.ResourceModels.ApplicationDetails
{
    public class ProfileInformationResourceModel
    {
        public bool AgreedPresubmissionRelease { get; set; }
        public bool AgreedTermsOfService { get; set; }
        public string? CasId { get; set; }
        public string? ConsiderYourself { get; set; }
        public string? ConsiderYourselfId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? DescribeYourself { get; set; }
        public string? DescribeYourselfId { get; set; }
        public string? DisplayName { get; set; }
        public string? ExpressYourGender { get; set; }
        public string? ExpressYourGenderId { get; set; }
        public string? FirstName { get; set; }
        public string? Gender { get; set; }
        public long? Id { get; set; }
        public string? LastName { get; set; }
        public bool MaterialsUnderDiffName { get; set; }
        public string? MiddleName { get; set; }
        public string? NickName { get; set; }
        public string? Suffix { get; set; }
        public bool TextAuthorization { get; set; }
        public DateTime? TextAuthorizationResponseDate { get; set; }
        public string? TextConsiderYourself { get; set; }
        public string? TextDescribeYourself { get; set; }
        public string? TextExpressYourGender { get; set; }
        public string? Title { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? UserPrincipalId { get; set; }
    }
}
