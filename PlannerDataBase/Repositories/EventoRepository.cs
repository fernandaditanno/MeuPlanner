using PlannerDataBase.Authentication;
using PlannerDataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerDataBase.Repositories
{
    public class EventoRepository
    {
        public Evento Adicionar(Evento Evento)
        {
            try
            {
                using (var contexto = new BancoDeDadosContext())
                {
                    contexto.Database.Connection.Open();
                    var salvo = contexto.Eventos.Add(Evento);
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
        public Evento Editar(Evento Evento, int Id)
        {
            try
            {
                using (var contexto = new BancoDeDadosContext())
                {
                    contexto.Database.Connection.Open();
                    var editarEvento = contexto.Eventos.Find(Id);
                    editarEvento = Evento;
                    contexto.SaveChanges();
                    var salvo = contexto.Eventos.FirstOrDefault(u => u.Id == Id);
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
                    contexto.Eventos.Remove(contexto.Eventos.Find(Id));
                    contexto.SaveChanges();
                    contexto.Database.Connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
            }
        }
        public List<Evento> Listar()
        {
            try
            {
                using (var contexto = new BancoDeDadosContext())
                {
                    contexto.Database.Connection.Open();
                    var lista = contexto.Eventos.ToList();
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
        public Evento ConsultarPorId(int Id)
        {
            try
            {
                using (var contexto = new BancoDeDadosContext())
                {
                    contexto.Database.Connection.Open();
                    var Item = contexto.Eventos.Find(Id);
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
