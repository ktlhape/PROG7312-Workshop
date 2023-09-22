using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312Workshop.SortingAlgorithms
{
    internal class Tester
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {
            4,74,3,5,14,45,8,21
            };

            Random rdn = new Random();

            List<Student> stList = new List<Student>() { 
            new Student(rdn.Next(1000,9999),"David","Smith",23),
            new Student(rdn.Next(1000,9999),"Roger","Federer",22),
            new Student(rdn.Next(1000,9999),"Michael","Jordan",20),
            new Student(rdn.Next(1000,9999),"Mika","Federer",23),
            new Student(rdn.Next(1000,9999),"Jessica","Jones",21),
            new Student(rdn.Next(1000,9999),"Caroline","Smith",19),
            new Student(rdn.Next(1000,9999),"Mike","Ross",20),
            new Student(rdn.Next(1000,9999),"Michael","Smith",19)
            };


            //Display(numbers);
            //BubbleSort(numbers);
            //Display(numbers);
            DisplayStudents(stList);
            BubbleSort(stList);
            DisplayStudents(stList);
        }

        private static void BubbleSort(List<Student> stList)
        {
            for (int i = 0; i < stList.Count - 1; i++)
            {
                for (int j = (i + 1); j < stList.Count; j++)
                {
                    if (stList[i].CompareTo(stList[j]) == 1)
                    {
                        Student temp = stList[i];
                        stList[i] = stList[j];
                        stList[j] = temp;
                    }
                }
            }
            Console.WriteLine("==========================");
        }

        private static void DisplayStudents(List<Student> stList)
        {
            foreach (Student st in stList)
            {
                Console.WriteLine(st);
            }
        }

        /*4,74,3,5,14,45,8,21
         * 3,74,4,5,14,45,8,21
         * 3,4,74,5,14,45,8,21
         * 3,4,5,74,14,45,8,21
         *length = 8*
         * i = 0 (4)
         * j = 1 (74)
         */

        private static void BubbleSort(List<int> ls)
        {
            for (int i = 0; i < ls.Count - 1; i++)
            {
                for (int j  = (i + 1); j < ls.Count; j++)
                {
                    if (ls[i] > ls[j])
                    {
                        int temp = ls[i];
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
    }
}
