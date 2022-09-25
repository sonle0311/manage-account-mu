namespace MuOnline.Services.System.Dtos
{
    public class RegisterUserRequest
    {
        public string UserName { get; set; }
        public string PasswordGame { get; set; }
        public string PasswordWeb1 { get; set; }
        public string PasswordWeb2 { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
