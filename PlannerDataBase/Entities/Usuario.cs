using PlannerDataBase.Entities.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerDataBase.Entities
{
    public class Usuario : EntidadeBase
    {
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(250)]
        public string Sobrenome { get; set; }

        [MaxLength(250)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Telefone { get; set; }

        [MaxLength(50)]
        public string Cpf { get; set; }

        [MaxLength(50)]
        public string Login { get; set; }

        [MaxLength(50)]
        public string Senha { get; set; }
    }
}
