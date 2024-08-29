using PlannerTransmission.DTOs.EntidadeBaseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerTransmission.DTOs
{
    public class PermissaoDto : EntidadeBaseDto.EntidadeBaseDto
    {
        public string NomeDaTela { get; set; }

        public bool Privado { get; set; }

        public string Senha { get; set; }
    }
}
