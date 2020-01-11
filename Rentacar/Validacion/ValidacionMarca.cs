using FluentValidation;
using Rentacar.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Validacion
{
    public class ValidacionMarca : AbstractValidator<Marca>
    {
        public ValidacionMarca()
        {
            RuleFor(marca => marca.Nombre)
                .NotNull().WithMessage("El nombre de la marca debe tener " +
                    "entre 1 y 255 caracteres.")
                .NotEmpty().WithMessage("El nombre de la marca debe tener " +
                    "entre 1 y 255 caracteres.")
                .Length(1, 255).WithMessage("El nombre de la marca debe tener " +
                    "entre 1 y 255 caracteres.");
        }
    }
}
