using PostMigrateProject1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PreMigrateProject1
{
    class Program
    {
        static int Main(string[] args)
        {
            string longAssString;

            using (Entities1 _db = new Entities1())
            {
                longAssString = _db.ChangeOrders
                    .Where(x => x.ID == 348)
                    .Select(x => x.RequestedWork)
                    .FirstOrDefault();
            }

            int status;

            using (PostProgram pp = new PostProgram()){
               status = pp.updateDatabase(longAssString);
            }
            Console.WriteLine(status);
            return status;
        }
    }
}
