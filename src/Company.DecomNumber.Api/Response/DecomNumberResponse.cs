using System.Collections.Generic;

namespace Company.DecomNumber.Api.Response
{
    public class DecomNumberResponse
    {
        public long NumberEntry { get; set; }
        public List<long> NumberDivisors { get; set; }
        public List<long> NumberPrime { get; set; }
    }
}
