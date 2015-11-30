using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Home
    {
        public List<int> answer = new List<int>();

        private Random random = new Random();

        public string GetResult(List<int> userAnswer)
        {
            int aCount = 0;
            int bCount = 0;
            string result = "";
            for (int userAnswerIndex = 0; userAnswerIndex < 4; userAnswerIndex++)
            {
                for (int answerIndex = 0; answerIndex < 4; answerIndex++)
                {
                    if (userAnswer[userAnswerIndex] == this.answer[answerIndex])
                    {
                        if (userAnswerIndex == answerIndex)
                            aCount++;
                        else
                            bCount++;
                    }
                }
            }
            //result += "Game Answer:" + this.ConvertNumbersToString(this.answer) + "\n";
            result += this.ConvertNumbersToString(userAnswer);
            return result + " → " + string.Format("{0}A{1}B", aCount, bCount) + "\n";
        }

        public List<int> CreateNumbers()
        {
            List<int> numbers = new List<int>();

            do
            {
                int number = random.Next(1, 10);
                if (!this.IsInAnswer(number, numbers))
                    numbers.Add(number);
            } while (numbers.Count < 4);
            return numbers;
        }

        private bool IsInAnswer(int number, List<int> numbers)
        {
            for (int index = 0; index < numbers.Count; index++)
            {
                if (number == numbers[index])
                {
                    return true;
                }
            }
            return false;
        }

        public string ConvertNumbersToString(List<int> numbers)
        {
            string result = "";
            for (int index = 0; index < numbers.Count; index++)
                result += numbers[index].ToString();

            return result;
        }

        public string GetResultAuto(List<int> pcAnswer)
        {
            int aCount = 0;
            int bCount = 0;
            string result = "";

            do
            {
                for (int pcAnswerIndex = 0; pcAnswerIndex < 4; pcAnswerIndex++)
                {
                    for (int answerIndex = 0; answerIndex < 4; answerIndex++)
                    {
                        if (pcAnswer[pcAnswerIndex] == this.answer[answerIndex])
                        {
                            if (pcAnswerIndex == answerIndex)
                                aCount++;
                            else
                                bCount++;
                        }
                    }
                }
                //result += "Game Answer:" + this.ConvertNumbersToString(this.answer) + "\n";
                result += this.ConvertNumbersToString(pcAnswer);
                return result + " → " + string.Format("{0}A{1}B", aCount, bCount) + "\n";
            } while (aCount == 4);
        }

        public List<int> PcCreateNumbers()
        {
            List<int> numbers = new List<int>();

            do
            {
                int number = random.Next(1, 10);
                if (!this.IsInAnswer(number, numbers))
                    numbers.Add(number);
            } while (numbers.Count < 4);
            return numbers;
        }
    }
}