using PlannerTransmission.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerTransmission.Interfaces
{
    public interface IPermissao
    {
        List<PermissaoDto> Listar();
        void Excluir(int Id);
        PermissaoDto Editar(PermissaoDto usuario, int Id);
        PermissaoDto Adicionar(PermissaoDto usuario);
    }
}
