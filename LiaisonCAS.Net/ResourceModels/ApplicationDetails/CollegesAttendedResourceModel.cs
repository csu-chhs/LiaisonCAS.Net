using System;
using System.Collections.Generic;
using System.Text;

namespace LiaisonCAS.Net.ResourceModels.ApplicationDetails
{
    public class CollegesAttendedResourceModel
    {
        public CollegesAttendedResourceModel()
        {
            CollegesAttended = new List<CollegeAttendedResourceModel>();
            Degrees = new List<DegreeResourceModel>();
        }
        public string? CompletionStatus { get; set; }
        public List<CollegeAttendedResourceModel> CollegesAttended { get; set; }
        public List<DegreeResourceModel> Degrees { get; set; }
    }
}
