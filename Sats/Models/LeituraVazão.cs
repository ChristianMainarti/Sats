using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sats.Models
{
    
    [Table("LeiturasVazão")]
    public class LeituraVazão
    {
        [Key]
        public int ID_Leitura { get; set; }
        public DateTime Data_Hora { get; set; }
        [StringLength(50)]
        public string Leiturista { get; set; }
        public float Valor_Leitura { get; set; }
        [ForeignKey("Ponto")]
        public int Ponto_Leitura { get; set; }
        public Ponto Ponto { get; set; }
        }
}
