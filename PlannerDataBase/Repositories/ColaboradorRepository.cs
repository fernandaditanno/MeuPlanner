using PlannerDataBase.Authentication;
using PlannerDataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerDataBase.Repositories
{
    public class ColaboradorRepository
    {
        public Colaborador Adicionar(Colaborador Colaborador)
        {
            try
            {
                using (var contexto = new BancoDeDadosContext())
                {
                    contexto.Database.Connection.Open();
                    var salvo = contexto.Colaboradores.Add(Colaborador);
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
        public Colaborador Editar(Colaborador Colaborador, int Id)
        {
            try
            {
                using (var contexto = new BancoDeDadosContext())
                {
                    contexto.Database.Connection.Open();
                    var editarColaborador = contexto.Colaboradores.Find(Id);
                    editarColaborador = Colaborador;
                    contexto.SaveChanges();
                    var salvo = contexto.Colaboradores.FirstOrDefault(u => u.Id == Id);
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
                    contexto.Colaboradores.Remove(contexto.Colaboradores.Find(Id));
                    contexto.SaveChanges();
                    contexto.Database.Connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
            }
        }
        public List<Colaborador> Listar()
        {
            try
            {
                using (var contexto = new BancoDeDadosContext())
                {
                    contexto.Database.Connection.Open();
                    var lista = contexto.Colaboradores.ToList();
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
        public Colaborador ConsultarPorId(int Id)
        {
            try
            {
                using (var contexto = new BancoDeDadosContext())
                {
                    contexto.Database.Connection.Open();
                    var Item = contexto.Colaboradores.Find(Id);
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
