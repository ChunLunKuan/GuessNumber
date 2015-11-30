using GameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Game game = new Game();
            game.answer = game.CreateNumbers();
            List<int> userAnswer = new List<int>();
            do
            {
                for (int index = 0; index < 4; index++)
                {
                    Console.Write("請輸入第{0}個數字：", index + 1);
                    userAnswer.Add(int.Parse(Console.ReadLine()));
                }

                Console.WriteLine(game.GetResult(userAnswer));
            } while (game.GetResult(userAnswer) == "4A0B");
        }
    }
}