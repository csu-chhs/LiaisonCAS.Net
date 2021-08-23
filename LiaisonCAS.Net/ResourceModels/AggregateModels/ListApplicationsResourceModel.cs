using System.Collections.Generic;

namespace LiaisonCAS.Net.ResourceModels.AggregateModels
{
    public class ListApplicationsResourceModel
    {
        public ListApplicationsResourceModel()
        {
            applications = new List<ApplicationsApplicationResourceModel>();
        }
        public List<ApplicationsApplicationResourceModel> applications { get; set; }
        public List<string> validationErrors { get; set; }
    }
}
