using FluentValidation;
using Rentacar.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Validacion
{
    public class ValidacionVehiculo : AbstractValidator<Vehiculo>
    {
        public ValidacionVehiculo()
        {
            RuleFor(vehiculo => vehiculo.Matricula)
                  .Matches("^[0-9]{4}[a-zA-Z]{3}$")
                    .WithMessage("La matrícula es incorrecta.");

            RuleFor(vehiculo => vehiculo.Modelo)
               .NotNull()
                   .WithMessage("El vehículo debe tener un nombre de modelo.")
               .NotEmpty()
                   .WithMessage("El vehículo debe tener un nombre de modelo.")
               .Length(1, 255)
                   .WithMessage("El nombre del modelo no puede " +
                       "ser de más de 255 caracteres.");

            RuleFor(vehiculo => vehiculo.Anio)
               .Matches("^[0-9]{4}$")
                    .WithMessage("El año de matriculación no es correcto.");

            RuleFor(vehiculo => vehiculo.Capacidad)
              .GreaterThan(0)
                .WithMessage("La capacidad del vehículo no es correcta.");

            RuleFor(vehiculo => vehiculo.CostoDia)
              .GreaterThan(0)
                .WithMessage("El costo diario del vehículo no es correcto.")
              .Must(SerUnCostoValido)
                .WithMessage("El costo diario del vehículo no es correcto.");

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

                if (cantidadDigitos > 3)
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
