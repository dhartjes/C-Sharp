using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostMigrateProject1
{
    public class PostProgram : IDisposable
    {
        static void Main(string[] args)
        { }

        public int updateDatabase(string queryString)
        {
            int status;

            using (Entities2 _db = new Entities2())
            {
                var entity = _db.New_ChangeOrder.FirstOrDefault(x => x.ID == 2024);
                entity.RequestedWork = queryString;
                status = _db.SaveChanges();
            }
            return status;
        }

    }
}
