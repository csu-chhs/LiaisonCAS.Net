using LiaisonCAS.Net.ResourceModels;

namespace LiaisonCAS.Net.Interfaces
{
    public interface IAccountClient
    {
        /// <summary>
        /// Fetch current Account Information
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        Task<AccountInformationResourceModel?> GetAccountInformationAsync(CancellationToken token);
    }
}
