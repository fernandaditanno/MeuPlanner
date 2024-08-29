using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace PlannerDataBase.Entities.BaseEntity
{
    public class EntidadeBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(100)]
        public string UsuarioCadastro { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DataCadastro { get; set; }
    }
}
