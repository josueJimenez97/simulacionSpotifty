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
    public partial class Home : Form
    {
        private Principal principal;
        public Home(Principal principal)
        {
            this.principal = principal;
            InitializeComponent();
            agregarArtistasSeguidos();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void agregarArtistasSeguidos()
        {
            List<Artista> artistas = Artista.getArtistasSeguidos(principal.usr.codUsuario);
            foreach(Artista a in artistas)
            {
                panelArtistas.Controls.Add(new PanelArtista(a,principal));
            }

        }

        private void panelArtista1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
