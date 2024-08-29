using PlannerTransmission.DTOs.EntidadeBaseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerTransmission.DTOs
{
    public class ProcessoDto : EntidadeBaseDto.EntidadeBaseDto
    {
        public ContatoDto ContatoCliente { get; set; }

        public string NumeroProcesso { get; set; }

        public string Descricao { get; set; }

        public string Tipo { get; set; }
    }
}
