using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talks.Application.Common.Interfaces;

namespace Talks.Application.Conventions.Commands.CreateConvention
{
    public class CreateConventionCommandValidator : AbstractValidator<CreateConventionCommand>
    {
        public CreateConventionCommandValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title is required.")
                .MaximumLength(200).WithMessage("Title must not exceed 200 characteres");
        }
    }
}
