using System;
using System.Collections.Generic;
using System.Text;

namespace LiaisonCAS.Net.ResourceModels.ApplicationDetails
{
    public class PersonalInformationResourceModel
    {
        public BiographicalInformationResourceModel? BiographicInfo { get; set; }
        public ContactInformationResourceModel? ContactInfo { get; set; }
    }
}
