using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sats.Models
{
   
    [Table("Leituras")]
    public class Leitura
    {
        [Key]
        [StringLength(50)]
        public string Leiturista { get; set; }
        public DateTime Data_Hora { get; set; }
        public float Valor_Leitura { get; set; }
        public int Ponto_Leitura { get; set; }
    }
}

