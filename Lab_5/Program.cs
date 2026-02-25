using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> trainees = new List<User>();
            List<User> speakers = new List<User>();

            string choice;

            do
            {
                Console.WriteLine("\n===== Training Registration System =====");
                Console.WriteLine("1 = Student");
                Console.WriteLine("2 = Teacher");
                Console.WriteLine("3 = Guest");
                Console.Write("Select Type: ");
                string type = Console.ReadLine();

                Console.Write("Firstname: ");
                string fname = Console.ReadLine();

                Console.Write("Lastname: ");
                string lname = Console.ReadLine();

                Console.Write("Phone: ");
                string phone = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                if (type == "1")
                {
                    Student s = new Student();
                    s.RegisterUser(fname, lname, phone, email);

                    Console.Write("Student ID: ");
                    string id = Console.ReadLine();

                    Console.Write("Major: ");
                    string major = Console.ReadLine();

                    s.SetStudentData(id, major);
                    s.RegisterCourse();
                    trainees.Add(s);
                }
                else if (type == "2")
                {
                    Teacher t = new Teacher();
                    t.RegisterUser(fname, lname, phone, email);

                    Console.Write("Major: ");
                    string major = Console.ReadLine();

                    Console.Write("Academic Position (อาจารย์/ผศ./รศ./ศ): ");
                    string pos = Console.ReadLine();

                    t.SetTeacherData(major, pos);
                    t.RegisterCourse();

                    trainees.Add(t);

                    Console.Write("Is this teacher a speaker? (yes/no): ");
                    string isSpeaker = Console.ReadLine();
                    if (isSpeaker.ToLower() == "yes")
                    {
                        speakers.Add(t);
                    }
                }
                else if (type == "3")
                {
                    Guest g = new Guest();
                    g.RegisterUser(fname, lname, phone, email);

                    Console.Write("Workplace: ");
                    string wp = Console.ReadLine();

                    Console.Write("Position: ");
                    string pos = Console.ReadLine();

                    g.SetGeneralData(wp, pos);
                    g.RegisterCourse();
                    trainees.Add(g);

                    Console.Write("Is this person a speaker? (yes/no): ");
                    string isSpeaker = Console.ReadLine();
                    if (isSpeaker.ToLower() == "yes")
                    {
                        speakers.Add(g);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Type!");
                }

                Console.Write("\nAdd more? (yes/no): ");
                choice = Console.ReadLine();

            } while (choice.ToLower() == "yes");

            // แสดงรายชื่อผู้เข้าอบรม
            Console.WriteLine("\n===== List of Trainees =====");
            foreach (User u in trainees)
            {
                u.ShowInfo();
                Console.WriteLine("-------------------------");
            }

            // แสดงรายชื่อวิทยากร
            Console.WriteLine("\n===== List of Speakers =====");
            foreach (User s in speakers)
            {
                s.ShowInfo();
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}