using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exp3.Models
{
    [Table("Tbt_Brinquedo")]
    public class Brinquedo
    {
        [Column("Id"), HiddenInput]
        public int BrinquedoId { get; set; }
        [MaxLength(55)]
        public string Nome { get; set; }
        [Required, Display(Name = "Data de Fabricação"), DataType(DataType.Date)]
        public DateTime DataFabricacao { get; set; }

        public double? Valor { get; set; }
        [Required]
        public Tipo Tipo { get; set; }
        [Required]
        public bool PrecisaAcompanhante { get; set; }

        //Cardinalidade: N => 1

        public Manutencao Manutencao { get; set; }

        public int? ManutencaoId { get; set; }

        //Cardinalidade: N => M
        public ICollection<BrinquedoColaborador> BrinquedosColaboradores { get; set; }
    }
}
