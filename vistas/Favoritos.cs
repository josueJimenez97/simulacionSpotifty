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
    public partial class Favoritos : Form
    {
        private Principal principal;
        public Favoritos(Principal principal)
        {
            this.principal = principal;
            InitializeComponent();
        }

        private void Favoritos_Load(object sender, EventArgs e)
        {
            albumesFavoritos();
            cancionesFavoritas();
        }
        private void albumesFavoritos()
        {
            List<Album> albumes = Album.getFavoritos(principal.usr.codUsuario);
            foreach(Album album in albumes)
            {
                panelAlbumesFav.Controls.Add(new PanelAlbum(album, principal, Artista.getArtista(album.codArtista)));
            }
        }
        private void cancionesFavoritas()
        {
            
            List<Cancion> canciones = Cancion.getFavoritos(principal.usr.codUsuario);
            int nro = 1;
            foreach (Cancion cancion in canciones)
            {
                Album a = Album.getAlbum(cancion.codAlbum);
                panelCancionesFav.Controls.Add(new PanelCancion(principal, Artista.getArtista(a.codArtista), cancion, nro));
                nro++;
            }

        }
    }
}
