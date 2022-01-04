using FluentValidation;
using PersonInformationProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonInformationProject.Validators
{
    public class AdressValidator:AbstractValidator<Adress>
    {
        private string mesaj = "{PropertyName} alanı boş geçilemez";
        public AdressValidator()
        {
            RuleFor(x => x.Content).NotEmpty().WithMessage(mesaj);
            RuleFor(x => x.City).NotEmpty().WithMessage(mesaj);
            RuleFor(x => x.District).NotEmpty().WithMessage(mesaj);
            RuleFor(x => x.Postcode).NotEmpty().WithMessage(mesaj);
        }
    }
}
