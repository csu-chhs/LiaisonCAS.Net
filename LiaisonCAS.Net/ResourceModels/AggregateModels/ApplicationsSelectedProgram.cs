namespace LiaisonCAS.Net.ResourceModels.AggregateModels
{
    public class ApplicationsSelectedProgram
    {
        public ApplicationsSelectedProgram()
        {
            name = string.Empty;
            submissionStatus = string.Empty;
        }

        public DateTime? deadline { get; set; }
        public long Id { get; set; }
        public string name { get; set; }
        public string submissionStatus { get; set; }
    }
}
