namespace LiaisonCAS.Net.ResourceModels
{
    public class AuthenticationTokenRefreshResourceModel
    {
        public AuthenticationTokenRefreshResourceModel()
        {
            RefreshToken = string.Empty;
        }

        public AuthenticationTokenRefreshResourceModel(string refreshToken)
        {
            RefreshToken = refreshToken;
        }

        public string RefreshToken { get; set; }
    }
}
