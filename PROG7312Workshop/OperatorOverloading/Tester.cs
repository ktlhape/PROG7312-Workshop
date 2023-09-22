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

            Point p1 = new Point(15, 4);
            Point p2 = new Point(6, 10);

            Point p3 = p1 + p2; //11,14
            Point p4 = p3 + 5;

            bool results = p2 > p1;

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine("===================");
            Console.WriteLine(p3);
            Console.WriteLine("=====================");
            Console.WriteLine(p4);
            Console.WriteLine(results);


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
