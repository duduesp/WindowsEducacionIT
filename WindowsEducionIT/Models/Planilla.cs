using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionIT.Models
{
    [Table("Planilla")]
    public class Planilla
    {
        [Key]
        public int IdPlanilla { get; set; }
        public int IdCarrera { get; set; }
        [ForeignKey("IdCarrera")]
        public Carrera Carrera { get; set; }


        public int IdMateria { get; set; }
        [ForeignKey("IdMateria")]
        public Materia Materia { get; set; }



        public int IdProfesor { get; set; }
        [ForeignKey("IdProfesor")]
        public Profesor Profesor { get; set; }

        public int IdCurso { get; set; }
        [ForeignKey("IdCurso")]
        public Curso Curso { get; set; }

        public DateTime Fecha { get; set; }
    }
}
