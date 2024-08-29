using PlannerTransmission.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerTransmission.Interfaces
{
    public interface IContato
    {
        List<ContatoDto> Listar();
        void Excluir(int Id);
        ContatoDto Editar(ContatoDto usuario, int Id);
        ContatoDto Adicionar(ContatoDto usuario);
    }
}
