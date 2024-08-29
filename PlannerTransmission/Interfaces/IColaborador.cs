using PlannerTransmission.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerTransmission.Interfaces
{
    public interface IColaborador
    {
        List<ColaboradorDto> Listar();
        void Excluir(int Id);
        ColaboradorDto Editar(ColaboradorDto usuario, int Id);
        ColaboradorDto Adicionar(ColaboradorDto usuario);
    }
}
