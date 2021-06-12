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
    public partial class CancionesAlbum : Form
    {
        private Principal principal;
        private Artista artista;
        private Album album;
        public CancionesAlbum(Principal principal, Artista artista,Album album)
        {
            this.principal = principal;
            this.artista = artista;
            this.album = album;
            InitializeComponent();
            nombreAlbum.Text = album.titulo;
            if (album.esAlbumFavorito(principal.usr.codUsuario))
                setColorBtnMeGustaAlbum();
        }

        private void CancionesAlbum_Load(object sender, EventArgs e)
        {
            
            List<Cancion> canciones = album.getCancionesAlbum();
            int cont = 1;
            foreach(Cancion cancion in canciones)
            {
                panelMusicas.Controls.Add(new PanelCancion(principal,artista,cancion,cont));
                cont++;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            principal.abrirForm(new PerfilArtista(principal, artista));
        }

        private void btnMeGustaAlbum_Click(object sender, EventArgs e)
        {
            if(!album.esAlbumFavorito(principal.usr.codUsuario))
            {
                album.darMegusta(principal.usr.codUsuario);
                setColorBtnMeGustaAlbum();
            }
        }
        private void setColorBtnMeGustaAlbum()
        {
            
            this.btnMeGustaAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.btnMeGustaAlbum.Text = "Te gusta";
            
        }
    }
}
