using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoCodeFirstModel.Models
{
	public class Curso
	{
		public int CursoID { get; set; }

		[Required(ErrorMessage ="La Descripción es Obligatoria")]
		public string Descrpcion { get; set; }
		public virtual ICollection<Inscripcion> Inscripcions { get; set; }

	}
}
