namespace LiaisonCAS.Net.ResourceModels
{
    public class AccountInformationIdentifier
    {
        public AccountInformationIdentifier()
        {
            Organization = string.Empty;
        }

        public long? ApplicationFormId { get; set; }
        public string? Cas { get; set; }
        public string? Cycle { get; set; }
        public string Organization { get; set; }
        public long? OrganizationId { get; set; }
    }
}
