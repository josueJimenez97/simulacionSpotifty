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
    public partial class Principal : Form
    {
        public Login login;
        public Usuario usr;
        public Principal(Usuario usuario)
        {
            this.usr = usuario;
            login = null;
            InitializeComponent();
            panelOpciones.Visible = false;
            btnUserName.Text = usr.nombreUsuario;
            //MessageBox.Show("es premium: " + usr.premium);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login != null)
            {
                login.Show();
                this.Dispose();
            }
        }

        private void lblCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUserName_Click(object sender, EventArgs e)
        {
            panelOpciones.Visible = !panelOpciones.Visible;
        }
        private Form formActivo = null;
        public void abrirForm(Form miForm)
        {
            if (formActivo != null)
                formActivo.Close();

            formActivo = miForm;
            miForm.TopLevel = false;
            miForm.FormBorderStyle = FormBorderStyle.None;
            miForm.Dock = DockStyle.Fill;
            panelCentral.Controls.Add(miForm);
            panelCentral.Tag = miForm;
            miForm.BringToFront();
            miForm.Show();

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirForm(new Home(this));
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            abrirForm(new Home(this));
            actualizarPlaylists();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            abrirForm(new Buscar(this));
        }

        private void btnCrearPlaylist_Click(object sender, EventArgs e)
        {
            abrirForm(new CrearPlaylist(this));
        }

        private void btnSerPremium_Click(object sender, EventArgs e)
        {

        }
        public void actualizarPlaylists()
        {
            panelPlaylists.Controls.Clear();
            List<Playlist> playlists = Playlist.getPlaylistUsuario(usr.codUsuario);

            foreach(Playlist playlist in playlists)
            {
                panelPlaylists.Controls.Add(new ButtonPlayList(playlist, this));

            }

        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            abrirForm(new Favoritos(this));
        }
    }
}
