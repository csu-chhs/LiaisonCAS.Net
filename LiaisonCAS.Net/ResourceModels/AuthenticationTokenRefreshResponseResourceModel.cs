namespace LiaisonCAS.Net.ResourceModels
{
    public class AuthenticationTokenRefreshResponseResourceModel
    {
        public AuthenticationTokenRefreshResponseResourceModel()
        {
            Token = string.Empty;
        }

        public string Token { get; set; }
    }
}
