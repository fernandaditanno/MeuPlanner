using PlannerTransmission.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerTransmission.Interfaces
{
    public interface IEvento
    {
        List<EventoDto> Listar();
        void Excluir(int Id);
        EventoDto Editar(EventoDto usuario, int Id);
        EventoDto Adicionar(EventoDto usuario);
    }
}
