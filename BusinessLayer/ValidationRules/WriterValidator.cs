using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Cannot be left empty");
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Cannot be left empty");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Cannot be left empty");
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Please enter at least 2 characters");
			RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Please enter a maximum of 50 characters");
		}
    }
}
