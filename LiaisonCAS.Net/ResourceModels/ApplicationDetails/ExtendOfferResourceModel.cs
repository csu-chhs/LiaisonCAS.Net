using System;
using System.Collections.Generic;
using System.Text;

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
