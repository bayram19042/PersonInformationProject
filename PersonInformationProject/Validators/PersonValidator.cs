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
        private string mesaj = "{PropertyName} alanı boş geçilemez";
        public PersonValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage(mesaj).EmailAddress().WithMessage("@ işareti olmalıdır.");
            RuleFor(x => x.Name).NotEmpty().WithMessage(mesaj);
            RuleFor(x => x.Surname).NotEmpty().WithMessage(mesaj);
            RuleFor(x => x.Telephone).NotEmpty().WithMessage(mesaj);
            RuleForEach(x => x.Adresses).SetValidator(new AdressValidator());
        }
    }
}
