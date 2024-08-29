using PlannerTransmission.DTOs.EntidadeBaseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerTransmission.DTOs
{
    public class EventoDto : EntidadeBaseDto.EntidadeBaseDto
    {
        public DateTime Data { get; set; }

        public string Horario { get; set; }

        public ContatoDto ContatoCliente { get; set; }

        public string DescricaoEvento { get; set; }

        public PermissaoDto PermissaoVisualizacao { get; set; }
    }
}
