using FluentValidation;

namespace Talks.Application.Talks.Commands.CreateTalk
{
    public class CreateTalkCommandValidator : AbstractValidator<CreateTalkCommand>
    {
        public CreateTalkCommandValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title is required.")
                .MaximumLength(200).WithMessage("Title must not exceed 200 characteres");
        }
    }
}
