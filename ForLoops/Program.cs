using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2001; i++)
            {
                if (i % 100 == 0)
                {
                    Console.WriteLine("Happy Birthday! You are {0}", i);
                }
            }
            
            
            //Console.Write("How old are you? ");
            //int age = int.Parse(Console.ReadLine());

            //for ( ; ; )
            //{
                
            //    --age;

            //    if (age == 5)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine("Happy Birthday! You are {0} years old!", age);

            //    if (age <= 0)
            //    {
            //        break;                   
            //    }
            //}

            //Console.WriteLine("\nTaDa!!");
            

            //age = 35;
            //int newAge = ++age;
            //Console.WriteLine("age: {0}, newAge: {1}", age, newAge);

            //newAge = age++;
            //Console.WriteLine("age: {0}, newAge: {1}", age, newAge);

        }
    }
}
