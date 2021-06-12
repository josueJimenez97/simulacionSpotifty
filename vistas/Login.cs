using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vistas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Si existe");
            /*Usuario usr = new Usuario();
            usr.nombreUsuario = "nombre";
            usr.codUsuario = 1;
            Principal principal = new Principal(usr);
            principal.login = this;
            principal.Show();
            this.Hide();*/
            if (txtBoxEmail.Text!="" && txtBoxPassword.Text != "")
            {
                Usuario usr = new Usuario();
                
                if (usr.existeUsuario(txtBoxEmail.Text, txtBoxPassword.Text))
                {   

                    //MessageBox.Show("Si existe");
                    Principal principal = new Principal(usr);
                    principal.login = this;
                    principal.Show();
                    this.Hide();
                    txtBoxEmail.Text = "";
                    txtBoxPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                    txtBoxEmail.Text = "";
                    txtBoxPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Complete los campos!");
            }
            
        }

       
        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            Registro registro = new Registro();
            registro.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
