using PlannerDataBase.Authentication;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace PlannerDataBase.Repositories.RapositoryBase
{
    public class RepositorioBase<T> where T : class
    {
        private readonly BancoDeDadosContext _contexto;
        public RepositorioBase(BancoDeDadosContext contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(T entidade)
        {
            _contexto.Set<T>().Add(entidade);
            _contexto.SaveChanges();
        }

        public void Remover(T entidade)
        {
            _contexto.Set<T>().Remove(entidade);
            _contexto.SaveChanges();
        }

        public T ObterPorId(int id)
        {
            return _contexto.Set<T>().Find(id);
        }

        public List<T> ObterTodos()
        {
            return _contexto.Set<T>().ToList();
        }
        public void Atualizar(T entidade)
        {
            _contexto.Entry(entidade).State = EntityState.Modified;
        }
    }
}
