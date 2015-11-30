using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public class Condition
    {
        public double UpperBound { get; set; }

        public bool IsLessThanUpperBound(List<double> numbers)
        {
            double total = 0.0;
            for (int index = 0; index < numbers.Count; index++)
                total += numbers[index];
            return total < this.UpperBound;
        }
    }
}