using PlannerDataBase.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerDataBase.Authentication
{
    public class BancoDeDadosContext: DbContext
    {
        public BancoDeDadosContext(): base("SQLiteDB")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BancoDeDadosContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Processo> Processos { get; set; }
        public DbSet<Permissao> Pemissoes { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }

    }
}
