using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exp3.Models
{
    public class Manutencao
    {
        [Column("Id")]
        public int ManutencaoId { get; set; }
        [Required, MaxLength(80)]
        public string Nome { get; set; }

        public double Valor { get; set; }

        public bool ManutencaoEmDia { get; set; }

        // Cardinalidade : 1 => N

        public ICollection<Brinquedo> Brinquedos { get; set; }

    }
}
