using PlannerDataBase.Authentication;
using PlannerDataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerDataBase.Repositories
{
    public class ContatoRepository
    {
        public Contato Adicionar(Contato Contato)
        {
            try
            {
                using (var contexto = new BancoDeDadosContext())
                {
                    contexto.Database.Connection.Open();
                    var salvo = contexto.Contatos.Add(Contato);
                    contexto.SaveChanges();
                    contexto.Database.Connection.Close();
                    return salvo;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
                return null;
            }
        }
        public Contato Editar(Contato Contato, int Id)
        {
            try
            {
                using (var contexto = new BancoDeDadosContext())
                {
                    contexto.Database.Connection.Open();
                    var editarContato = contexto.Contatos.Find(Id);
                    editarContato = Contato;
                    contexto.SaveChanges();
                    var salvo = contexto.Contatos.FirstOrDefault(u => u.Id == Id);
                    contexto.Database.Connection.Close();
                    return salvo;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
                return null;
            }
        }
        public void Excluir(int Id)
        {
            try
            {
                using (var contexto = new BancoDeDadosContext())
                {
                    contexto.Database.Connection.Open();
                    contexto.Contatos.Remove(contexto.Contatos.Find(Id));
                    contexto.SaveChanges();
                    contexto.Database.Connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
            }
        }
        public List<Contato> Listar()
        {
            try
            {
                using (var contexto = new BancoDeDadosContext())
                {
                    contexto.Database.Connection.Open();
                    var lista = contexto.Contatos.ToList();
                    contexto.SaveChanges();
                    contexto.Database.Connection.Close();
                    return lista;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
                return null;
            }
        }
        public Contato ConsultarPorId(int Id)
        {
            try
            {
                using (var contexto = new BancoDeDadosContext())
                {
                    contexto.Database.Connection.Open();
                    var Item = contexto.Contatos.Find(Id);
                    contexto.SaveChanges();
                    contexto.Database.Connection.Close();
                    return Item;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
                return null;
            }
        }
    }
}
