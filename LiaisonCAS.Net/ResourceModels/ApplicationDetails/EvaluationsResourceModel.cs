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
