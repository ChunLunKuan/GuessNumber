using GameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Game game = new Game();
            game.answer = game.CreateNumbers();
            List<int> userAnswer = game.CreateNumbers();

            Console.WriteLine(game.GetResult(userAnswer));
        }
    }
}