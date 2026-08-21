using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Prac1
{
    class Student
    {
        public int Aid;
        private string Name;
        protected string Course;
        internal int Fee;
        protected internal int Sem;

        public Student(int aid, string name, string course, int fee, int sem)
        {
            Aid = aid;
            Name = name;
            Course = course;
            Fee = fee;
            Sem = sem;
        }
        public void Display()
        {
            Console.WriteLine("\n===== STUDENT DETAILS =====");
            Console.WriteLine("Admission ID : " + Aid);
            Console.WriteLine("Course       : " + Course);
            Console.WriteLine("Fee          : " + Fee);
            Console.WriteLine("Semester     : " + Sem);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Admission ID: ");
            int aid = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Course: ");
            string course = Console.ReadLine();

            Console.Write("Enter Fee: ");
            int fee = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Semester: ");
            int sem = Convert.ToInt32(Console.ReadLine());

            Student obj = new Student(aid, name, course, fee, sem);

            obj.Display();

            Console.ReadKey();
        }
    }
}