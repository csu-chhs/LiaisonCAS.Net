namespace LiaisonCAS.Net.ResourceModels
{
    public class AuthenticationTokenResponseResourceModel
    {
        public AuthenticationTokenResponseResourceModel()
        {
            Token = string.Empty;
            RefreshToken = string.Empty;
        }

        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
