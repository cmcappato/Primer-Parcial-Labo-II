using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrativo : Personal
    {
		#region Campos

		private ECargo cargo;
		public static double salarioBase;

		#endregion

		#region Propiedad

		public ECargo Cargo
		{
			get { return cargo; }
			set { cargo = value; }
		}

		#endregion

		#region Constructor

		public Administrativo(string apellido, string nombre, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida, ECargo cargo) : base(apellido, nombre, dni, femenino, horaEntrada, horaSalida)
		{
			this.cargo = cargo;
		}

		static Administrativo()
		{
			salarioBase = 30000;
		}

		#endregion

		#region Métodos

		protected override double CalcularSalario()
		{
			double salarioAdministrativo = salarioBase * (double)cargo / 100;

			//if(cargo == ECargo.Portería)
			//{
			//	salarioTotal = salarioBase;
			//}
			//else if (cargo == ECargo.Cocina)
			//{
			//	salarioTotal = (salarioBase * 110) / 100;
			//}
			//else if (cargo == ECargo.Secretaría)
			//{
			//	salarioTotal = (salarioBase * 140) / 100;
			//}
			//else if (cargo == ECargo.Portería)
			//{
			//	salarioTotal = (salarioBase * 240) / 100;
			//}
			//else if (cargo == ECargo.Dirección)
			//{
			//	salarioTotal = (salarioBase * 180) / 100;
			//}

			return salarioAdministrativo;
		}

		#endregion
	}
}
