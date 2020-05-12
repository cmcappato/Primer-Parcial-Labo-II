using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {
		#region Campos

		private List<Alumno> alumnos;
		private EColores colorSala;
		private Docente docente;
		private ETurno turno;

		#endregion

		#region Propiedades

		public List<Alumno> Alumnos
		{
			get { return alumnos; }
			set { alumnos = value; }
		}

		public EColores Colores
		{
			get { return colorSala; }
			set { colorSala = value; }
		}

		public Docente Docente
		{
			get { return docente; }
			set { docente = value; }
		}

		public ETurno Turno
		{
			get { return turno; }
			set { turno = value; }
		}

		#endregion

		#region Constructor

		public Aula(EColores colorSala, ETurno turno, Docente docente)
		{
			this.turno = turno;
			this.colorSala = colorSala;
			this.docente = docente;
		}

		#endregion

		#region Sobrecarga de operadores

		public static bool operator +(Aula aula, Alumno alumno)
		{
			bool agrego = false;
					

			if (aula.alumnos.Count < 30)
			{
				aula.alumnos.Add(alumno);
				agrego = true;
			}

			return agrego;
		}

		#endregion
	}
}
