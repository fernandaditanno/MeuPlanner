using PlannerDataBase.Authentication;
using PlannerDataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerDataBase.Repositories
{
    public class PermissaoRepository
    {
        public Permissao Adicionar(Permissao Permissao)
        {
            try
            {
                using (var contexto = new BancoDeDadosContext())
                {
                    contexto.Database.Connection.Open();
                    var salvo = contexto.Permissoes.Add(Permissao);
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
        public Permissao Editar(Permissao Permissao, int Id)
        {
            try
            {
                using (var contexto = new BancoDeDadosContext())
                {
                    contexto.Database.Connection.Open();
                    var editarPermissao = contexto.Permissoes.Find(Id);
                    editarPermissao = Permissao;
                    contexto.SaveChanges();
                    var salvo = contexto.Permissoes.FirstOrDefault(u => u.Id == Id);
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
                    contexto.Permissoes.Remove(contexto.Permissoes.Find(Id));
                    contexto.SaveChanges();
                    contexto.Database.Connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
            }
        }
        public List<Permissao> Listar()
        {
            try
            {
                using (var contexto = new BancoDeDadosContext())
                {
                    contexto.Database.Connection.Open();
                    var lista = contexto.Permissoes.ToList();
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
        public Permissao ConsultarPorId(int Id)
        {
            try
            {
                using (var contexto = new BancoDeDadosContext())
                {
                    contexto.Database.Connection.Open();
                    var Item = contexto.Permissoes.Find(Id);
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
