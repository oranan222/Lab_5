using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Guest : User, Member
    {
        private string workplace;
        private string position;

        public void SetGeneralData(string workplace, string position)
        {
            this.workplace = workplace;
            this.position = position;
        }

        public void RegisterCourse()
        {
            Console.WriteLine("Guest registered for training.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Workplace: {workplace}");
            Console.WriteLine($"Position: {position}");
        }
    }
}