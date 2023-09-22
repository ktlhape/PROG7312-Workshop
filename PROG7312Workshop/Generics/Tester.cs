using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312Workshop.Generics
{
    public class Tester
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {
            4,74,3,5,14,45,8,21
            };

            List<string> names = new List<string>() {
            "David","Smith","Roger","Federer","Michael","Jordan",
            "Mika","Federer","Jessica","Jones",
            "Caroline","Smith","Mike","Ross"
            };
            //Console.WriteLine(AreEqual<int>(4,4));
            //Console.WriteLine(AreEqual("x","u"));
            //Console.WriteLine(AreEqual(4.9,5));
            //Console.WriteLine(GetLength<string,int>("Smith",5));
            //Console.Read();
            Display(numbers);
            BubbleSort(numbers);
      
            Console.WriteLine("=====After Sort=====");
            Display(numbers);

            BubbleSort(names);
            Console.WriteLine("=====Names=====");
            Display(names);

        }
        static bool AreEqual<T>(T x, T y)
        {
            return x.Equals(y);
        }

        static bool GetLength<T1,T2>(T1 name, T2 l)
        {
            return name.ToString().Length.Equals(l);
        }
        private static void BubbleSort<T>(List<T> ls)
        {
            for (int i = 0; i < ls.Count - 1; i++)
            {
                for (int j = (i + 1); j < ls.Count; j++)
                {
                    if (Comparer<T>.Default.Compare(ls[i], ls[j]) == 1)
                    {
                        T temp = ls[i];
                        ls[i] = ls[j];
                        ls[j] = temp;
                    }
                }
            }
            Console.WriteLine("====================");
        }

        private static void Display(List<int> ls)
        {
            foreach (int n in ls)
            {
                Console.WriteLine(n);
            }
        }
        private static void Display(List<string> ls)
        {
            foreach (string n in ls)
            {
                Console.WriteLine(n);
            }
        }

    }
}
