using System.Collections.Generic;

namespace Company.DecomNumber.Api.Response
{
    public class DecomNumberResponse
    {
        public long NumberEntrada { get; set; }
        public List<long> NumberDivisores { get; set; }
        public List<long> NumberPrimo { get; set; }
    }
}
