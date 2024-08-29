using PlannerDataBase.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PlannerDataBase.Authentication
{
    public class BancoDeDadosContext : DbContext
    {
        public BancoDeDadosContext() : base("SQLiteDB")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BancoDeDadosContext>());
            Database.CreateIfNotExists();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            this.ConfiguracoesData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
        private void ConfiguracoesData(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Usuario>().HasKey(e => e.Id).Property(e => e.Nome).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Usuario>().Property(u => u.Sobrenome).HasMaxLength(250);
            modelBuilder.Entity<Usuario>().Property(u => u.Email).HasMaxLength(250);
            modelBuilder.Entity<Usuario>().Property(u => u.Telefone).HasMaxLength(50);
            modelBuilder.Entity<Usuario>().Property(u => u.Cpf).HasMaxLength(50);
            modelBuilder.Entity<Usuario>().Property(u => u.Login).HasMaxLength(50);
            modelBuilder.Entity<Usuario>().Property(u => u.Senha).HasMaxLength(50);
            modelBuilder.Entity<Usuario>().Property(u => u.UsuarioCadastro).HasMaxLength(100);
            modelBuilder.Entity<Usuario>().Property(u => u.DataCadastro).HasColumnType("datetime");

            modelBuilder.Entity<Tarefa>().ToTable("Tarefa");
            modelBuilder.Entity<Tarefa>().HasKey(e => e.Id).Property(e => e.Descricao).IsRequired().HasMaxLength(1000);
            modelBuilder.Entity<Tarefa>().Property(e => e.Data).HasColumnType("datetime");
            modelBuilder.Entity<Tarefa>().Property(e => e.Feito);
            modelBuilder.Entity<Tarefa>().Property(u => u.UsuarioCadastro).HasMaxLength(100);
            modelBuilder.Entity<Tarefa>().Property(u => u.DataCadastro).HasColumnType("datetime");

            modelBuilder.Entity<Processo>().ToTable("Processo");
            modelBuilder.Entity<Processo>().HasKey(e => e.Id).Property(e => e.NumeroProcesso).IsRequired().HasMaxLength(80);
            modelBuilder.Entity<Processo>().Property(e => e.Descricao).HasMaxLength(1000).HasColumnType("nvarchar");
            modelBuilder.Entity<Processo>().Property(u => u.UsuarioCadastro).HasMaxLength(100);
            modelBuilder.Entity<Processo>().Property(u => u.DataCadastro).HasColumnType("datetime");
            modelBuilder.Entity<Processo>().Property(u => u.Tipo).HasMaxLength(50);

            modelBuilder.Entity<Permissao>().ToTable("Permissao");
            modelBuilder.Entity<Permissao>().HasKey(e => e.Id).Property(e => e.NomeDaTela).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Permissao>().Property(u => u.UsuarioCadastro).HasMaxLength(100);
            modelBuilder.Entity<Permissao>().Property(u => u.Senha).HasMaxLength(50);
            modelBuilder.Entity<Permissao>().Property(u => u.Privado);
            modelBuilder.Entity<Permissao>().Property(u => u.DataCadastro).HasColumnType("datetime");

            modelBuilder.Entity<Nota>().ToTable("Nota");
            modelBuilder.Entity<Nota>().HasKey(e => e.Id).Property(e => e.Titulo).IsRequired().HasMaxLength(250);
            modelBuilder.Entity<Nota>().Property(u => u.UsuarioCadastro).HasMaxLength(100);
            modelBuilder.Entity<Nota>().Property(u => u.DataCadastro).HasColumnType("datetime");
            modelBuilder.Entity<Nota>().Property(u => u.Descricao).HasMaxLength(1000).HasColumnType("nvarchar");
            modelBuilder.Entity<Nota>().Property(u => u.PalavraChave).HasMaxLength(250);

            modelBuilder.Entity<Evento>().ToTable("Evento");
            modelBuilder.Entity<Evento>().HasKey(e => e.Id).Property(e => e.DescricaoEvento).IsRequired().HasMaxLength(1000);
            modelBuilder.Entity<Evento>().Property(u => u.UsuarioCadastro).HasMaxLength(100);
            modelBuilder.Entity<Evento>().Property(u => u.DataCadastro).HasColumnType("datetime");
            modelBuilder.Entity<Evento>().Property(u => u.Horario).HasMaxLength(100);

            modelBuilder.Entity<Contato>().ToTable("Contato");
            modelBuilder.Entity<Contato>().HasKey(e => e.Id).Property(e => e.Nome).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Contato>().Property(u => u.UsuarioCadastro).HasMaxLength(100);
            modelBuilder.Entity<Contato>().Property(u => u.DataCadastro).HasColumnType("datetime");
            modelBuilder.Entity<Contato>().Property(c => c.Sobrenome).HasMaxLength(250);
            modelBuilder.Entity<Contato>().Property(c => c.Email).HasMaxLength(250);
            modelBuilder.Entity<Contato>().Property(c => c.Telefone).HasMaxLength(50);
            modelBuilder.Entity<Contato>().Property(c => c.Cpf).HasMaxLength(50);
            modelBuilder.Entity<Contato>().Property(c => c.Endereco).HasMaxLength(300).HasColumnType("nvarchar");
            modelBuilder.Entity<Contato>().Property(c => c.DataNascimento).HasColumnType("datetime");
            modelBuilder.Entity<Contato>().Property(c => c.Descricao).HasMaxLength(1000).HasColumnType("nvarchar");

            modelBuilder.Entity<Colaborador>().ToTable("Colaborador");
            modelBuilder.Entity<Colaborador>().HasKey(e => e.Id).Property(e => e.ContatoColaboradorId).IsRequired();
            modelBuilder.Entity<Colaborador>().Property(u => u.UsuarioCadastro).HasMaxLength(100);
            modelBuilder.Entity<Colaborador>().Property(u => u.DataCadastro).HasColumnType("datetime");

            // Configurar relacionamentos
            modelBuilder.Entity<Colaborador>().HasRequired(c => c.ContatoColaborador).WithMany()
                .HasForeignKey(c => c.ContatoColaboradorId).WillCascadeOnDelete(false);

            modelBuilder.Entity<Colaborador>().HasRequired(c => c.ContatoCliente)
                        .WithMany().HasForeignKey(c => c.ContatoClienteId).WillCascadeOnDelete(false);

            modelBuilder.Entity<Evento>().HasRequired(c => c.ContatoCliente)
                        .WithMany().HasForeignKey(c => c.ContatoClienteId)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<Evento>().HasRequired(c => c.PermissaoVisualizacao)
                        .WithMany().HasForeignKey(c => c.PermissaoVisualizacaoId)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<Processo>().HasRequired(c => c.ContatoCliente)
                        .WithMany().HasForeignKey(c => c.ContatoClienteId)
                        .WillCascadeOnDelete(false);

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Processo> Processos { get; set; }
        public DbSet<Permissao> Permissoes { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }

    }
}
