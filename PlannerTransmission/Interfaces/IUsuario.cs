using PlannerTransmission.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerTransmission.Interfaces
{
    public interface IUsuario
    {
        List<UsuarioDto> Listar();
        void Excluir(int Id);
        UsuarioDto Editar(UsuarioDto usuario, int Id);
        UsuarioDto Adicionar(UsuarioDto usuario);
    }
}
