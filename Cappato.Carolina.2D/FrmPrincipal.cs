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
    public partial class FrmPrincipal : Form
    {
        List<Docente> listaDocentes;
        List<Administrativo> listaNoDocentes;
        List<Alumno> listaAlumnos;
        List<Aula> listaAulas;
        //List<Aula> aulasTurnoMañana;
        //List<Aula> aulasTurnoTarde;

        public FrmPrincipal()
        {
            InitializeComponent();
            listaDocentes = new List<Docente>();
            listaNoDocentes = new List<Administrativo>();
            listaAlumnos = new List<Alumno>();
            listaAulas = new List<Aula>();
            //aulasTurnoMañana = new List<Aula>();
            //aulasTurnoTarde = new List<Aula>();
        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        #region Altas faltantes
        private void altaDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmAltas frmAltas = new FrmAltas();
            //frmAltas.MdiParent = this;  
            //frmAltas.ShowDialog();
        }

        private void altaAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmAltas frmAltas = new FrmAltas();
            //frmAltas.MdiParent = this;  
            //frmAltas.Show();
        }
        private void altaNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmAltas frmAltas = new FrmAltas();
            //frmAltas.MdiParent = this;           
            //frmAltas.Show();
        }
        #endregion

        private void altaAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltas frmAltas = new FrmAltas(listaDocentes, listaAlumnos, listaAulas);
            frmAltas.MdiParent = this;

            frmAltas.Show();
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #region Botones para generar data

        private void generarDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateListaDocentes();
            if (listaDocentes != null)//Valido que la lista sea distinta de NULL para deshabilitar el boton
            {
                generarDocentesToolStripMenuItem.Enabled = false;
            }
        }

        private void generarNoDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateListaNoDocentes();
            if (listaNoDocentes != null)//Valido que la lista sea distinta de NULL para deshabilitar el boton
            {
                generarNoDocentesToolStripMenuItem.Enabled = false;
            }
        }

        private void generarAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateListaAlumnos();
            if (listaAlumnos != null)//Valido que la lista sea distinta de NULL para deshabilitar el boton
            {
                generarAlumnosToolStripMenuItem.Enabled = false;
            }
        }

        #endregion

        #region Crear listas

        protected void CreateListaDocentes()
        {
            listaDocentes.Add(new Docente("Perez", "Andrea", 12345564, true, Convert.ToDateTime("1/1/2000  08:00 AM"), Convert.ToDateTime("1/1/2000  12:00 PM"), 200));
            listaDocentes.Add(new Docente("Gomez", "Juliana", 45757862, true, Convert.ToDateTime("1/1/2000  08:00 AM"), Convert.ToDateTime("1/1/2000  12:00 PM"), 200));
            listaDocentes.Add(new Docente("Gimenez", "Lucia", 97612452, true, Convert.ToDateTime("1/1/2000  08:00 AM"), Convert.ToDateTime("1/1/2000  12:00 PM"), 200));
            listaDocentes.Add(new Docente("Chavez", "Marcos", 34595215, false, Convert.ToDateTime("1/1/2000  01:00 PM"), Convert.ToDateTime("1/1/2000  05:00 PM"), 200));
            listaDocentes.Add(new Docente("Guemes", "Eliana", 67245585, true, Convert.ToDateTime("1/1/2000  01:00 PM"), Convert.ToDateTime("1/1/2000  05:00 PM"), 200));
        }

        private void CreateListaNoDocentes()
        {
            listaNoDocentes.Add(new Administrativo("", "", 12345564, true, Convert.ToDateTime("1/1/2000  08:00 AM"), Convert.ToDateTime("1/1/2000  12:00 PM"), ECargo.Dirección));
            listaNoDocentes.Add(new Administrativo("", "", 45757862, true, Convert.ToDateTime("1/1/2000  08:00 AM"), Convert.ToDateTime("1/1/2000  12:00 PM"), ECargo.Cocina));
            listaNoDocentes.Add(new Administrativo("", "", 97612452, true, Convert.ToDateTime("1/1/2000  08:00 AM"), Convert.ToDateTime("1/1/2000  12:00 PM"), ECargo.Portería));
            listaNoDocentes.Add(new Administrativo("", "", 34595215, true, Convert.ToDateTime("1/1/2000  01:00 PM"), Convert.ToDateTime("1/1/2000  05:00 PM"), ECargo.Secretaría));
            listaNoDocentes.Add(new Administrativo("", "", 67245585, true, Convert.ToDateTime("1/1/2000  01:00 PM"), Convert.ToDateTime("1/1/2000  05:00 PM"), ECargo.Tesorería));
            listaNoDocentes.Add(new Administrativo("", "", 45757862, true, Convert.ToDateTime("1/1/2000  08:00 AM"), Convert.ToDateTime("1/1/2000  12:00 PM"), ECargo.Tesorería));
            listaNoDocentes.Add(new Administrativo("", "", 97612452, true, Convert.ToDateTime("1/1/2000  08:00 AM"), Convert.ToDateTime("1/1/2000  12:00 PM"), ECargo.Secretaría));
            listaNoDocentes.Add(new Administrativo("", "", 34595215, true, Convert.ToDateTime("1/1/2000  01:00 PM"), Convert.ToDateTime("1/1/2000  05:00 PM"), ECargo.Cocina));
            listaNoDocentes.Add(new Administrativo("", "", 67245585, true, Convert.ToDateTime("1/1/2000  01:00 PM"), Convert.ToDateTime("1/1/2000  05:00 PM"), ECargo.Secretaría));
            listaNoDocentes.Add(new Administrativo("", "", 12345564, true, Convert.ToDateTime("1/1/2000  08:00 AM"), Convert.ToDateTime("1/1/2000  12:00 PM"), ECargo.Cocina));
        }

        private void CreateListaAlumnos()
        {
            listaAlumnos.Add(new Alumno("Anscombe", "Den", 8543668, true, 384));
            listaAlumnos.Add(new Alumno("Tratton", "Elinor", 9776756, true, 811));
            listaAlumnos.Add(new Alumno("Inglesant", "Shandie", 3787793, true, 891));
            listaAlumnos.Add(new Alumno("Dracey", "Sumner", 5208846, true, 678));
            listaAlumnos.Add(new Alumno("Verey", "Nappy", 8089591, true, 659));
            listaAlumnos.Add(new Alumno("Eakin", "Kermie", 4053717, true, 437));
            listaAlumnos.Add(new Alumno("Kuschek", "Jade", 9656002, true, 231));
            listaAlumnos.Add(new Alumno("Martinon", "Kelsi", 5559989, true, 496));
            listaAlumnos.Add(new Alumno("Cudbird", "Dannie", 1995100, true, 571));
            listaAlumnos.Add(new Alumno("Scintsbury", "Darrin", 3897877, true, 463));
            listaAlumnos.Add(new Alumno("Southerell", "Garrott", 3080226, true, 353));
            listaAlumnos.Add(new Alumno("Boutwell", "Ingrim", 2624574, true, 763));
            listaAlumnos.Add(new Alumno("Durston", "Lenard", 9454133, true, 799));
            listaAlumnos.Add(new Alumno("Francomb", "Delores", 3515622, true, 828));
            listaAlumnos.Add(new Alumno("Frarey", "Olivia", 9022097, true, 643));
            listaAlumnos.Add(new Alumno("Cockrell", "Harmonie", 1446715, true, 624));
            listaAlumnos.Add(new Alumno("Sherrocks", "Burtie", 4799124, true, 539));
            listaAlumnos.Add(new Alumno("Gellett", "Guss", 5958621, true, 355));
            listaAlumnos.Add(new Alumno("Schoroder", "Hector", 5049708, true, 745));
            listaAlumnos.Add(new Alumno("Caller", "Spenser", 7101202, true, 598));
            listaAlumnos.Add(new Alumno("Biggs", "Hort", 7631061, true, 411));
            listaAlumnos.Add(new Alumno("Dodswell", "Rabi", 3272059, true, 235));
            listaAlumnos.Add(new Alumno("Aldus", "Lynnet", 2321904, true, 659));
            listaAlumnos.Add(new Alumno("Cubbon", "Pascal", 2675719, true, 371));
            listaAlumnos.Add(new Alumno("Syfax", "Tallulah", 6667452, true, 560));
            listaAlumnos.Add(new Alumno("Gomez", "Rhetta", 3131883, true, 624));
            listaAlumnos.Add(new Alumno("Fenimore", "Janeczka", 9777821, true, 599));
            listaAlumnos.Add(new Alumno("Mewrcik", "Gaby", 2937153, true, 412));
            listaAlumnos.Add(new Alumno("Byforth", "Wayne", 3596347, true, 740));
            listaAlumnos.Add(new Alumno("Greeson", "Elka", 8928119, true, 894));
            listaAlumnos.Add(new Alumno("Buzzing", "Maryanna", 9836766, true, 764));
            listaAlumnos.Add(new Alumno("Larrat", "Gillian", 6026536, true, 312));
            listaAlumnos.Add(new Alumno("Kesey", "Lisha", 3151883, true, 778));
            listaAlumnos.Add(new Alumno("Becket", "Shurlock", 3259366, true, 712));
            listaAlumnos.Add(new Alumno("Rapport", "Lisbeth", 5913221, true, 615));
            listaAlumnos.Add(new Alumno("Mapledorum", "Berny", 7820908, true, 528));
            listaAlumnos.Add(new Alumno("Marcinkowski", "Devondra", 2700100, true, 752));
            listaAlumnos.Add(new Alumno("Sandford", "Caro", 1463202, true, 643));
            listaAlumnos.Add(new Alumno("Iohananof", "Glenden", 1960648, true, 680));
            listaAlumnos.Add(new Alumno("Loftus", "Zandra", 5142875, true, 747));
            listaAlumnos.Add(new Alumno("Doohey", "Pooh", 2025241, true, 248));
            listaAlumnos.Add(new Alumno("Lassen", "Gonzales", 8086139, true, 253));
            listaAlumnos.Add(new Alumno("Berkeley", "Emmi", 8517471, true, 762));
            listaAlumnos.Add(new Alumno("Westgate", "Alana", 6137895, true, 629));
            listaAlumnos.Add(new Alumno("Abramsky", "Oona", 6710253, true, 405));
            listaAlumnos.Add(new Alumno("Cabbell", "Lynda", 2856972, true, 603));
            listaAlumnos.Add(new Alumno("Shefton", "Elyse", 9828976, true, 399));
            listaAlumnos.Add(new Alumno("Parsall", "Stafani", 1948589, true, 226));
            listaAlumnos.Add(new Alumno("Darker", "Elfrieda", 3913989, true, 615));
            listaAlumnos.Add(new Alumno("Guiduzzi", "Leone", 3810814, true, 248));
        }

        #endregion
    }
}
