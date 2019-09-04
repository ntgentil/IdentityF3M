using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Domain.Entities
{
    [Table("f3m.Operadora")]
    public partial class Operadora
    {
        public int OperadoraID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [StringLength(200)]
        public string Descricao { get; set; }

        public int? ImagemID { get; set; }

        public int? TipoOperadoraID { get; set; }
    }
}
