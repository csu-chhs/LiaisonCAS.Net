using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiaisonCAS.Net.ResourceModels
{
    public class AccountInformationResourceModel
    {
        public AccountInformationResourceModel()
        {
            Identifiers = new();
        }
        public string? UserLevel { get; set; }
        public string? UserName { get; set; }
        public List<AccountInformationIdentifier> Identifiers { get; set; }
    }
}
