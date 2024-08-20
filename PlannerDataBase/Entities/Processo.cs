using PlannerDataBase.Entities.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerDataBase.Entities
{
    public class Processo : EntidadeBase
    {
        [ForeignKey("ContatoCliente")]
        public int ContatoClienteId { get; set; }
        public Contato ContatoCliente { get; set; }

        [StringLength(80)]
        public string NumeroProcesso { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(1000)]
        public string Descricao { get; set; }

        [StringLength(50)]
        public string Tipo { get; set; }
    }
}
