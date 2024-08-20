using PlannerDataBase.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        Console.WriteLine("Banco de dados criado com sucesso");
                        context.Database.Connection.Close();
                    }
                }
                Console.WriteLine("Sistema executando com sucesso");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro durante a execução do sistema: " + e.Message);
                Console.WriteLine("Erro (InnerException) : " + e.InnerException);
                Console.WriteLine("Informe ao desenvolvedor do sistema.");
                throw;
            }

          
        }
    }
}
