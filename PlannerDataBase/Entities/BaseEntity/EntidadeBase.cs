using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace PlannerDataBase.Entities.BaseEntity
{
    public class EntidadeBase
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string UsuarioCadastro { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DataCadastro { get; set; }
    }
}
