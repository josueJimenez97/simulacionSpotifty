using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace vistas
{
    public partial class ButtonPlayList:Button
    {
        private Playlist playlist;
        private Principal principal;
        public ButtonPlayList(Playlist playlist, Principal principal)
        {
            this.playlist = playlist;
            this.principal = principal;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Location = new System.Drawing.Point(3, 3);
            this.Name = playlist.titulo;
            this.Size = new System.Drawing.Size(191, 23);
            this.TabIndex = 0;
            this.Text = playlist.titulo;
            this.UseVisualStyleBackColor = false;
            this.Click += ButtonPlaylist_Click;
        }

        void ButtonPlaylist_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Viendo " + playlist.titulo);
            principal.abrirForm(new PlaylistForm(principal,playlist));
        }
    }
}
