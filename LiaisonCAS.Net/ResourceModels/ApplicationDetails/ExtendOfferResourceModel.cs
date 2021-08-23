using System.Collections.Generic;

namespace LiaisonCAS.Net.ResourceModels.ApplicationDetails
{
    public class ExtendOfferResourceModel
    {
        public ExtendOfferResourceModel()
        {
            GatewayExtendOffers = new List<ExtendedOffersResourceModel>();
        }
        public string? CompletionStatus { get; set; }
        public List<ExtendedOffersResourceModel> GatewayExtendOffers { get; set; }
    }
}
