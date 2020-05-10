using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Personal : Persona
    {
		#region Campos

		private DateTime horaEntrada;
		private DateTime horaSalida;

		#endregion

		#region Propiedades

		public DateTime HoraEntrada
		{
			get { return horaEntrada; }
			set { horaEntrada = value; }
		}

		public DateTime HoraSalida
		{
			get { return horaSalida; }
			set { horaSalida = value; }
		}

		public double Salario { get { return CalcularSalario(); } }

		#endregion

		#region Constructor

		protected Personal(string apellido, string nombre, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida) : base(apellido, nombre, dni, femenino)
		{
			this.horaEntrada = horaEntrada;
			this.horaSalida = horaSalida;
		}

		#endregion

		#region Métodos

		protected abstract double CalcularSalario();

		#endregion
	}
}
