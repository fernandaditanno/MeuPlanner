using PlannerDataBase.Authentication;
using PlannerDataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerDataBase.Repositories
{
    public class UsuarioRepository
    {
        public Usuario Adicionar(Usuario usuario) 
        {
            try
            {
                using(var contexto = new BancoDeDadosContext())
                {
                    contexto.Database.Connection.Open();
                    var salvo = contexto.Usuarios.Add(usuario);
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
        public Usuario Editar(Usuario usuario, int Id) 
        {
            try
            {
                using (var contexto = new BancoDeDadosContext())
                {
                    contexto.Database.Connection.Open();
                    var editarUsuario = contexto.Usuarios.Find(Id);
                    editarUsuario = usuario;
                    contexto.SaveChanges();
                    var salvo = contexto.Usuarios.Find(Id);
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
                    contexto.Usuarios.Remove(contexto.Usuarios.Find(Id));
                    contexto.SaveChanges();
                    contexto.Database.Connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
            }
        }
        public List<Usuario> Listar() 
        {
            try
            {
                using (var contexto = new BancoDeDadosContext())
                {
                    contexto.Database.Connection.Open();
                    var lista = contexto.Usuarios.ToList();
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
        public Usuario ConsultarPorId(int Id) {
            try
            {
                using (var contexto = new BancoDeDadosContext())
                {
                    contexto.Database.Connection.Open();
                    var Item = contexto.Usuarios.Find(Id);
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
