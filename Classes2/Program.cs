using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Employee
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime StartingDate { get; set; }
        public string PhoneNumber { get; set; }

        public void Bonus(double bonusPercent)
        {
            Salary += Salary * bonusPercent;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee Dhartjes = new Employee()
            {
                Age = 32,
                Name = "Dominic Hartjes",
                Salary = 50000.00,
                StartingDate = new DateTime(2014,9,2),
                PhoneNumber = "607-342-8552"
            };

            Console.WriteLine("{0}'s age is {1}, he started on {2}, and he makes ${3}", 
                Dhartjes.Name, Dhartjes.Age, Dhartjes.StartingDate, Dhartjes.Salary);
            Dhartjes.Bonus(0.05);
            Console.WriteLine("{0}'s age is {1}, he started on {2}, and he makes ${3}",
                Dhartjes.Name, Dhartjes.Age, Dhartjes.StartingDate, Dhartjes.Salary);

        }
    }
}