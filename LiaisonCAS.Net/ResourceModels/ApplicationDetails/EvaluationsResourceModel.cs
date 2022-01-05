using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiaisonCAS.Net.ResourceModels.ApplicationDetails
{
    public class EvaluationsResourceModel
    {
        public EvaluationsResourceModel()
        {
            EvaluationResponses = new List<EvaluationResponseResourceModel>();
        }

        public string? CompletionStatus { get; set; }
        public List<EvaluationResponseResourceModel> EvaluationResponses { get; set; }
    }
}
