using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example001
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();

            do
            {
                Console.Write("請輸入您猜的數字：");
                if (rnd.Next(1, 4) == int.Parse(Console.ReadLine()))
                    Console.WriteLine("猜中了");
                else
                    Console.WriteLine("猜錯了，答案是：{0}", rnd);
                Console.WriteLine("再玩一次？(y/n)");
            } while (Console.ReadLine() == "y");
        }
    }
}