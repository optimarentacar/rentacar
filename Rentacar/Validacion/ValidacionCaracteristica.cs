using FluentValidation;
using Rentacar.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Validacion
{
    class ValidacionCaracteristica : AbstractValidator<Caracteristica>
    {
        public ValidacionCaracteristica()
        {
            RuleFor(carateristica => carateristica.Nombre)
                .NotNull().WithMessage("El nombre de la característica debe tener " +
                    "entre 1 y 255 caracteres.")
                .NotEmpty().WithMessage("El nombre de la característica debe tener " +
                    "entre 1 y 255 caracteres.")
                .Length(1, 255).WithMessage("El nombre de la característica debe tener " +
                    "entre 1 y 255 caracteres.");

        }
    }
}
