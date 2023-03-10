using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionIT.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Key]
        public int IdEstado { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        [Required]
        public string Nombre { get; set; }

        public List<Detalle> Detalles { get; set;}

    }
}
