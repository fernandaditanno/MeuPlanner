using PlannerDataBase.Entities.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerDataBase.Entities
{
    public class Permissao : EntidadeBase
    {
        [StringLength(100)]
        public string NomeDaTela { get; set; }

        public bool Privado { get; set; }

        [StringLength(100)]
        public string Senha { get; set; }
    }
}
