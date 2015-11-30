using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<double> numbers = new List<double>();
            for (; ; )
            {
                double number = 0;
                Console.Write("請輸入一個數字：");
                double.TryParse(Console.ReadLine(), out number);
                numbers.Add(number);
                Console.Write("再繼續輸入嗎？ 繼續請輸入y/結束請輸入n");
                if (Console.ReadLine() == "n")
                    break;
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