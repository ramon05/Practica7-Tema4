using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoCodeFirstModel.Models
{
	public class Inscripcion
	{
		public int InscripcionID { get; set; }
		public int CursoID { get; set; }
		public int EstudianteID { get; set; }

		[Required(ErrorMessage = "El Semetre es Obligatorio")]
		public int Semestre { get; set; }
		public virtual Curso Curso { get; set; }
		public virtual Estudiante Estudiante { get; set; }

	}
}
