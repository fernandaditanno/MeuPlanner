using PlannerDataBase.Authentication;
using PlannerDataBase.Negocio;
using PlannerDataBase.Repositories;
using System;

namespace PlannerDataBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inciando Sistema");
            Console.WriteLine("Criando banco de dados");

            try
            {
                using (var context = new BancoDeDadosContext())
                {
                    context.Database.CreateIfNotExists();
                    context.Database.Connection.Open();
                    if (context.Database.Connection.State == System.Data.ConnectionState.Open)
                    {
                        //var teste = new Usuario()
                        //{
                        //    UsuarioCadastro = "SISTEMA",
                        //    DataCadastro = DateTime.Now,
                        //    Nome = "MASTER",
                        //    Sobrenome = "SISTEMA",
                        //    Email = "FERNANDADITANNO@GMAIL.COM",
                        //    Telefone = "62981381485",
                        //    Cpf = "87792933016",
                        //    Login = "master",
                        //    Senha = "admin@123",
                        //};
                        //var salvo = context.Usuarios.Add(teste);
                        //context.SaveChanges();
                        //Console.WriteLine(salvo.Login);
                        //var lista = context.Usuarios.ToList();
                        Console.WriteLine("Banco de dados criado com sucesso");
                        //Console.WriteLine(lista.Count);
                        context.Database.Connection.Close();
                    }
                }
                Console.WriteLine("Sistema executando com sucesso");
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro durante a execução do sistema: " + e.Message);
                Console.WriteLine("Erro (InnerException) : " + e.InnerException);
                Console.WriteLine("Informe ao desenvolvedor do sistema.");
                throw;
            }
            Console.ReadKey();
           
        }
    }
}
