using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312Workshop.OperatorOverloading
{
    internal class Tester
    {
        static void Main(string[] args)
        {

            //Point p1 = new Point(15, 4);
            //Point p2 = new Point(6, 10);

            //Point p3 = p1 + p2; //11,14
            //Point p4 = p3 + 5;

            //bool results = p2 > p1;

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //Console.WriteLine("===================");
            //Console.WriteLine(p3);
            //Console.WriteLine("=====================");
            //Console.WriteLine(p4);
            //Console.WriteLine(results);
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
            DisplayStudents(stList);
            BubbleSort(stList);
            DisplayStudents(stList);

        }
        private static void DisplayStudents(List<Student> stList)
        {
            foreach (Student st in stList)
            {
                Console.WriteLine(st);
            }
        }
        private static void BubbleSort(List<Student> stList)
        {
            for (int i = 0; i < stList.Count - 1; i++)
            {
                for (int j = (i + 1); j < stList.Count; j++)
                {
                    if (stList[i] > stList[j])
                    {
                        Student temp = stList[i];
                        stList[i] = stList[j];
                        stList[j] = temp;
                    }
                }
            }
            Console.WriteLine("==========================");
        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public Student(int studentId, string firstname, string lastname, int age)
        {
            StudentId = studentId;
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
        }
        public static bool operator >(Student s1, Student s2)
        {
            int results = string.Compare(s1.Lastname, s2.Lastname);
            if (results == 0)
            {
                results = string.Compare(s1.Firstname, s2.Firstname);
            }
            return results > 0;
        }
        public static bool operator <(Student s1, Student s2)
        {
            int results = string.Compare(s1.Lastname, s2.Lastname);
            if (results == 0)
            {
                results = string.Compare(s1.Firstname, s2.Firstname);
            }
            return results < 0;
        }

        public override string? ToString()
        {
            return $"[{StudentId}] {Firstname} {Lastname} - {Age}";
        }

     
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }
        public static Point operator +(Point p, int i)
        {
            return new Point(p.X + i, p.Y + i);
        }
        public static bool operator >(Point p1, Point p2)
        {
            return (p1.X > p2.X && p1.Y > p2.Y);
        }
        public static bool operator <(Point p1, Point p2)
        {
            return (p1.X < p2.X && p1.Y < p2.Y);
        }

        public static bool operator >=(Point p1, Point p2)
        {
            return (p1.X >= p2.X && p1.Y >= p2.Y);
        }
        public static bool operator <=(Point p1, Point p2)
        {
            return (p1.X <= p2.X && p1.Y <= p2.Y);
        }


        public override string? ToString()
       => $"X: {X}\nY: {Y}";
    }
}
