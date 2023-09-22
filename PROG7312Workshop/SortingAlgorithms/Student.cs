using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312Workshop.SortingAlgorithms
{
    public class Student : IComparable<Student>
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

        public override string? ToString()
        {
            return $"[{StudentId}] {Firstname} {Lastname} - {Age}";
        }

        public int CompareTo(Student? otherSt)
        {
            int results = this.Lastname.CompareTo(otherSt.Lastname);
            if (results == 0)
            {
                results = this.Firstname.CompareTo(otherSt.Firstname);
            }
            return results;
        }
    }

    public class CallNumber
    {
        public float Topic { get; set; }
        public string Surname { get; set; }
    }
}
