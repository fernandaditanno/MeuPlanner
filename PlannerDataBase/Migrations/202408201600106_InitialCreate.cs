namespace PlannerDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colaborador",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContatoColaboradorId = c.Int(nullable: false),
                        ContatoClienteId = c.Int(nullable: false),
                        UsuarioCadastro = c.String(maxLength: 100),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contato", t => t.ContatoClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Contato", t => t.ContatoColaboradorId, cascadeDelete: true)
                .Index(t => t.ContatoColaboradorId)
                .Index(t => t.ContatoClienteId);
            
            CreateTable(
                "dbo.Contato",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Sobrenome = c.String(maxLength: 250),
                        Email = c.String(maxLength: 250),
                        Telefone = c.String(maxLength: 50),
                        Cpf = c.String(maxLength: 50),
                        Endereco = c.String(maxLength: 300),
                        DataNascimento = c.DateTime(nullable: false),
                        Descricao = c.String(maxLength: 1000),
                        UsuarioCadastro = c.String(maxLength: 100),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Evento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Horario = c.String(maxLength: 2147483647),
                        ContatoClienteId = c.Int(nullable: false),
                        DescricaoEvento = c.String(maxLength: 1000),
                        UsuarioCadastro = c.String(maxLength: 100),
                        DataCadastro = c.DateTime(nullable: false),
                        PermissaoVisualizacao_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contato", t => t.ContatoClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Permissao", t => t.PermissaoVisualizacao_Id)
                .Index(t => t.ContatoClienteId)
                .Index(t => t.PermissaoVisualizacao_Id);
            
            CreateTable(
                "dbo.Permissao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeDaTela = c.String(maxLength: 100),
                        Privado = c.Boolean(nullable: false),
                        Senha = c.String(maxLength: 100),
                        UsuarioCadastro = c.String(maxLength: 100),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Nota",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(maxLength: 250),
                        Descricao = c.String(maxLength: 1000),
                        PalavraChave = c.String(maxLength: 250),
                        Fixar = c.Boolean(nullable: false),
                        ContatoClienteId = c.Int(nullable: false),
                        UsuarioCadastro = c.String(maxLength: 100),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contato", t => t.ContatoClienteId, cascadeDelete: true)
                .Index(t => t.ContatoClienteId);
            
            CreateTable(
                "dbo.Processo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContatoClienteId = c.Int(nullable: false),
                        NumeroProcesso = c.String(maxLength: 80),
                        Descricao = c.String(maxLength: 1000),
                        Tipo = c.String(maxLength: 50),
                        UsuarioCadastro = c.String(maxLength: 100),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contato", t => t.ContatoClienteId, cascadeDelete: true)
                .Index(t => t.ContatoClienteId);
            
            CreateTable(
                "dbo.Tarefa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        data = c.DateTime(nullable: false),
                        Feito = c.Boolean(nullable: false),
                        Descricao = c.String(maxLength: 1000),
                        UsuarioCadastro = c.String(maxLength: 100),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Sobrenome = c.String(maxLength: 250),
                        Email = c.String(maxLength: 250),
                        Telefone = c.String(maxLength: 50),
                        Cpf = c.String(maxLength: 50),
                        Login = c.String(maxLength: 50),
                        Senha = c.String(maxLength: 50),
                        UsuarioCadastro = c.String(maxLength: 100),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Processo", "ContatoClienteId", "dbo.Contato");
            DropForeignKey("dbo.Nota", "ContatoClienteId", "dbo.Contato");
            DropForeignKey("dbo.Evento", "PermissaoVisualizacao_Id", "dbo.Permissao");
            DropForeignKey("dbo.Evento", "ContatoClienteId", "dbo.Contato");
            DropForeignKey("dbo.Colaborador", "ContatoColaboradorId", "dbo.Contato");
            DropForeignKey("dbo.Colaborador", "ContatoClienteId", "dbo.Contato");
            DropIndex("dbo.Processo", new[] { "ContatoClienteId" });
            DropIndex("dbo.Nota", new[] { "ContatoClienteId" });
            DropIndex("dbo.Evento", new[] { "PermissaoVisualizacao_Id" });
            DropIndex("dbo.Evento", new[] { "ContatoClienteId" });
            DropIndex("dbo.Colaborador", new[] { "ContatoClienteId" });
            DropIndex("dbo.Colaborador", new[] { "ContatoColaboradorId" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Tarefa");
            DropTable("dbo.Processo");
            DropTable("dbo.Nota");
            DropTable("dbo.Permissao");
            DropTable("dbo.Evento");
            DropTable("dbo.Contato");
            DropTable("dbo.Colaborador");
        }
    }
}
