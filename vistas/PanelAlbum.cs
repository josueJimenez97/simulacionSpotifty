using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vistas
{
    public partial class PanelAlbum: Panel
    {
        private Label nombreAlbum, anio;
        private Album album;
        private PictureBox foto;
        private Principal principal;
        private Artista artista;
        public PanelAlbum(Album album, Principal principal, Artista artista)
        {
            this.album = album;
            this.principal = principal;
            this.artista = artista;
            this.foto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)(foto)).BeginInit();
            this.foto.Image = global::vistas.Properties.Resources.imgAlbum;
            this.foto.Location = new System.Drawing.Point(36, 20);
            //this.foto.Name = "pictureBox1";
            this.foto.Size = new System.Drawing.Size(97, 105);
            this.foto.TabIndex = 0;
            this.foto.TabStop = false;
            this.nombreAlbum = new Label();
            this.nombreAlbum.AutoSize = true;
            this.nombreAlbum.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreAlbum.ForeColor = System.Drawing.SystemColors.Control;
            this.nombreAlbum.Location = new System.Drawing.Point(0, 135);
            this.nombreAlbum.Size = new System.Drawing.Size(59, 22);
            this.nombreAlbum.Text = album.titulo;

            this.anio = new Label();
            this.anio.AutoSize = true;
            this.anio.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anio.ForeColor = System.Drawing.SystemColors.Control;
            this.anio.Location = new System.Drawing.Point(0, 155);
            this.anio.Size = new System.Drawing.Size(59, 22);
            this.anio.Text = album.anioPublicacion.ToString();

            this.Controls.Add(foto);
            this.Controls.Add(nombreAlbum);
            this.Controls.Add(anio);
            this.Padding = new System.Windows.Forms.Padding(5);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Size = new System.Drawing.Size(170, 190);
            this.Click += panelAlbum_Click;

        }

        void panelAlbum_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("panel de musicas para el album " + album.titulo);
            principal.abrirForm(new CancionesAlbum(principal,artista,album));
        }
    }
}
