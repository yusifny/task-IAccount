using System;
namespace IAccount.Models
{
    internal class Student
    {
        private static int count;
        public int Id { get; set; }
        public string Fullname { get; set; }
        public double Point { get; set; }

        public Student(string fullname, double point)
        {
            Id = ++count;
            Fullname = fullname;
            Point = point;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"Id: {Id} \nFullname: {Fullname} \nPoint: {Point}");
        }
    }
}