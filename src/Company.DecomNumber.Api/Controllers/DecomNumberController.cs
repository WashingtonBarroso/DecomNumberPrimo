using Company.DecomNumber.Api.Response;
using Company.DecomNumber.Api.Service;
using Company.DecomNumber.Api.ViewModel;
using Company.DecomNumber.Lib.Validator;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Company.DecomNumber.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class DecomNumberController : ControllerBase
    {

        private readonly ICalculeService _calculeService;

        public DecomNumberController(ICalculeService calculeService)
        {
            _calculeService = calculeService;
        }

        /// <summary>
        /// Calcula os divisores de um número e os seu números primos 
        /// </summary>
        /// <param name="decomNumberViewModel">viewModel contentendo o parametro de entera NumeroEntrada</param>
        /// <response code="200">Objeto de retorno contendo NumberEntrada,NumberDivisores, NumberPrimo</response>
        /// <response code="400">Erro de validação de dados</response>
        /// <response code="500">Falha no servidor da API.</response>
        [HttpGet]
        [ProducesResponseType(typeof(DecomNumberResponse), 200)]
        [ProducesResponseType(typeof(ValidationFailure), 400)]
        [ProducesResponseType(typeof(ProblemDetails), 500)]
        public ActionResult<DecomNumberResponse> CalculateDivisorsAndPrime([FromQuery] DecomNumberViewModel decomNumberViewModel)
        {
            if (decomNumberViewModel == null)
            {
                return NotFound();
            }

            DecomNumberValidator validatorNumber = new DecomNumberValidator();
            var validator = validatorNumber.Validate(new Company.DecomNumber.Lib.Service.DecomNumber() { NumberEntry = decomNumberViewModel.NumberEntry});

            if(!validator.IsValid)
            {
                return BadRequest(validator.Errors);
            }

            var response = _calculeService.CalculateDivisors(new DecomNumberViewModel() { NumberEntry = decomNumberViewModel.NumberEntry });

            return Ok(response);
        }
    }
}
