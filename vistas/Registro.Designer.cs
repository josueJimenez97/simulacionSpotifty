
namespace vistas
{
    partial class Registro
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
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaNac = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioBtnMasculino = new System.Windows.Forms.RadioButton();
            this.radioBtnFemenino = new System.Windows.Forms.RadioButton();
            this.radioBtnOtro = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.paisesBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCerrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.White;
            this.txtCorreo.Location = new System.Drawing.Point(51, 119);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(200, 21);
            this.txtCorreo.TabIndex = 0;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNombreUsuario.Location = new System.Drawing.Point(51, 167);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(200, 21);
            this.txtNombreUsuario.TabIndex = 1;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.ForeColor = System.Drawing.SystemColors.Info;
            this.txtContrasenia.Location = new System.Drawing.Point(51, 215);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(200, 21);
            this.txtContrasenia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(48, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "correo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(48, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "nombre de usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(48, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "contraseña";
            // 
            // fechaNac
            // 
            this.fechaNac.Location = new System.Drawing.Point(51, 264);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(200, 20);
            this.fechaNac.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(48, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "fecha nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(48, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "sexo";
            // 
            // radioBtnMasculino
            // 
            this.radioBtnMasculino.AutoSize = true;
            this.radioBtnMasculino.BackColor = System.Drawing.Color.Black;
            this.radioBtnMasculino.ForeColor = System.Drawing.SystemColors.Control;
            this.radioBtnMasculino.Location = new System.Drawing.Point(51, 313);
            this.radioBtnMasculino.Name = "radioBtnMasculino";
            this.radioBtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioBtnMasculino.TabIndex = 9;
            this.radioBtnMasculino.TabStop = true;
            this.radioBtnMasculino.Text = "Masculino";
            this.radioBtnMasculino.UseVisualStyleBackColor = false;
            // 
            // radioBtnFemenino
            // 
            this.radioBtnFemenino.AutoSize = true;
            this.radioBtnFemenino.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioBtnFemenino.Location = new System.Drawing.Point(130, 313);
            this.radioBtnFemenino.Name = "radioBtnFemenino";
            this.radioBtnFemenino.Size = new System.Drawing.Size(71, 17);
            this.radioBtnFemenino.TabIndex = 10;
            this.radioBtnFemenino.TabStop = true;
            this.radioBtnFemenino.Text = "Femenino";
            this.radioBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // radioBtnOtro
            // 
            this.radioBtnOtro.AutoSize = true;
            this.radioBtnOtro.ForeColor = System.Drawing.SystemColors.Control;
            this.radioBtnOtro.Location = new System.Drawing.Point(207, 313);
            this.radioBtnOtro.Name = "radioBtnOtro";
            this.radioBtnOtro.Size = new System.Drawing.Size(45, 17);
            this.radioBtnOtro.TabIndex = 11;
            this.radioBtnOtro.TabStop = true;
            this.radioBtnOtro.Text = "Otro";
            this.radioBtnOtro.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(51, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pais";
            // 
            // paisesBox
            // 
            this.paisesBox.FormattingEnabled = true;
            this.paisesBox.Location = new System.Drawing.Point(97, 344);
            this.paisesBox.Name = "paisesBox";
            this.paisesBox.Size = new System.Drawing.Size(121, 21);
            this.paisesBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(81, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "REGISTRO en RedMus";
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.btnRegistrarUsuario.FlatAppearance.BorderSize = 0;
            this.btnRegistrarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(53, 371);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(198, 23);
            this.btnRegistrarUsuario.TabIndex = 15;
            this.btnRegistrarUsuario.Text = "crear cuenta";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = false;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(54, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ya tienes una cuenta? ";
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.BackColor = System.Drawing.Color.Black;
            this.linkLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.linkLogin.LinkColor = System.Drawing.Color.Aqua;
            this.linkLogin.Location = new System.Drawing.Point(177, 411);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(81, 15);
            this.linkLogin.TabIndex = 17;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Iniciar Sesion";
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::vistas.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(120, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 63);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // labelCerrar
            // 
            this.labelCerrar.AutoSize = true;
            this.labelCerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCerrar.Location = new System.Drawing.Point(285, 9);
            this.labelCerrar.Name = "labelCerrar";
            this.labelCerrar.Size = new System.Drawing.Size(14, 13);
            this.labelCerrar.TabIndex = 19;
            this.labelCerrar.Text = "X";
            this.labelCerrar.Click += new System.EventHandler(this.labelCerrar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(311, 445);
            this.Controls.Add(this.labelCerrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLogin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnRegistrarUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.paisesBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioBtnOtro);
            this.Controls.Add(this.radioBtnFemenino);
            this.Controls.Add(this.radioBtnMasculino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fechaNac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.txtCorreo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaNac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioBtnMasculino;
        private System.Windows.Forms.RadioButton radioBtnFemenino;
        private System.Windows.Forms.RadioButton radioBtnOtro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox paisesBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCerrar;
    }
}