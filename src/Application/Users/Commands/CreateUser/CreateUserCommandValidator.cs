using FluentValidation;

namespace Talks.Application.Users.Commands.CreateUser
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(x => x.ExternalId)
                .NotEmpty().WithMessage("No external id provided");
        }
    }
}
