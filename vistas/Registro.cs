using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vistas
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            radioBtnMasculino.Checked = true;
            System.Object[] paises = new System.Object[] { "Argentina","Bolivia","Peru","Colombia","Chile","Brasil"};
            paisesBox.Items.AddRange(paises);
            paisesBox.SelectedItem = paises[1];
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void labelCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            if (esValido())
            {
                if (!Usuario.emailRegistrado(txtCorreo.Text))
                {
                    Usuario usuario = new Usuario();
                    usuario.email = txtCorreo.Text;
                    usuario.nombreUsuario = txtNombreUsuario.Text;
                    usuario.contrasenia = txtContrasenia.Text;
                    usuario.sexo = getSexo();
                    usuario.fechaNac = fechaNac.Value.ToString("dd/MM/yyyy");
                    usuario.pais = paisesBox.SelectedItem.ToString();
                    if (Usuario.registrarUsuario(usuario))
                    {
                        MessageBox.Show("Usuario creado correctamente");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al crear el usuario");
                    }
                }
                else
                {
                    MessageBox.Show("Correo electronico ya registrado!");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
        }
        private bool esValido()
        {
            return txtContrasenia.Text != "" && txtCorreo.Text != "" && txtNombreUsuario.Text!=""; 
        }

        private char getSexo()
        {
            char sexo = ' ';
            if (radioBtnFemenino.Checked)
                sexo = 'F';
            
            if (radioBtnMasculino.Checked)
                sexo = 'M';

            if (radioBtnOtro.Checked)
                sexo = 'O';
            return sexo;
        }
    }
}
