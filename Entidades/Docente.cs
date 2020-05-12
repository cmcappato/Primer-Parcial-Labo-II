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
		private TimeSpan diferenciaHoras;

		#endregion

		#region Propiedades

		public double ValorHora
		{
			get { return valorHora; }
			set { valorHora = value; }
		}

		public int HorasMensuales
		{
			get { return (int)diferenciaHoras.TotalHours; }
		}

		#endregion

		#region Constructor
		
		public Docente(string apellido, string nombre, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida, double valorHora) : base(apellido, nombre, dni, femenino, horaEntrada, horaSalida)
		{
			diferenciaHoras = horaSalida - horaEntrada;
			this.valorHora = valorHora;
		}

		#endregion

		#region Métodos

		protected override double CalcularSalario()
		{
			double salarioDocente = (valorHora * diferenciaHoras.TotalHours) * 20;

			return salarioDocente;
		}

		public override string ToString()
		{
			return Apellido + ", " + Nombre;
		}


		#endregion
	}
}
