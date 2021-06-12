using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace vistas
{
    public partial class PanelCancionAdd:Panel
    {
        private Cancion cancion;
        private Artista artista;
        private Principal principal;
        private Label lblReproducciones;
        private Button btnAgregar;
        private int codPlaylist;
        public PlaylistForm playlistForm;
        public PanelCancionAdd(Principal principal, Artista artista, Cancion cancion, int codPlayList)
        {
            this.principal = principal;
            this.artista = artista;
            this.cancion = cancion;
            this.codPlaylist = codPlayList;
            Label lblNro = new Label();
            lblNro.ForeColor = System.Drawing.Color.White;
            lblNro.Location = new System.Drawing.Point(15, 11);
            lblNro.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNro.AutoSize = true;// new System.Drawing.Size(59, 22);
            lblNro.Text = "";

            Label lblTitulo = new Label();
            lblTitulo.ForeColor = System.Drawing.Color.White;
            lblTitulo.Location = new System.Drawing.Point(70, 11);
            lblTitulo.Text = cancion.titulo;
            lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitulo.AutoSize = true;

            Label lblArtista = new Label();
            lblArtista.ForeColor = System.Drawing.Color.White;
            lblArtista.Location = new System.Drawing.Point(70, 26);
            lblArtista.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArtista.AutoSize = true;// new System.Drawing.Size(59, 22);
            lblArtista.Text = artista.nombreArtista;

            lblReproducciones = new Label();
            lblReproducciones.ForeColor = System.Drawing.Color.White;
            lblReproducciones.Location = new System.Drawing.Point(325, 11);
            lblReproducciones.Text = cancion.nroReproducciones.ToString();
            lblReproducciones.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblReproducciones.AutoSize = true;


            Label lblDuracion = new Label();
            lblDuracion.ForeColor = System.Drawing.Color.White;
            lblDuracion.Location = new System.Drawing.Point(485, 11);
            lblDuracion.Text = cancion.duracion.ToString();
            lblDuracion.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDuracion.AutoSize = true;

            btnAgregar = new Button();
            btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            btnAgregar.Location = new System.Drawing.Point(550, 11);
            //btnMeGustaMusica.Name = "btnMeGustaMusica";
            btnAgregar.Size = new System.Drawing.Size(65, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;

            if (cancion.existeEnPlaylist(codPlayList)) 
                setColorBtnAgregar();
           

            //btnMeGustaMusica.BackColor= System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            btnAgregar.Click += btnAgregar_Click;
            this.Controls.Add(lblNro);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblArtista);
            this.Controls.Add(lblReproducciones);
            this.Controls.Add(lblDuracion);
            this.Controls.Add(btnAgregar);

            this.Size = new System.Drawing.Size(629, 45);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            //this.Click += panelCancion_Click;
        }
       
        void btnAgregar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Agregando " + cancion.titulo);
            if (!cancion.existeEnPlaylist(codPlaylist))
            {
                if (cancion.agregarCancionPlaylist(codPlaylist))
                {
                    setColorBtnAgregar();
                    playlistForm.cancionesPlaylist();
                }
                else
                {
                    //MessageBox.Show("No se pudo dar me gusta : " + cancion.titulo);
                }
            }
        }

        private void setColorBtnAgregar()
        {
            btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            btnAgregar.Text = "Agregado";

        }


    }
}
