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
    public partial class Buscar : Form
    {
        private Principal principal;
        private Panel miPanel;
        public Buscar(Principal principal)
        {
            this.principal = principal;
            InitializeComponent();
            Label label4 = new System.Windows.Forms.Label();
            Label label3 = new System.Windows.Forms.Label();
            Label label1 = new System.Windows.Forms.Label();
            Label label2 = new System.Windows.Forms.Label();

            miPanel = new Panel();
            miPanel.Controls.Add(label4);
            miPanel.Controls.Add(label3);
            miPanel.Controls.Add(label1);
            miPanel.Controls.Add(label2);
            miPanel.Location = new System.Drawing.Point(3, 3);
            miPanel.Name = "panel1";
            miPanel.Size = new System.Drawing.Size(629, 39);
            miPanel.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.SystemColors.Control;
            label4.Location = new System.Drawing.Point(470, 11);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(79, 16);
            label4.TabIndex = 5;
            label4.Text = "DURACION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(282, 11);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(135, 16);
            label3.TabIndex = 2;
            label3.Text = "REPRODUCCIONES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(120, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 16);
            label1.TabIndex = 0;
            label1.Text = "TITULO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(10, 11);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 16);
            label2.TabIndex = 1;
            label2.Text = "NRO";
        }

        private Panel getPanel(string text)
        {
            Panel panel = new Panel();
            Label lblSubTitulo = new Label();
            lblSubTitulo.Text = text;//255, 185, 0
            lblSubTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            lblSubTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSubTitulo.AutoSize = true;

            panel.Size= new System.Drawing.Size(655, 30);
            panel.Controls.Add(lblSubTitulo);
            //panel.BackColor = Color.Aqua;
            return panel;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            panelResultado.Controls.Clear();
            string palabraBuscar = txtBoxBuscar.Text;
            if (palabraBuscar != "")
            {
                palabraBuscar = palabraBuscar.ToLower();
                resultadosArtistas(palabraBuscar);
                resultadosAlbumes(palabraBuscar);
                resultadosCanciones(palabraBuscar);

            }
            else
            {
                MessageBox.Show("Escriba algo!");
            }

        }
        private void resultadosArtistas(string pal)
        {
            List<Artista> artistas = Artista.buscarArtista(pal);
            if (artistas.Count != 0)
            {
                panelResultado.Controls.Add(getPanel("Artistas"));
                foreach (Artista artista in artistas)
                    panelResultado.Controls.Add(new PanelArtista(artista, principal));
                
            }
            else
            {
                panelResultado.Controls.Add(getPanel("Artistas: SIN RESULTADOS DE BUSQUEDA :("));
            }
        }

        private void resultadosAlbumes(string pal)
        {
            List<Album> albumes = Album.buscarAlbum(pal);
            if (albumes.Count != 0)
            {
                panelResultado.Controls.Add(getPanel("Albumes"));
                foreach (Album album in albumes)

                    panelResultado.Controls.Add(new PanelAlbum(album,principal,Artista.getArtista(album.codArtista)));

            }
            else
            {
                panelResultado.Controls.Add(getPanel("Albumes: SIN RESULTADOS DE BUSQUEDA :("));
            }

        }

        private void resultadosCanciones(string pal)
        {
            List<Cancion> canciones = Cancion.buscarCanciones(pal);
            if(canciones.Count != 0)
            {
                panelResultado.Controls.Add(getPanel("Canciones"));
                panelResultado.Controls.Add(miPanel);
                int nro = 1;
                foreach(Cancion cancion in canciones)
                {
                    Album al = Album.getAlbum(cancion.codAlbum);
                    panelResultado.Controls.Add(new PanelCancion(principal, Artista.getArtista(al.codArtista), cancion, nro));
                    nro++;
                }
            }
            else
            {

                panelResultado.Controls.Add(getPanel("Canciones: SIN RESULTADOS DE BUSQUEDA :("));
            }
        }
    }
}
