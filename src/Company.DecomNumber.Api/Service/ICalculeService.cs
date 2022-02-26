using Company.DecomNumber.Api.Response;
using Company.DecomNumber.Api.ViewModel;

namespace Company.DecomNumber.Api.Service
{
    public interface ICalculeService
    {
        public DecomNumberResponse CalculeDivisor(DecomNumberViewModel entrada);

    }
}
