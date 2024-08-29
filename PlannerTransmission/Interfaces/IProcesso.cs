using PlannerTransmission.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerTransmission.Interfaces
{
    public interface IProcesso
    {
        List<ProcessoDto> Listar();
        void Excluir(int Id);
        ProcessoDto Editar(ProcessoDto usuario, int Id);
        ProcessoDto Adicionar(ProcessoDto usuario);
    }
}
