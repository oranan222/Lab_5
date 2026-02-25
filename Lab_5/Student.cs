using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Student : User, Member
    {
        private string studentId;
        private string major;

        public void SetStudentData(string id, string major)
        {
            this.studentId = id;
            this.major = major;
        }

        public void RegisterCourse()
        {
            Console.WriteLine("Student registered for training.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Student ID: {studentId}");
            Console.WriteLine($"Major: {major}");
        }
    }
}