using FluentValidation;
using Rentacar.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Validacion
{
    public class ValidacionAccesorio : AbstractValidator<Accesorio>
    {
        public ValidacionAccesorio()
        {
            RuleFor(accesorio => accesorio.Nombre)
                .NotNull().WithMessage("El nombre del accesorio debe tener " +
                    "entre 1 y 255 caracteres.")
                .NotEmpty().WithMessage("El nombre del accesorio debe tener " +
                    "entre 1 y 255 caracteres.")
                .Length(1, 255).WithMessage("El nombre del accesorio debe tener " +
                    "entre 1 y 255 caracteres.");

            RuleFor(accesorio => accesorio.Costo)
             .GreaterThan(0)
               .WithMessage("El precio del accesorio no es correcto.")
             .Must(SerUnCostoValido)
               .WithMessage("El precio del accesorio no es correcto.");
        }

        /// <summary>
        ///     Comprueba si el costo es válido o no
        /// </summary>
        /// <param name="costo"></param>
        /// <returns></returns>
        private bool SerUnCostoValido(float costo)
        {
            string sCosto = costo.ToString();
            bool esValido = true;

            if (sCosto.Contains("."))
            {
                string parteDecimal = sCosto.Substring(sCosto.IndexOf("."));
                int cantidadDigitos = parteDecimal.Length;

                if (cantidadDigitos > 2)
                {
                    esValido = false;
                }
            }
            else if (sCosto.Contains(","))
            {
                string parteDecimal = sCosto.Substring(sCosto.IndexOf(","));
                int cantidadDigitos = parteDecimal.Length;

                if (cantidadDigitos > 3)
                {
                    esValido = false;
                }
            }

            return esValido;
        }
    }
}
