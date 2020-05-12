using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cappato.Carolina._2D
{
    public partial class FrmAltas : Form
    {
        List<Docente> listaDocentes;
        List<Alumno> listaAlumnos;

        public FrmAltas(List<Docente> listaDocentes, List<Alumno> listaAlumnos)
        {
            InitializeComponent();
            this.listaDocentes = listaDocentes;
            this.listaAlumnos = listaAlumnos;
        }

        private void FrmAltas_Load(object sender, EventArgs e)
        {
            cmbColores.DataSource = Enum.GetValues(typeof(EColores));
            cmbDocentes.ValueMember = "Apellido";
            cmbDocentes.DisplayMember = String.Concat("Apellido", ", ", "Nombre");
            //cmbDocentes.DataSource = listaDocentes;

            foreach(Docente docente in listaDocentes)
            {
                cmbDocentes.Items.Add(docente.ToString());
            }

            dgvAlumnosAsignados.DataSource = listaAlumnos;

        }

        private void cmbColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.BackColor = (EColores)Enum.Parse(typeof(EColores));
            //this.BackColor = Color.FromName(cmbColores.SelectedItem.ToString());

            switch ((EColores)cmbColores.SelectedItem)
            {
                case EColores.Naranja:
                    this.BackColor = Color.FromArgb(225, 127, 29);
                    break;
                case EColores.Rojo:
                    this.BackColor = Color.FromArgb(189, 8, 8);
                    break;
                case EColores.Amarillo:
                    this.BackColor = Color.FromArgb(222, 222, 2);
                    break;
                case EColores.Verde:
                    this.BackColor = Color.FromArgb(8, 195, 102);
                    break;
                default:
                    break;                    
            }
        }


        private void btnGuardarAltas_Click(object sender, EventArgs e)
        {

        }

    }
}