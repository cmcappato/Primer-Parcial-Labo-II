using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        #region Campos

        private EColores colorSala;
        private int legajo;
        private float precioCuota;
        private Responsable responsable;

        #endregion

        #region Propiedades

        public EColores ColorSala
        {
            get { return colorSala; }
            set { colorSala = value; }
        }

        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        public float PrecioCuota
        {
            get { return precioCuota; }
            set { precioCuota = value; }
        }

        public Responsable Responsable
        {
            get { return responsable; }
            set { responsable = value; }
        }

        #endregion

        #region Constructor

        public Alumno(string apellido, string nombre, int dni, bool femenino, float precioCuota) : base(apellido, nombre, dni, femenino)
        {
            this.precioCuota = precioCuota;
        }

        #endregion

        #region Sobrecargas de operadores

        public static implicit operator Responsable(Alumno al)
        {
            return al.responsable;
        }

        public static bool operator ==(Alumno a1, Alumno a2)
        {
            return (a1.legajo == a2.legajo) && (((Responsable)a1) == (a2.responsable));
        }

        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }
        #endregion

        #region Invalidaciones
               
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return Apellido + ", " + Nombre;
        }

        #endregion
    }
}
