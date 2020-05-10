using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente : Personal
    {
		#region Campos

		private double valorHora;

		#endregion

		#region Propiedades

		public double ValorHora
		{
			get { return valorHora; }
			set { valorHora = value; }
		}

		public int HorasMensuales
		{
			get;
		}

		#endregion

		#region Constructor

		private Docente(string apellido, string nombre, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida) : base(apellido, nombre, dni, femenino, horaEntrada, horaSalida)
		{

		}

		#endregion

		#region Métodos

		protected override double CalcularSalario()
		{
			return 0;
		}

		#endregion
	}
}
