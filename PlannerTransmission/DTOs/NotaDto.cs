using PlannerTransmission.DTOs.EntidadeBaseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerTransmission.DTOs
{
    public class NotaDto : EntidadeBaseDto.EntidadeBaseDto
    {
        public string Titulo { get; set; }

        public string Descricao { get; set; }
    }
}
