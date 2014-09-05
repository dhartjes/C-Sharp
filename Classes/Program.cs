using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Employee
    {
        public Employee(){}

        public Employee(string name, int age)
        {
            // TODO: Complete member initialization
            this.Name = name;
            this.Age = age;
        }
        //private int age;
        //public int Age
        //{
        //    get { return age; }
        //    set { age = value; }
        //}

        //The following is short hand for the above commented out code.
        public int Age { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee Dhartjes = new Employee();
            Dhartjes.Age = 32;
            Dhartjes.Name = "Dominic";
            Console.WriteLine("{0}'s age is {1}", Dhartjes.Name, Dhartjes.Age);

            Employee Bashful = new Employee("Bethany", 35);
            Console.WriteLine("{0}'s age is {1}", Bashful.Name, Bashful.Age);


        }
    }
}
