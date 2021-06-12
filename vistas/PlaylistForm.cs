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
    public partial class PlaylistForm : Form
    {
        private Principal principal;
        private Playlist playlist;
        public PlaylistForm(Principal principal, Playlist playlist)
        {
            this.principal = principal;
            this.playlist = playlist;
            InitializeComponent();
            this.lblTitulo.Text = playlist.titulo;  
        }

        private void PlaylistForm_Load(object sender, EventArgs e)
        {
            cancionesPlaylist();
        }

        public void cancionesPlaylist()
        {
            panelCanciones.Controls.Clear();
            List<Cancion> canciones = playlist.getCanciones();
            int nro = 1;
            foreach(Cancion cancion in canciones)
            {
                Album a = Album.getAlbum(cancion.codAlbum);
                panelCanciones.Controls.Add(new PanelCancion(principal,Artista.getArtista(a.codArtista),cancion,nro));
                nro++;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            panelAgregarCanciones.Controls.Clear();
            string texto = textBoxCancion.Text;
            if (texto != "")
            {
                List<Cancion> canciones = Cancion.buscarCanciones(texto);
                foreach(Cancion cancion in canciones)
                {

                    Album a = Album.getAlbum(cancion.codAlbum);
                    PanelCancionAdd panel= new PanelCancionAdd(principal, Artista.getArtista(a.codArtista),cancion,playlist.codPlaylist);
                    panel.playlistForm = this;
                    panelAgregarCanciones.Controls.Add(panel);
                }

            }
            else
            {
                MessageBox.Show("Escriba algo!");
            }
        }
    }
}
