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
    public class Evento : EntidadeBase
    {
        public DateTime Data { get; set; }

        public string Horario { get; set; }

        [ForeignKey("ContatoCliente")]
        public int ContatoClienteId { get; set; }
        public Contato ContatoCliente { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(1000)]
        public string DescricaoEvento { get; set; }

        [ForeignKey("PermissaoVisualizacao")]
        public int PermissaoVisualizacaoId { get; set; }
        public Permissao PermissaoVisualizacao { get; set; }
    }
}
