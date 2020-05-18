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
using System.Media;

namespace Cappato.Carolina._2D
{
    public partial class FrmAltas : Form
    {
        List<Docente> listaDocentes;
        List<Alumno> listaAlumnos;
        List<Aula> listAulas;

        public FrmAltas(List<Docente> listaDocentes, List<Alumno> listaAlumnos, List<Aula> listAulas)
        {
            InitializeComponent();
            this.listaDocentes = listaDocentes;
            this.listaAlumnos = listaAlumnos;
            this.listAulas = listAulas;
        }

        

        private void FrmAltas_Load(object sender, EventArgs e)
        {
            cmbColores.DataSource = Enum.GetValues(typeof(EColores));
            cmbTurno.DataSource = Enum.GetValues(typeof(ETurno));
            cmbDocentes.DataSource = listaDocentes;
            lstAlumnosSinAula.DataSource = listaAlumnos;

            #region No funcionó

            //cmbDocentes.ValueMember = "Apellido";
            //cmbDocentes.DisplayMember = String.Concat("Apellido", ", ", "Nombre");

            //foreach(Docente docente in listaDocentes)
            //{
            //    cmbDocentes.Items.Add(docente.ToString());
            //}

            #endregion
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
            if (MessageBox.Show("¿Desea guardar los cambios ?", "Guardar cambios", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Aula nuevaAula = new Aula((EColores)cmbColores.SelectedItem, (ETurno)cmbTurno.SelectedItem, (Docente)cmbDocentes.SelectedItem);
                foreach (Alumno alumno in lstAlumnosSinAula.SelectedItems)
                {
                    alumno.ColorSala = nuevaAula.Colores;
                    nuevaAula.Alumnos.Add(alumno);
                }
                this.listAulas.Add(nuevaAula);

                MessageBox.Show("Se han guardado los cambios");

                SystemSounds.Beep.Play(); //Por algun motivo esto no hace sonido 
            }
            else
            {
                MessageBox.Show("No se guardaron los cambios");
            }

        }

        private void cmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarAltas_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}