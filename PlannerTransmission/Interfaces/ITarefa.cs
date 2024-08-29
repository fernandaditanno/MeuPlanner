using PlannerTransmission.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerTransmission.Interfaces
{
    public interface ITarefa
    {
        List<TarefaDto> Listar();
        void Excluir(int Id);
        TarefaDto Editar(TarefaDto usuario, int Id);
        TarefaDto Adicionar(TarefaDto usuario);
    }
}
