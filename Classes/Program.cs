using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Employee
    {
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee Dhartjes = new Employee();
            Dhartjes.Age = 35;
            Console.WriteLine("Dhartjes's age is {0}", Dhartjes.Age);
        }
    }
}
