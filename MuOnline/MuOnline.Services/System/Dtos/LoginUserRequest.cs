namespace MuOnline.Services.System.Dtos
{
    public class LoginUserRequest
    {
        public string UserName { get; set; }
        public string PasswordWeb1 { get; set; }
        public bool RememberMe { get; set; }
    }
}
