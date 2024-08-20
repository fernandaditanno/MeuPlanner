using PlannerDataBase.Authentication;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerDataBase.Migrations
{
    public class Configuracao : DbMigrationsConfiguration<BancoDeDadosContext>
    {
        public Configuracao()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }
        protected override void Seed(BancoDeDadosContext context)
        {

        }
    }
}
