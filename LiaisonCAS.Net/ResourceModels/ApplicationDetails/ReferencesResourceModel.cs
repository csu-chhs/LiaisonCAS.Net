using System;
using System.Collections.Generic;
using System.Text;

namespace LiaisonCAS.Net.ResourceModels.ApplicationDetails
{
    public class ReferencesResourceModel
    {
        public ReferencesResourceModel()
        {
            References = new List<ReferenceResourceModel>();
        }
        public string? CompletionStatus { get; set; }
        public List<ReferenceResourceModel>? References { get; set; }
    }
}
