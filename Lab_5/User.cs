using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class User
    {
        protected string firstname;
        protected string lastname;
        protected string phone;
        protected string email;

        public void RegisterUser(string fname, string lname, string phone, string email)
        {
            this.firstname = fname;
            this.lastname = lname;
            this.phone = phone;
            this.email = email;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {firstname} {lastname}");
            Console.WriteLine($"Phone: {phone}");
            Console.WriteLine($"Email: {email}");
        }
    }
}