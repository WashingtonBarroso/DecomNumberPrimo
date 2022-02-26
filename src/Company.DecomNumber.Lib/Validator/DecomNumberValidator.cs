using FluentValidation;
using Company.DecomNumber.Lib.Service;

namespace Company.DecomNumber.Lib.Validator
{
    /// <summary>
    /// Valida os dados de entrada da DecomNumber
    /// </summary>
    public class DecomNumberValidator : AbstractValidator<Company.DecomNumber.Lib.Service.DecomNumber>
    {
        public DecomNumberValidator()
        {
            RuleFor(x => x.NumberEntrada).NotEmpty().WithMessage("O campo é obrigatório");
            RuleFor(x => x.NumberEntrada).InclusiveBetween(1, long.MaxValue).WithMessage("O valor tem que estar entre " + 1 + " e " + long.MaxValue);
        }
    }
}
