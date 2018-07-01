namespace CapaUsuario
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.PBXUsuario = new System.Windows.Forms.PictureBox();
            this.TXTNombreUsuario = new System.Windows.Forms.TextBox();
            this.TXTContraseña = new System.Windows.Forms.TextBox();
            this.PBXContraseña = new System.Windows.Forms.PictureBox();
            this.PNLUsuario = new System.Windows.Forms.Panel();
            this.LBLUincorrecto = new System.Windows.Forms.Label();
            this.PBXAceptar = new System.Windows.Forms.PictureBox();
            this.PBXH = new System.Windows.Forms.PictureBox();
            this.PBXPapas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBXUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXContraseña)).BeginInit();
            this.PNLUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBXAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXPapas)).BeginInit();
            this.SuspendLayout();
            // 
            // PBXUsuario
            // 
            this.PBXUsuario.Image = ((System.Drawing.Image)(resources.GetObject("PBXUsuario.Image")));
            this.PBXUsuario.Location = new System.Drawing.Point(30, 18);
            this.PBXUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.PBXUsuario.Name = "PBXUsuario";
            this.PBXUsuario.Size = new System.Drawing.Size(80, 36);
            this.PBXUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBXUsuario.TabIndex = 0;
            this.PBXUsuario.TabStop = false;
            // 
            // TXTNombreUsuario
            // 
            this.TXTNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNombreUsuario.Location = new System.Drawing.Point(58, 57);
            this.TXTNombreUsuario.Name = "TXTNombreUsuario";
            this.TXTNombreUsuario.Size = new System.Drawing.Size(156, 24);
            this.TXTNombreUsuario.TabIndex = 1;
            // 
            // TXTContraseña
            // 
            this.TXTContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTContraseña.Location = new System.Drawing.Point(58, 132);
            this.TXTContraseña.Name = "TXTContraseña";
            this.TXTContraseña.Size = new System.Drawing.Size(156, 24);
            this.TXTContraseña.TabIndex = 2;
            this.TXTContraseña.UseSystemPasswordChar = true;
            // 
            // PBXContraseña
            // 
            this.PBXContraseña.Image = global::CapaUsuario.Properties.Resources.contraseña;
            this.PBXContraseña.Location = new System.Drawing.Point(30, 90);
            this.PBXContraseña.Name = "PBXContraseña";
            this.PBXContraseña.Size = new System.Drawing.Size(118, 36);
            this.PBXContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBXContraseña.TabIndex = 3;
            this.PBXContraseña.TabStop = false;
            // 
            // PNLUsuario
            // 
            this.PNLUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PNLUsuario.BackColor = System.Drawing.Color.Transparent;
            this.PNLUsuario.Controls.Add(this.LBLUincorrecto);
            this.PNLUsuario.Controls.Add(this.PBXAceptar);
            this.PNLUsuario.Controls.Add(this.PBXContraseña);
            this.PNLUsuario.Controls.Add(this.TXTContraseña);
            this.PNLUsuario.Controls.Add(this.TXTNombreUsuario);
            this.PNLUsuario.Controls.Add(this.PBXUsuario);
            this.PNLUsuario.Location = new System.Drawing.Point(508, 350);
            this.PNLUsuario.Name = "PNLUsuario";
            this.PNLUsuario.Size = new System.Drawing.Size(292, 225);
            this.PNLUsuario.TabIndex = 5;
            // 
            // LBLUincorrecto
            // 
            this.LBLUincorrecto.AutoSize = true;
            this.LBLUincorrecto.Location = new System.Drawing.Point(63, 212);
            this.LBLUincorrecto.Name = "LBLUincorrecto";
            this.LBLUincorrecto.Size = new System.Drawing.Size(229, 13);
            this.LBLUincorrecto.TabIndex = 7;
            this.LBLUincorrecto.Text = "Datos incorrectos, por favor reingrese los datos";
            this.LBLUincorrecto.Visible = false;
            this.LBLUincorrecto.Click += new System.EventHandler(this.LBLUincorrecto_Click);
            // 
            // PBXAceptar
            // 
            this.PBXAceptar.Image = global::CapaUsuario.Properties.Resources.ACEPTAR;
            this.PBXAceptar.Location = new System.Drawing.Point(124, 162);
            this.PBXAceptar.Name = "PBXAceptar";
            this.PBXAceptar.Size = new System.Drawing.Size(90, 30);
            this.PBXAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBXAceptar.TabIndex = 6;
            this.PBXAceptar.TabStop = false;
            this.PBXAceptar.Click += new System.EventHandler(this.PBXAceptar_Click);
            // 
            // PBXH
            // 
            this.PBXH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PBXH.Image = ((System.Drawing.Image)(resources.GetObject("PBXH.Image")));
            this.PBXH.Location = new System.Drawing.Point(-289, 308);
            this.PBXH.Name = "PBXH";
            this.PBXH.Size = new System.Drawing.Size(512, 474);
            this.PBXH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBXH.TabIndex = 15;
            this.PBXH.TabStop = false;
            // 
            // PBXPapas
            // 
            this.PBXPapas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PBXPapas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PBXPapas.ErrorImage = null;
            this.PBXPapas.Image = ((System.Drawing.Image)(resources.GetObject("PBXPapas.Image")));
            this.PBXPapas.InitialImage = null;
            this.PBXPapas.Location = new System.Drawing.Point(1051, 341);
            this.PBXPapas.Name = "PBXPapas";
            this.PBXPapas.Size = new System.Drawing.Size(370, 347);
            this.PBXPapas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBXPapas.TabIndex = 16;
            this.PBXPapas.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaUsuario.Properties.Resources.LOGIN;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.PBXPapas);
            this.Controls.Add(this.PBXH);
            this.Controls.Add(this.PNLUsuario);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBXUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXContraseña)).EndInit();
            this.PNLUsuario.ResumeLayout(false);
            this.PNLUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBXAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXPapas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBXUsuario;
        private System.Windows.Forms.TextBox TXTNombreUsuario;
        private System.Windows.Forms.TextBox TXTContraseña;
        private System.Windows.Forms.PictureBox PBXContraseña;
        private System.Windows.Forms.Panel PNLUsuario;
        private System.Windows.Forms.PictureBox PBXAceptar;
        private System.Windows.Forms.PictureBox PBXH;
        private System.Windows.Forms.PictureBox PBXPapas;
        private System.Windows.Forms.Label LBLUincorrecto;
    }
}