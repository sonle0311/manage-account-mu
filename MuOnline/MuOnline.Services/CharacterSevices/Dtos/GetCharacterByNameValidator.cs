using FluentValidation;

namespace MuOnline.Services.CharacterSevices.Dtos
{
    public class GetCharacterByNameValidator : AbstractValidator<GetCharacterByNameRequest>
    {
        public GetCharacterByNameValidator()
        {
            RuleFor(x => x.AccountName).NotEmpty().WithMessage("AccountName is required");
            RuleFor(x => x.CharacterName).NotEmpty().WithMessage("CharacterName is required");
        }
    }
}
