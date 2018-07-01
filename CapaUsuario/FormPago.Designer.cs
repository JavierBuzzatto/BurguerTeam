namespace CapaUsuario
{
    partial class FormPago
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
            this.PBCobra = new System.Windows.Forms.PictureBox();
            this.PTarjeta = new System.Windows.Forms.Panel();
            this.pedido = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PEfectivo = new System.Windows.Forms.Panel();
            this.pedido2 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PCruz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBCobra)).BeginInit();
            this.PTarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PEfectivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedido2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCruz)).BeginInit();
            this.SuspendLayout();
            // 
            // PBCobra
            // 
            this.PBCobra.Image = global::CapaUsuario.Properties.Resources.cobranza;
            this.PBCobra.Location = new System.Drawing.Point(2, -3);
            this.PBCobra.Name = "PBCobra";
            this.PBCobra.Size = new System.Drawing.Size(1285, 142);
            this.PBCobra.TabIndex = 0;
            this.PBCobra.TabStop = false;
            // 
            // PTarjeta
            // 
            this.PTarjeta.Controls.Add(this.pedido);
            this.PTarjeta.Controls.Add(this.pictureBox1);
            this.PTarjeta.Controls.Add(this.textBox4);
            this.PTarjeta.Controls.Add(this.textBox3);
            this.PTarjeta.Controls.Add(this.textBox2);
            this.PTarjeta.Controls.Add(this.textBox1);
            this.PTarjeta.Controls.Add(this.label3);
            this.PTarjeta.Controls.Add(this.label2);
            this.PTarjeta.Controls.Add(this.label1);
            this.PTarjeta.Location = new System.Drawing.Point(482, 192);
            this.PTarjeta.Name = "PTarjeta";
            this.PTarjeta.Size = new System.Drawing.Size(456, 420);
            this.PTarjeta.TabIndex = 1;
            this.PTarjeta.Visible = false;
            // 
            // pedido
            // 
            this.pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedido.Location = new System.Drawing.Point(17, 13);
            this.pedido.Name = "pedido";
            this.pedido.Size = new System.Drawing.Size(411, 124);
            this.pedido.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaUsuario.Properties.Resources.COBRAR;
            this.pictureBox1.Location = new System.Drawing.Point(166, 329);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(17, 303);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(206, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(123, 255);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Año";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 255);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Mes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "VENCIMIENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "CODIGO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "NUMERO";
            // 
            // PEfectivo
            // 
            this.PEfectivo.Controls.Add(this.pedido2);
            this.PEfectivo.Controls.Add(this.pictureBox2);
            this.PEfectivo.Location = new System.Drawing.Point(482, 195);
            this.PEfectivo.Name = "PEfectivo";
            this.PEfectivo.Size = new System.Drawing.Size(456, 417);
            this.PEfectivo.TabIndex = 2;
            this.PEfectivo.Visible = false;
            // 
            // pedido2
            // 
            this.pedido2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedido2.Location = new System.Drawing.Point(18, 13);
            this.pedido2.Name = "pedido2";
            this.pedido2.Size = new System.Drawing.Size(422, 236);
            this.pedido2.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaUsuario.Properties.Resources.COBRAR;
            this.pictureBox2.Location = new System.Drawing.Point(299, 255);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PCruz
            // 
            this.PCruz.Image = global::CapaUsuario.Properties.Resources.CRUZ;
            this.PCruz.Location = new System.Drawing.Point(946, 140);
            this.PCruz.Name = "PCruz";
            this.PCruz.Size = new System.Drawing.Size(45, 50);
            this.PCruz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCruz.TabIndex = 3;
            this.PCruz.TabStop = false;
            this.PCruz.Click += new System.EventHandler(this.PCruz_Click);
            // 
            // FormPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 741);
            this.Controls.Add(this.PCruz);
            this.Controls.Add(this.PBCobra);
            this.Controls.Add(this.PTarjeta);
            this.Controls.Add(this.PEfectivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPago";
            this.Text = "FormPago";
            ((System.ComponentModel.ISupportInitialize)(this.PBCobra)).EndInit();
            this.PTarjeta.ResumeLayout(false);
            this.PTarjeta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PEfectivo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pedido2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCruz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBCobra;
        private System.Windows.Forms.Panel PTarjeta;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PEfectivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView pedido;
        private System.Windows.Forms.DataGridView pedido2;
        private System.Windows.Forms.PictureBox PCruz;
    }
}