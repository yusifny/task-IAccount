using System;
namespace IAccount.Models
{
    internal class Group
    {
        private string _groupNo;
        private int _studentLimit;
        public string GroupNo
        {
            get { return _groupNo; }
            set
            {
                if (CheckerGroupNo(value))
                {
                    _groupNo = value;
                    return;
                }
                Console.WriteLine("Exam: AP103");
            }
        }
        public int StudentLimit
        {
            get { return _studentLimit; }
            set
            {
                if (value >= 5 && value <= 18)
                {
                    _studentLimit = value;
                    return;
                }
                Console.WriteLine("Min: 5  Max: 18");
                return;
            }
        }
        private Student[] Students = new Student[0];
        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
        }
        public bool CheckerGroupNo(string groupNo)
        {
            for (int i = 0; i < groupNo.Length; i++)
            {
                if (groupNo.Length == 5 && Char.IsUpper(groupNo[0]) && Char.IsUpper(groupNo[1]) && Char.IsDigit(groupNo[2]) && Char.IsDigit(groupNo[3]) && Char.IsDigit(groupNo[4]))
                {
                    _groupNo = groupNo;
                    return true;
                }
            }
            return false;
        }

        public void AddStudent(Student stu1)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = stu1;
        }

        public void GetStudent(int? Id)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == Id)
                {
                    Console.WriteLine($"Fullname:{Students[i].Fullname} point: {Students[i].Point}");
                }
            }
        }
        public void GetAllStudents()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"Id: {Students[i].Id} \nFullname:{Students[i].Fullname} \nPoint: {Students[i].Point}");

            }
        }
    }
}