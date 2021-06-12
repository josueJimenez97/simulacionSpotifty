using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace vistas
{
    public partial class PanelCancion: Panel
    {
        private Cancion cancion;
        private Artista artista;
        private Principal principal;
        private Label lblReproducciones;
        private Button btnMeGustaMusica;
        public PanelCancion(Principal principal, Artista artista,Cancion cancion,int nro)
        {
            this.principal = principal;
            this.artista = artista;
            this.cancion = cancion;

            Label lblNro = new Label() ;
            lblNro.ForeColor = System.Drawing.Color.White;
            lblNro.Location = new System.Drawing.Point(15, 11);
            lblNro.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNro.AutoSize = true;// new System.Drawing.Size(59, 22);
            lblNro.Text = nro.ToString();

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

            btnMeGustaMusica = new Button();
            btnMeGustaMusica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMeGustaMusica.ForeColor = System.Drawing.SystemColors.Control;
            btnMeGustaMusica.Location = new System.Drawing.Point(550, 11);
            btnMeGustaMusica.Name = "btnMeGustaMusica";
            btnMeGustaMusica.Size = new System.Drawing.Size(65, 23);
            btnMeGustaMusica.TabIndex = 3;
            btnMeGustaMusica.Font= new System.Drawing.Font("Microsoft YaHei", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnMeGustaMusica.Text = "Me gusta";
            btnMeGustaMusica.UseVisualStyleBackColor = true;
            if (cancion.esCancionFavorita(principal.usr.codUsuario))
                setColorBtnMeGusta();
            //btnMeGustaMusica.BackColor= System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            btnMeGustaMusica.Click += btnMeGustaMusica_Click;
            this.Controls.Add(lblNro);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblArtista);
            this.Controls.Add(lblReproducciones);
            this.Controls.Add(lblDuracion);
            this.Controls.Add(btnMeGustaMusica);

            this.Size = new System.Drawing.Size(629, 45);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Click += panelCancion_Click;  
        }
        void panelCancion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reproduciendo "+ cancion.titulo);
            cancion.reproducir();
            lblReproducciones.Text = cancion.nroReproducciones + "";
        }
        void btnMeGustaMusica_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Me gusta " + cancion.titulo);
            if (!cancion.esCancionFavorita(principal.usr.codUsuario))
            {
                if (cancion.darMeGusta(principal.usr.codUsuario))
                {
                    setColorBtnMeGusta();
                }
                else
                {
                    //MessageBox.Show("No se pudo dar me gusta : " + cancion.titulo);
                }
            }
        }

        private void setColorBtnMeGusta()
        {
            btnMeGustaMusica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            btnMeGustaMusica.Text = "Te gusta";

        }

    }
}
