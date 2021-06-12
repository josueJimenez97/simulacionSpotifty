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
    public partial class PerfilArtista : Form
    {
        private Principal principal;
        private Artista artista;
        public PerfilArtista(Principal principal, Artista artista)
        {
            this.principal = principal;
            this.artista = artista;
            InitializeComponent();
            lblNombreArtista.Text = artista.nombreArtista;
            if (artista.esArtistaSeguido(principal.usr.codUsuario))
                setColorSeguir();
            agregarAlbumes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            principal.abrirForm(new Home(principal));
        }

        private void agregarAlbumes()
        {
            List<Album> albumes = artista.getAlbumes();
            foreach(Album album in albumes)
            {
                panelAlbumes.Controls.Add(new PanelAlbum(album,principal,artista));
            }
        }

        private void btnSeguir_Click(object sender, EventArgs e)
        {
            if (!artista.esArtistaSeguido(principal.usr.codUsuario))
            {
                artista.seguirArtista(principal.usr.codUsuario);
                setColorSeguir();
            }
        }

        private void setColorSeguir()
        {
            this.btnSeguir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.btnSeguir.Text = "Siguiendo";
        }
    }
}
