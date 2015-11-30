using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            List<double> numbers = new List<double>();
            Condition condition =
                new Condition() { UpperBound = 1000 };

            while (condition.IsLessThanUpperBound(numbers))
            {
                numbers.Add(random.Next(1, 101));
            }

            double total = 0.0;
            string result = "";
            for (int index = 0; index < numbers.Count; index++)
            {
                total += numbers[index];
                result +=
                    (
                        (index != numbers.Count - 1) ?
                            string.Format("{0} + ", numbers[index])
                            : string.Format("{0} = {1} ", numbers[index], total)
                    )
                    ;
            }
            Console.WriteLine(result);
        }
    }
}