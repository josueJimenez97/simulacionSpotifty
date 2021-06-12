
namespace vistas
{
    partial class PerfilArtista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombreArtista = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnSeguir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAlbumes = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblNombreArtista
            // 
            this.lblNombreArtista.AutoSize = true;
            this.lblNombreArtista.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArtista.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreArtista.Location = new System.Drawing.Point(27, 34);
            this.lblNombreArtista.Name = "lblNombreArtista";
            this.lblNombreArtista.Size = new System.Drawing.Size(128, 36);
            this.lblNombreArtista.TabIndex = 1;
            this.lblNombreArtista.Text = "Nombre";
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVolver.Location = new System.Drawing.Point(480, 34);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(146, 35);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Artistas Seguidos";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnSeguir
            // 
            this.btnSeguir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSeguir.Location = new System.Drawing.Point(33, 82);
            this.btnSeguir.Name = "btnSeguir";
            this.btnSeguir.Size = new System.Drawing.Size(75, 33);
            this.btnSeguir.TabIndex = 3;
            this.btnSeguir.Text = "Seguir";
            this.btnSeguir.UseVisualStyleBackColor = true;
            this.btnSeguir.Click += new System.EventHandler(this.btnSeguir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(28, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Albumes";
            // 
            // panelAlbumes
            // 
            this.panelAlbumes.AutoScroll = true;
            this.panelAlbumes.Location = new System.Drawing.Point(33, 174);
            this.panelAlbumes.Name = "panelAlbumes";
            this.panelAlbumes.Size = new System.Drawing.Size(593, 275);
            this.panelAlbumes.TabIndex = 5;
            // 
            // PerfilArtista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(705, 451);
            this.Controls.Add(this.panelAlbumes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSeguir);
            this.Controls.Add(this.lblNombreArtista);
            this.Controls.Add(this.btnVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PerfilArtista";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombreArtista;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSeguir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel panelAlbumes;
    }
}