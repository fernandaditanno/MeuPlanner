using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerTransmission.DTOs.EntidadeBaseDto
{
    public class EntidadeBaseDto
    {
        public int Id { get; set; }
        public string UsuarioCadastro { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
