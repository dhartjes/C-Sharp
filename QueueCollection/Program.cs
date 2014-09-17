using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Same exact functionality can be done with Stack. 
            //Rename Queue to Stack using replace all. 
            //Dequeue should change to .Pop
            var myQueue = new Queue<int>();
            myQueue.Enqueue(100);
            int val = myQueue.Dequeue();
            Console.WriteLine("val: {0}", val);

            for (int i = 0; i < 50; i++)
            {
                myQueue.Enqueue(i);
            }

            foreach (int i in myQueue)
            {
                Console.Write(i + ", ");
            }

            var whichValue = myQueue.Dequeue();
            Console.WriteLine(whichValue);

            var secondValue = myQueue.Dequeue();
            Console.WriteLine(secondValue);
        }
    }
}
