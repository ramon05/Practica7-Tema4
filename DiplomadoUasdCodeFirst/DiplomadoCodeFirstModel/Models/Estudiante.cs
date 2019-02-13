using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoCodeFirstModel.Models
{
	public class Estudiante
	{
		public int EstudianteID { get; set; }

		[Required(ErrorMessage ="El Nombre es Obligatorio")]
		public String Nombres { get; set; }

		[Required(ErrorMessage="El Apellido es Obligatorio")]
		public string Apellidos { get; set; }

		[Required(ErrorMessage ="La Fecha es Obligatoria")]
		public DateTime Fecha_Ingreso { get; set; }
		public virtual ICollection<Inscripcion> Inscripcions { get; set; }

	}
}
