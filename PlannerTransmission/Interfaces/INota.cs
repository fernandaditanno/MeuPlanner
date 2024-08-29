using PlannerTransmission.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerTransmission.Interfaces
{
    public interface INota
    {
        List<NotaDto> Listar();
        void Excluir(int Id);
        NotaDto Editar(NotaDto usuario, int Id);
        NotaDto Adicionar(NotaDto usuario);
    }
}
