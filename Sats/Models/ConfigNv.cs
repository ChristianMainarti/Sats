using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sats.Models
{
    [Table("ConfigNv")]
    public class ConfigNv
    {
        [Key]
        public int ID { get; set; }
        public int LimSup { get; set; }
        public int LimInf { get; set; }
        [ForeignKey("Ponto")]
        public int Ponto_ID { get; set; }
        public Ponto Ponto { get; set; }
    }
}
