using System.Collections.Generic;

namespace Company.DecomNumber.Lib.Service
{
    public class DecomNumber
    {
        public long NumberEntry { get; set; }
        public List<long> NumbersDivisors { get; set; }
        public List<long> NumbersPrime { get; set; }
    }
}
