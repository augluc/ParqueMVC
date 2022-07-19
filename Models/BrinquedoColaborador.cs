using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exp3.Models
{
    [Table("Tbl_Brinquedo_Colaborador")]
    public class BrinquedoColaborador
    {
        public Brinquedo Brinquedo { get; set; }

        public int BrinquedoId { get; set; }

        public Colaborador Colaborador { get; set; }

        public int ColaboradorId { get; set; }

        public DateTime Data { get; set; }





    }
}
