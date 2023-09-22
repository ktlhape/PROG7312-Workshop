using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312Workshop.ComparingLists
{
    internal class Tester
    {
        static List<string> questions = new();
        static List<string> answers = new();
        static int count = 0;
        static void Main(string[] args)
        {
            List<string> names = new List<string>() {
            "David","Smith","Roger","Federer","Michael","Jordan",
            "Mika","Federer","Jessica","Jones",
            "Caroline","Smith","Mike","Ross"
            };

            DisplayQuestions(names);
            SortQuestions(questions);
            GetAnswers();

            Console.WriteLine("====================");
            Console.WriteLine(IsCorrect(questions,answers));
            Console.WriteLine($"You got {count} answers correct");
        }

        public static bool IsCorrect(List<string> q, List<string> a)
        {
            
            if (q.Count == a.Count)
            {
                for (int i = 0; i < q.Count; i++)
                {
                    if (string.Compare(q[i], a[i]) == 0)
                    {
                        count++;
                    }
                }
            }
            return count == 5;
        }
        private static void GetAnswers()
        {
            Console.WriteLine("Please type your answers below:");
            string? answer = "";
            for (int i = 1; i <= questions.Count; i++)
            {
                Console.Write($"{i}. ");
                answer = Console.ReadLine();
                answers.Add(answer);
            }
        }

        private static void SortQuestions(List<string> ls)
        {
            for (int i = 0; i < ls.Count - 1; i++)
            {
                for (int j = (i + 1); j < ls.Count; j++)
                {
                    if (string.Compare(ls[i], ls[j]) == 1)
                    {
                        string temp = ls[i];
                        ls[i] = ls[j];
                        ls[j] = temp;
                    }
                }
            }
        }

        static void DisplayQuestions(List<string> ls)
        {
            Console.WriteLine("=====Questions=====");
            Random rdn = new Random();

            for (int i = 1; i <= 5; i++)
            {
                string question = ls[rdn.Next(0, ls.Count - 1)];
                string surname = question.Substring(0, 3); //onlt get the 3 letters of the surname
                Console.WriteLine(surname);
                questions.Add(question);
            }

        }
        
    }
}
