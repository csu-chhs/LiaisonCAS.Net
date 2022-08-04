using LiaisonCAS.Net;
using LiaisonCAS.Net.Exceptions;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace LiaisonCAS.Net.Extensions.Diagnostics
{
    public class LiaisonCasNetHealthCheck : IHealthCheck
    {
        private ILiaisonCASClient _casClient;

        public LiaisonCasNetHealthCheck(ILiaisonCASClient casClient)
        {
            _casClient = casClient;
        }

        /// <summary>
        /// Runs the health check, returning the status of the component being checked.
        /// </summary>
        /// <param name="context">A context object associated with the current execution.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> that can be used to cancel the health check.</param>
        /// <returns>A <see cref="T:System.Threading.Tasks.Task`1" /> that completes when the health check has finished, yielding the status of the component being checked.</returns>
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, 
            CancellationToken cancellationToken = new CancellationToken())
        {
            bool isHealthy = true;

            try
            {
                await _casClient.Account.GetAccountInformationAsync(cancellationToken);
            }
            catch (LiaisonClientException)
            {
                isHealthy = false;
            }

            if (isHealthy)
            {
                return HealthCheckResult.Healthy("Liaison CAS Net API Connection is Operational");
            }

            return HealthCheckResult.Unhealthy("Liaison CAS Net API Connection is not Operational");
        }
    }
}
