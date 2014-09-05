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
        public int MyAge()
        {
            return age;
        }
        public void SetAge(int someAge)
        {
            age = someAge;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee Dhartjes = new Employee();
            Dhartjes.SetAge(32);
            int age = Dhartjes.MyAge();
            Console.WriteLine("Dave's age is {0}", age);
        }
    }
}
