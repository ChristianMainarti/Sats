using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sats.Models
{
    [Table("ConfigBomba")]
    public class ConfigBomba
    {
        [Key]
        public int ID { get; set; }
        public bool Estado { get; set; }
        [ForeignKey("Ponto")]
        public int Ponto_ID { get; set; }
        public Ponto Ponto { get; set; }
    }
}
