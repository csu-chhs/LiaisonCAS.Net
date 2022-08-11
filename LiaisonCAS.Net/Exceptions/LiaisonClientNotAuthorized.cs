namespace LiaisonCAS.Net.Exceptions
{
    public class LiaisonClientNotAuthorized : Exception
    {
        public LiaisonClientNotAuthorized() : base()
        {

        }

        public LiaisonClientNotAuthorized(string message) : base(message)
        {

        }

        public LiaisonClientNotAuthorized(string message, Exception? inner) : base(message, inner)
        {

        }

        /// <summary>
        /// Adds a data object for the web stack trace response.
        /// </summary>
        /// <param name="webStackTrace"></param>
        public void AddWebTrace(string? webStackTrace)
        {
            if (webStackTrace != null)
            {
                Data.Add("Web API Response", webStackTrace);
            }
        }
    }
}
