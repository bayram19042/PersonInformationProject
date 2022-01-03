using FluentValidation;
using PersonInformationProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonInformationProject.Validators
{
    public class PersonValidator:AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("{PropertyName } alanı boş geçilemez").EmailAddress().WithMessage("@ işareti olmalıdır.");
            RuleFor(x => x.Name).NotEmpty().WithMessage("{PropertyName} alanı boş geçilemez");
        }
    }
}
