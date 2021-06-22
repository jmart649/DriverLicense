using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverLicense
{
    class Test
    {
        List<string> TestAnswers = new List<string>() { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };

        List<string> answers = new List<string>();

        public int right = 0;
        public int wrong = 0;

        public void testing()
        {
            Console.WriteLine("Welcome to your local DMV Office where you will be taking a drivers license test");
            Console.WriteLine("You will be taking a multiple-choice (A,B,C,D) 20 questioned test");
            Console.WriteLine("Lets Begin the test");

            for(int i = 0; i < TestAnswers.Count; i++)
            {
                Console.Write("Question {0}: ", i + 1);
                string value = Console.ReadLine();
                answers.Add(value);
                if (value == "A" || value == "B" || value == "C" || value == "D")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Not a valid answer!!!");
                    break;
                }
            }

            Console.Write("\nYou got the following question numbers wrong: ");
            for (int i = 0; i < TestAnswers.Count; i++)
            {
                if (TestAnswers[i] == answers[i])
                {
                    right++;
                }
                else
                {
                    wrong++;
                    Console.Write("{0}, ", i + 1);
                }
            }

            if (right >= 15)
            {
                Console.WriteLine("\nYou Passed the test!!!!!");
            }
            else
            {
                Console.WriteLine("\nYou Failed the test");
            }

            Console.Write("\nTotal right answers: {0}\n", right);
            Console.Write("Total wrong answers: {0}\n", wrong);
        }
    }
        
}
