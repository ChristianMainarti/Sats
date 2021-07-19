using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sats.Models
{
  
        [Table("Macros")]
        public class Macro
        {
            [Key]
            public int ID { get; set; }

            [StringLength(50)]
            public string Nome_Macro { get; set; }
            public ICollection<Ponto> Pontos { get; set; }
        }

}
