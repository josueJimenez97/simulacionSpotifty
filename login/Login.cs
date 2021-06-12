using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Registro registroForm = new Registro();
            registroForm.ShowDialog();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("ingresarrr con: "+textBoxCorreo.Text+" y pass: "+textBoxContrasenia.Text);
        }
    }
}
