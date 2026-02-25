using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class StarterMember : User, Member
    {
        protected string role; 

        public void SetRole(string role)
        {
            this.role = role;
        }

        public void RegisterCourse()
        {
            Console.WriteLine($"{role} registered for training successfully.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Role: {role}");
        }
    }
}
