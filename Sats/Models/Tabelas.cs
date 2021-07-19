using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sats.Models
{
    public class Tabelas
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
            [ForeignKey("Macro")]
            public int Macro_ID { get; set; }
            public Macro Macro { get; set; }
            public ICollection<ConfigVaz> Config_Vazs { get; set; }
            public ICollection<ConfigNv> Config_Nvs { get; set; }
            public ICollection<ConfigBomba> Config_Bombas { get; set; }
            public ICollection<LeituraVazão> LeituraVazãos { get; set; }
            public ICollection<LeituraNível> LeituraNívels { get; set; }
            public ICollection<LeituraBomba> LeituraBombas { get; set; }
        }
        [Table("Macros")]
        public class Macro
        {
            [Key]
            public int ID { get; set; }

            [StringLength(50)]
            public string Nome_Macro { get; set; }
            public ICollection<Ponto> Pontos { get; set; }
        }
        [Table("Tipos_Ponto")]
        public class Tipo_Ponto
        {
            [Key]
            public int ID_Nome { get; set; }
        }
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
        [Table("LeiturasNível")]
        public class LeituraNível
        {
            [Key]
            public int ID_Leitura { get; set; }
            public DateTime Data_Hora { get; set; }
            [StringLength(50)]
            public string Leiturista { get; set; }
            public float Valor_Leitura { get; set; }
            public bool Tipo_Nível { get; set; }

            [ForeignKey("Ponto")]
            public int Ponto_Leitura { get; set; }
            public Ponto Ponto { get; set; }
        }
        [Table("LeiturasBomba")]
        public class LeituraBomba
        {
            [Key]
            public int ID_Leitura { get; set; }
            public DateTime Data_Hora { get; set; }
            [StringLength(50)]
            public string Leiturista { get; set; }
            public bool Valor_Leitura { get; set; }
            [ForeignKey("Ponto")]
            public int Ponto_Leitura { get; set; }
            public Ponto Ponto { get; set; }
        }
    }
}
