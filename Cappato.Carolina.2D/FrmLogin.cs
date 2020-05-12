using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Cappato.Carolina._2D
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            //harcodeo usuario y contraseña
            txtUsername.Text = "admin";
            txtPassword.Text = "admin";
        }

        //Establezco valores de usuario y contraseña
        const string usuario = "admin";
        const string contrasenia = "admin";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != usuario || txtPassword.Text != contrasenia) // Valido que usuario y contraseña no sean distintos de los establecidos
            {
                MessageBox.Show("Ingrese usuario y contraseña para ingresar");
            }
            else
            {
                this.Hide();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
