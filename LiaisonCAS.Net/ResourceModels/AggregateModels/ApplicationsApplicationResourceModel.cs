using System;
using System.Collections.Generic;
using System.Text;

namespace LiaisonCAS.Net.ResourceModels.AggregateModels
{
    /// <summary>
    /// This class represents the embedded "Applications" object
    /// returned for multiple application API calls.
    /// </summary>
    public class ApplicationsApplicationResourceModel
    {
        public ApplicationsApplicationResourceModel()
        {
            SelectedPrograms = new List<ApplicationsSelectedProgram>();
        }

        public string AlternateApplicationId { get; set; }
        public string ApplicantFirstName { get; set; }
        public string ApplicantLastName { get; set; }
        public long ApplicationId { get; set; }
        public string ApplicationStatus { get; set; }
        public long CasApplicantId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public List<ApplicationsSelectedProgram> SelectedPrograms { get; set; }
    }
}
