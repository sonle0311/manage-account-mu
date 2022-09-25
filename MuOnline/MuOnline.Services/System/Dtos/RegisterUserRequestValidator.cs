using FluentValidation;

namespace MuOnline.Services.System.Dtos
{
    public class RegisterUserRequestValidator : AbstractValidator<RegisterUserRequest>
    {
        public RegisterUserRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName is required");
            RuleFor(x => x.PasswordGame)
                .NotEmpty().WithMessage("PasswordGame is required")
                .MinimumLength(6).WithMessage("Password is at least 6 characters");
            RuleFor(x => x.PasswordWeb1)
                .NotEmpty().WithMessage("PasswordWeb1 is required")
                .MinimumLength(6).WithMessage("PasswordWeb1 is at least 6 characters");
            RuleFor(x => x.PasswordWeb2)
                .NotEmpty().WithMessage("PasswordWeb2 is required")
                .MinimumLength(6).WithMessage("PasswordWeb2 is at least 6 characters");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required")
                .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")
                .WithMessage("Email format not match");

            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Phone number is required");
        }
    }
}
