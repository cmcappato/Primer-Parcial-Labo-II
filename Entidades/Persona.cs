using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
		#region Campos

		private string apellido;
		private string nombre;
		private int dni;
		private bool femenino;

		#endregion

		#region Propiedades

		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

		public int Dni
		{
			get { return dni; }
			set { dni = value; }
		}

		public bool Femenino
		{
			get { return femenino; }
			set { femenino = value; }
		}

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		#endregion

		#region Constructores

		protected Persona(string apellido, string nombre, int dni)
		{
			this.apellido = apellido;
			this.nombre = nombre;
			this.dni = dni;
		}

		protected Persona(string apellido, string nombre, int dni, bool femenino) : this (apellido, nombre, dni)
		{
			this.femenino = femenino;
		}

		#endregion
	}
}
