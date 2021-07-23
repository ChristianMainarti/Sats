using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace Sats.Models
{    
        [Table("Pontos")]
        public class Ponto
        {
            [Key]
            public int ID_Ponto { get; set; }
            [StringLength(50)]
            public string Nome_Ponto { get; set; }
            [StringLength(100)]
            public string Endereço_Ponto { get; set; }
            [StringLength(50)]
            public string Nome_Medidor { get; set; }
            [StringLength(50)]
            public string Tipo_Medidor { get; set; }
            [ForeignKey("Macro")]
            public int Macro_ID { get; set; }
            public Macro Macro { get; set; }
            [ForeignKey("Tipo_Ponto")]
            public int Tipo_Ponto { get; set; }
            public Tipo_Ponto Tipo_Ponto_ID { get; set; }
            public ICollection<ConfigVaz> Config_Vazs { get; set; }
            public ICollection<ConfigNv> Config_Nvs { get; set; }
            public ICollection<ConfigBomba> Config_Bombas { get; set; }
            public ICollection<LeituraVazão> LeituraVazãos { get; set; }
            public ICollection<LeituraNível> LeituraNívels { get; set; }
            public ICollection<LeituraBomba> LeituraBombas { get; set; }
    }
}
