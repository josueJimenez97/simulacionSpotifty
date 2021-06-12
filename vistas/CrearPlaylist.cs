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
    public partial class CrearPlaylist : Form
    {
        private Principal principal;
        public CrearPlaylist(Principal principal)
        {
            this.principal = principal;
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string titulo = txtBoxTitulo.Text;
            if (titulo != "")
            {
                if (Playlist.crearPlaylist(titulo, principal.usr.codUsuario))
                {
                    MessageBox.Show("Playlist creada!");
                    principal.actualizarPlaylists();
                    //principal.abrirForm();
                    txtBoxTitulo.Text = "";

                }
                else
                {
                    MessageBox.Show("Error al crear la Playlist!");

                }
            }
            else
            {
                MessageBox.Show("Escriba algo!");
            }
        }
    }
}
