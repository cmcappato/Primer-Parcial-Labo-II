using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Responsable : Persona
    {
		#region Campos

		private EParentesco parentesco;
		private string telefono;

		#endregion

		#region Propiedades

		public EParentesco Parentezco
		{
			get { return parentesco; }
			set { parentesco = value; }
		}

		public string Telefono
		{
			get { return telefono; }
			set { telefono = value; }
		}

		#endregion

		#region Constructor

		private Responsable(string apellido, string nombre, int dni, bool femenino, EParentesco parentesco, string telefono) : base(apellido, nombre, dni, femenino)
		{
			this.parentesco = parentesco;
			this.telefono = telefono;
		}

		#endregion
	}
}
