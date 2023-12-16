using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator() 
        {
            RuleFor(x=>x.BlogTitle).NotEmpty().WithMessage("You cant skip the blog title");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("You cant skip the blog content");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("You cant skip the blog image");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Please enter a maximum of 150 characters");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Please enter at least 5 characters");
        }
    }
}
