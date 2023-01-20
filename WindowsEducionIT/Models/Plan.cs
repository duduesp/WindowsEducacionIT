using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionIT.Models
{
    [Table("Plan")]
    public class Plan
    {
        [Key]
        public int IdPlan { get; set; }

        public int IdCarrera { get; set; }
        [ForeignKey("IdCarrera")]
        public Carrera Carrera { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }

    }
}
