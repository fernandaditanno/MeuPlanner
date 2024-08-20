using PlannerDataBase.Entities.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerDataBase.Entities
{
    public class Colaborador : EntidadeBase
    {
        
        [ForeignKey("ContatoColaborador")]
        public int ContatoColaboradorId { get; set; }
        public Contato ContatoColaborador { get; set; }

        [ForeignKey("ContatoCliente")]
        public int ContatoClienteId { get; set; }
        public Contato ContatoCliente { get; set; }
    }
}
