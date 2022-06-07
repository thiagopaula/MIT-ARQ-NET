using FluentValidation;

namespace Spotify.Domain.User.Rules
{
    public class UserValidator : AbstractValidator<User>
    {

        public UserValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.Email).SetValidator(new EmailValidator());
            RuleFor(x => x.CPF).SetValidator(new CPFValidator());
        }

    }
}
