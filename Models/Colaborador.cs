using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exp3.Models
{
    [Table("Tbl_Colaborador")]
    public class Colaborador
    {
        [Column("Id")]
        public int ColaboradorId { get; set; }
        [Required, MaxLength(80)]
        public string Nome { get; set; }
        [Required, MaxLength(40)]
        public string Especialidade { get; set; }

        // Cardinalidade: 1 => 1

        public ContratoTrabalho ContratoTrabalho { get; set; }

        public int ContratoTrabalhoId { get; set; }

        //Cardinalidade: M => N

        public ICollection<BrinquedoColaborador> BrinquedosColaboradores { get; set; }

    }
}
