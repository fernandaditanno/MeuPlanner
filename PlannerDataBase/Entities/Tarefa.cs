using PlannerDataBase.Entities.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerDataBase.Entities
{
    public class Tarefa : EntidadeBase
    {
        [DataType(DataType.DateTime)]
        public DateTime Data { get; set; }

        public bool Feito { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(1000)]
        public string Descricao { get; set; }
    }
}
