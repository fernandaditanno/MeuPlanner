using PlannerDataBase.Entities.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerDataBase.Entities
{
    public class Contato : EntidadeBase
    {
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(250)]
        public string Sobrenome { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Telefone { get; set; }

        [StringLength(50)]
        public string Cpf { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(300)]
        public string Endereco { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DataNascimento { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(1000)]
        public string Descricao { get; set; }
    }
}
