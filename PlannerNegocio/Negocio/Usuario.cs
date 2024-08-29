using PlannerDataBase.Negocio;
using PlannerTransmission.DTOs;
using PlannerTransmission.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerNegocio.Negocio
{
    public class Usuario
    {
        public readonly IUsuario _usuario;
        public Usuario()
        {
            _usuario = new UsuarioService();
        }
        public UsuarioDto Adicionar(UsuarioDto usuario) 
        { 
            return _usuario.Adicionar(usuario);
        }
        public UsuarioDto Editar(UsuarioDto usuario, int Id)
        {
            return _usuario.Editar(usuario, Id);
        }
        public void Excluir(int Id)
        {
            _usuario.Excluir(Id);    
        }
        public List<UsuarioDto> Listar() 
        { 
            return _usuario.Listar();
        }
    }
}
