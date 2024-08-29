using PlannerTransmission.DTOs.EntidadeBaseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerTransmission.DTOs
{
    public class ColaboradorDto : EntidadeBaseDto.EntidadeBaseDto
    {

        public ContatoDto ContatoColaborador { get; set; }

        public ContatoDto ContatoCliente { get; set; }
    }
}
