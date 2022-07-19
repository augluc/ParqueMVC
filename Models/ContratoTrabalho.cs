using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exp3.Models
{
    public class ContratoTrabalho
    {
        [Column("Id")]
        public int ContratoTrabalhoId { get; set; }
        [Column("Dt_Contratacoes", TypeName ="date"), Display(Name = "Data de Contratação"), DataType(DataType.Date), Required]
        public DateTime DataContratacao { get; set; }

        public TipoContrato Tipo { get; set; }

        public double ValorSalario { get; set; }





    }
}
