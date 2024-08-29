using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerDataBase.Authentication
{
    public class SQLiteDbConfiguration : DbConfiguration
    {
        public SQLiteDbConfiguration()
        {
            AddDependencyResolver(new SQLiteDbDependencyResolver());
        }
    }
}
