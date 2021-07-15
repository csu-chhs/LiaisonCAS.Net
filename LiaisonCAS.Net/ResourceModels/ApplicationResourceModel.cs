using LiaisonCAS.Net.ResourceModels.ApplicationDetails;

namespace LiaisonCAS.Net.ResourceModels
{
    public class ApplicationResourceModel
    {
        public long ApplicationId { get; set; }
        public long CasApplicationId { get; set; }
        public AppGatewayResourceModel? AppGateway { get; set; }
        public PersonalInformationResourceModel? PersonalInfo { get; set; }
        public SupportingInformationResourceModel? SupportingInfo { get; set; }
    }
}
