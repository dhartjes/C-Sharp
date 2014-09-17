using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSFSDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDoc = new Document();
            myDoc.Print();
            myDoc.CountCharacters();
            var status = myDoc.Status;
            Console.WriteLine(status);

            //You cannot instantiate an Interface.
            //Printable mySecondDoc = new Printable();

            //You can however instantiate an interface if you initialize it from an object that implements the interface.
            Printable printableItem = myDoc;
            //Then you can call methods included in the interface on this object, but not methods associated with Document.
            printableItem.Print();

            //This fails on the other hand.
            //printableItem.CountCharacters();

            //Why do we implement an interface? Perhaps we got printableItem passed into us as the paramater of a method and we know that it is a document.
            //We can cast!
            Document theDoc = printableItem as Document;
            //When casting, check for null.
            if (theDoc != null)
                theDoc.CountCharacters();

            string contents = theDoc.Read();
            Console.WriteLine("contents: " + contents);
            theDoc.Write();

        }
    }
}
