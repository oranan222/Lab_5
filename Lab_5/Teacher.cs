using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Teacher : User, Member, Speaker
    {
        private string major;
        private string academicPosition; 

        public void SetTeacherData(string major, string position)
        {
            this.major = major;
            this.academicPosition = position;
        }

        public void RegisterCourse()
        {
            Console.WriteLine("Teacher registered for training.");
        }

        public void Teach()
        {
            Console.WriteLine("Teaching the training course.");
        }

        public void Approve()
        {
            Console.WriteLine("Approved training results.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Major: {major}");
            Console.WriteLine($"Position: {academicPosition}");
        }
    }
}