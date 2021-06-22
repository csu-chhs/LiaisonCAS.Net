using System.Threading.Tasks;
using LiaisonCAS.Net.Interfaces;

namespace LiaisonCAS.Net
{
    public interface ILiaisonCASClient
    {
        void SetupAuthenticationHeaders();
        Task SetupAuthenticationHeadersAsync();
        IApplicationClient Application { get; }
    }
}
