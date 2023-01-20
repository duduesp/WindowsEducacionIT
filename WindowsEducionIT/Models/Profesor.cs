using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionIT.Models
{
    [Table("Profesor")]
    public class Profesor
    {
        [Key]
        public int IdProfesor { get; set; }



        public int IdLocalidad { get; set; }
        [ForeignKey("IdLocalidad")]
        public Localidad Localidad { get; set; }


        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]


        public string Nombre { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]


        public string Apellido { get; set; }
    }
}
