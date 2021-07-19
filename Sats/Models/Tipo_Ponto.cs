using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sats.Models
{
    [Table("Tipos_Ponto")]
    public class Tipo_Ponto
    {
        [Key]
        public int ID_Nome { get; set; }
    }

}
