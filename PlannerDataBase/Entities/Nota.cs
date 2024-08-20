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
    public class Nota : EntidadeBase
    {
        [StringLength(250)]
        public string Titulo { get; set; }


        [DataType(DataType.MultilineText)]
        [StringLength(1000)]
        public string Descricao { get; set; }


        [StringLength(250)]
        public string PalavraChave { get; set; }

        public bool Fixar { get; set; }

        [ForeignKey("ContatoCliente")]
        public int ContatoClienteId { get; set; }
        public Contato ContatoCliente { get; set; }

    }
}
