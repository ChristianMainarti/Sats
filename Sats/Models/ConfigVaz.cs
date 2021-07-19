using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sats.Models
{
    [Table("ConfigVaz")]
    public class ConfigVaz
    {
        [Key]
        public int ID_ConfigV { get; set; }
        public int Unidade_Medida { get; set; }
        [ForeignKey("Ponto")]
        public int Ponto_ID { get; set; }
        public Ponto Ponto { get; set; }
    }
}

