namespace LiaisonCAS.Net.ResourceModels
{
    public class AuthenticationTokenResourceModel
    {
        public AuthenticationTokenResourceModel(string username,
            string password)
        {
            UserName = username;
            Password = password;
        }

        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
