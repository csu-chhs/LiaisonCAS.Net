using System;
using System.Collections.Generic;
using System.Text;

namespace LiaisonCAS.Net.ResourceModels.AggregateModels
{
    public class ListApplicationsResourceModel
    {
        public ListApplicationsResourceModel()
        {
            Items = new List<ApplicationResourceModel>();
        }
        public List<ApplicationResourceModel> Items { get; set; }
    }
}
