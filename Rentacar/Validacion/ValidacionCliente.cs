using FluentValidation;
using Rentacar.Modelos;

namespace Rentacar.Validacion
{
    public class ValidacionCliente : AbstractValidator<Cliente>
    {
        public ValidacionCliente()
        {
            RuleFor(cliente => cliente.Dni)
                .Matches("^[0-9]{8}[A-Za-z]{1}$")
                    .WithMessage("El dni es incorrecto.");

            RuleFor(cliente => cliente.Nombre)
                .NotNull()
                    .WithMessage("El cliente debe tener un nombre.")
                .NotEmpty()
                    .WithMessage("El cliente debe tener un nombre.")
                .Length(1,255)
                    .WithMessage("El nombre del cliente no puede " +
                        "contener más de 255 caracteres.")
                .Matches("^[a-zA-Z 'ïüöéáíúó]*$")
                    .WithMessage("El nombre no es correcto.");

            RuleFor(cliente => cliente.Domilicio)
               .NotNull()
                   .WithMessage("El cliente debe tener un domicilio.")
               .NotEmpty()
                   .WithMessage("El cliente debe tener un domicilio.")
               .Length(1, 255)
                   .WithMessage("El domicilio del cliente no puede " +
                       "contener más de 255 caracteres.");

            RuleFor(cliente => cliente.Telefono)
               .NotNull()
                   .WithMessage("El cliente debe tener un número de teléfono.")
               .NotEmpty()
                   .WithMessage("El cliente debe tener un número de teléfono.")
               .Length(9, 20)
                   .WithMessage("El número de teléfono del cliente debe " +
                       "ser de entre 9 y 20 cifras.")
               .Matches("^[0-9]*$")
                   .WithMessage("El número de teléfono no es correcto.");
        }
    }
}
