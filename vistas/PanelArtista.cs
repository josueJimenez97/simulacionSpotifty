using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace vistas
{
    public partial class PanelArtista: Panel
    {
        private Label nombreArtista;
        private Artista artista;
        private PictureBox foto;
        public Panel panelPrincipal;
        private Principal principal;
        public PanelArtista(Artista artista, Principal principal)
        {
            this.principal = principal;
            this.artista = artista;
            this.foto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)(foto)).BeginInit();
            this.foto.Image = global::vistas.Properties.Resources.imgFoto;
            this.foto.Location = new System.Drawing.Point(51, 20);
            //this.foto.Name = "pictureBox1";
            this.foto.Size = new System.Drawing.Size(97, 97);
            this.foto.TabIndex = 0;
            this.foto.TabStop = false;
            this.nombreArtista = new Label();
            this.nombreArtista.AutoSize = true;
            this.nombreArtista.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreArtista.ForeColor = System.Drawing.SystemColors.Control;
            this.nombreArtista.Location = new System.Drawing.Point(0, 150);
            //this.label1.Name = "label1";
            this.nombreArtista.Size = new System.Drawing.Size(59, 22);
            //this.label1.TabIndex = 1;
            this.nombreArtista.Text = artista.nombreArtista;
            this.Controls.Add(foto);
            this.Controls.Add(nombreArtista);
            this.Padding= new System.Windows.Forms.Padding(5);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Size = new System.Drawing.Size(200, 200);
            this.Click += panelArtista_Click;
        }

        void panelArtista_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("un click xd en "+ artista.nombreArtista);
            principal.abrirForm(new PerfilArtista(principal,artista));
        }
    }
}
