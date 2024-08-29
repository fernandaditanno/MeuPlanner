using PlannerTransmission.DTOs.EntidadeBaseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerTransmission.DTOs
{
    public class UsuarioDto : EntidadeBaseDto.EntidadeBaseDto
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Cpf { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }
    }
}
