using PlannerDataBase.Authentication;
using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;

namespace PlannerDataBase.Migrations
{
    public class Configuracao : DbMigrationsConfiguration<BancoDeDadosContext>
    {
        public Configuracao()
        {
            AutomaticMigrationsEnabled = true;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }
        protected override void Seed(BancoDeDadosContext context)
        {

        }
    }
}
