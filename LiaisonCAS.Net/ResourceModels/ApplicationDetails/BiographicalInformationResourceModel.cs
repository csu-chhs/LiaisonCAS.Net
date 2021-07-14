using System;
using System.Collections.Generic;
using System.Text;

namespace LiaisonCAS.Net.ResourceModels.ApplicationDetails
{
    public class BiographicalInformationResourceModel
    {
        public BirthInformationResourceModel BirthInfo { get; set; }
        public ProfileInformationResourceModel Profile { get; set; }
    }
}
