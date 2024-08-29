using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerDataBase.Authentication
{
    public class SQLiteProviderInvariantName : IProviderInvariantName
    {
        public static readonly SQLiteProviderInvariantName Instance = new SQLiteProviderInvariantName();
        private SQLiteProviderInvariantName() { }
        public const string ProviderName = "System.Data.SQLite.EF6";
        public string Name { get { return ProviderName; } }
    }
}
