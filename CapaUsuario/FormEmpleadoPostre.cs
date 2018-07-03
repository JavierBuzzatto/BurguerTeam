using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using CapaNegocio;
namespace CapaUsuario
{
    public partial class FormEmpleadoPostre : Form
    {
        FontFamily ff;
        Font font;
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
        private void CargoPrivateFontCollection()
        {

            byte[] fontArray = CapaUsuario.Properties.Resources.Insanibc;
            int dataLength = CapaUsuario.Properties.Resources.Insanibc.Length;



            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);
            Marshal.Copy(fontArray, 0, ptrData, dataLength);


            uint cFonts = 0;
            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddMemoryFont(ptrData, dataLength);

            Marshal.FreeCoTaskMem(ptrData);

            ff = pfc.Families[0];
            font = new Font(ff, 15f, FontStyle.Bold);
        }

        public FormEmpleadoPostre()
        {
            InitializeComponent();
            CargoPrivateFontCollection();
            foreach (Control x in Controls)
            {
                if (x is Panel)
                    foreach (Control a in x.Controls)
                        if (a is PictureBox)
                        {
                            a.Size = new Size(a.Height - 5, a.Width - 5);
                        }
            }
            foreach (Control x in Controls)
            {
                if (x is Panel)
                {
                    foreach (Control a in x.Controls)
                    {
                        if (a is Panel)
                        {
                            foreach (Control z in a.Controls)
                            {
                                z.Select();
                            }
                            foreach (Control z in a.Controls)
                            {
                               
                                if (z.Text.Equals("MEDIANO"))
                                {
                                    z.Select();
                                }
                            }
                        }
                    }
                }
                //MessageBox.Show(radioButton79.Text);
            }
        }

        private void BTNVolver_Click_1(object sender, EventArgs e) //EL BOTON DE LA CRUZ
        {
            PPostre.Visible = true;
            PCono.Visible = false;
            PConoR.Visible = false;
            PSundae.Visible = false;
            PCucu.Visible = false;
            panel2.Visible = false; //PKMix


        }
        
        private void PBCono_Click(object sender, EventArgs e)
        {
            PCono.Visible = true;
            PPostre.Visible = false;
        }

        private void PBConoR_Click(object sender, EventArgs e)
        {
            PConoR.Visible = true;
            PPostre.Visible = false;
        }

        private void PBSundae_Click(object sender, EventArgs e)
        {
            PSundae.Visible = true;
            PPostre.Visible = false;
        }

        private void PBCucuruchon_Click(object sender, EventArgs e)
        {
            PCucu.Visible = true;
            PPostre.Visible = false;
        }

        private void PBKMix_Click(object sender, EventArgs e)
        {
            panel2.Visible = true; //PKMix, no deja cambiar el nombre al panel asi que le puse el nombre original
            PPostre.Visible = false;
        }
        
        private void CargoEtiqueta(Font font, Control x)
        {
            float size = 11f;
            FontStyle fontStyle = FontStyle.Regular;

            x.Font = new Font(ff, x.Font.Size, fontStyle);

        }

        private void FormEmpleadoPostre_Load(object sender, EventArgs e)
        {
            pictureBoxCuc.Size = new System.Drawing.Size(193, 56);
            pictureBoxKingMix.Size = new System.Drawing.Size(193, 56);
            pictureBoxCono.Size = new System.Drawing.Size(193, 56);
            pictureBoxConoR.Size = new System.Drawing.Size(193, 56);
            pictureBoxSundae.Size = new System.Drawing.Size(193, 56);
            // MessageBox.Show("xD");
            cmbBebidas.DataSource = Bebida.Bebidas;
            WindowState = FormWindowState.Maximized;
            foreach (Control x in Controls)
            {
                if (x is Panel)
                {
                    CargoEtiqueta(font, x);
                    x.BackColor = new Color();
                    foreach (Control a in x.Controls)
                    {
                        CargoEtiqueta(font, a);
                        a.BackColor = new Color();
                        if (a is Panel)
                        {
                            CargoEtiqueta(font, a);
                            a.BackColor = new Color();
                            foreach (Control z in a.Controls)
                            {
                                CargoEtiqueta(font, z);
                                z.BackColor = new Color();
                            }
                        }
                    }
                }
            }
            //CargoEtiqueta(font, label128);
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void radioButton89_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void label111_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void aceptarKingMix_Click(object sender, EventArgs e)
        {
            string nombre = "";
            if (radioButton126.Checked == true)
            {
                nombre = "King Mix - Rocklets";
            }
            if (radioButton118.Checked == true)
            {
                nombre = "King Mix - Toddy Chocolate";

            }
            foreach (Postre p in Postre.Buscar(nombre))
            {

                dgvCombo.DataSource = p;
            }

        }

        private void aceptarCucuruchon_Click(object sender, EventArgs e)
        {
            string nombre = "";
            if (radioButton125.Checked == true)
            {
                nombre = "Cucuruchon - Rocklets";
            }
            if (radioButton121.Checked == true)
            {
                nombre = "Cucuruchon - Toddy Chocolate";

            }
            foreach (Postre p in Postre.Buscar(nombre))
            {

                dgvCombo.DataSource = p;
            }
        }

        private void aceptarSundae_Click(object sender, EventArgs e)
        {
            string nombre = "";
            if (radioButton124.Checked == true)
            {
                nombre = "Sundae Frutilla";
            }
            if (radioButton123.Checked == true)
            {
                nombre = "Sundae Dulce De Leche";

            }
            if (radioButton123.Checked == true)
            {
                nombre = "Sundae Chocolate";

            }
            foreach (Postre p in Postre.Buscar(nombre))
            {

                dgvCombo.DataSource = p;
            }

        }
        
        private void aceptarConoRelleno_Click(object sender, EventArgs e)
        {
            string nombre = "";
            if (radioButton120.Checked == true)
            {
                nombre = " Cono relleno Chocolate";
            }
            else
            {
                nombre = "Cono relleno Dulce De Leche";
            }
            foreach (Postre p in Postre.Buscar(nombre))
            {
                dgvCombo.DataSource = p;
            }
        }

        private void aceptarCono_Click(object sender, EventArgs e)
        {
            string tipo = "";
            if (radioButton114.Checked == true)
            {
                tipo = "Cono Americana";
            }

            if (radioButton113.Checked == true)
            {
                tipo = "Cono Dulce De Leche";
            }
            if (radioButton112.Checked == true)
            {
                tipo = "Cono Mixta";
            }
            foreach (Postre p in Postre.Buscar(tipo))
            {

                dgvCombo.DataSource = p;
            }
        }
        
        private void LimpiarPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            double precio = 0;
            MetodoDePago met = new MetodoDePago();
            if (rbEfectivo.Checked == true)
            {
                foreach (MetodoDePago m in MetodoDePago.Metodosdepagos)
                {
                    met = MetodoDePago.Metodosdepagos[0];
                }
            }
            MessageBox.Show(met.ToString());
            if (rbDebito.Checked == true)
            {
                foreach (MetodoDePago m in MetodoDePago.Metodosdepagos)
                {
                    met = MetodoDePago.Metodosdepagos[1];
                }
            }
            if (rbCredito.Checked == true)
            {
                foreach (MetodoDePago m in MetodoDePago.Metodosdepagos)
                {
                    met = MetodoDePago.Metodosdepagos[2];
                }
            }
            foreach (Combo h in Combo.Combos)
            {
                precio = precio + h.ArosDeCebolla.Precio;
                precio = precio + h.Papas.Precio;
                precio = precio + h.Hamburguesa.Precio;
                precio = precio + h.Bebida.Precio;
            }

            Pedido p = new Pedido(Combo.Combos, precio, met);
            p.Agregar();
            dgvConfirmar.DataSource = Pedido.Pedidos;

        }
        private void PBXCerrar_Click_1(object sender, EventArgs e)
        {   
            this.Hide();
        }

        private void PBKmix_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true; //PKMix, no deja cambiar el nombre al panel asi que le puse el nombre original
            PPostre.Visible = false;
        }

        private void PEfec_Click(object sender, EventArgs e)
        {
            FormPago a = new FormPago();
            
            if (rbCredito.Checked==true || rbDebito.Checked==true)
            {
                foreach (Control x in a.Controls)
                {
                    if (x.Name.Equals("PTarjeta"))
                    {
                        
                        x.Visible = true;
                        x.BringToFront();
                        a.ShowDialog();
                    }
                }
            }
          if (rbEfectivo.Checked.Equals(true))
            {
                foreach (Control x in a.Controls)
                {
                    if (x.Name.Equals("PEfectivo"))
                    {
                        
                        x.Visible = true;
                        x.BringToFront();
                        a.ShowDialog();
                    }
                }

            }
        }

        private void radioButton91_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            double precio = 0;
            MetodoDePago met = new MetodoDePago();
            dgvCombo.DataSource = null;
            if (rbEfectivo.Checked == true)
            {
                foreach (MetodoDePago m in MetodoDePago.Metodosdepagos)
                {
                    met = MetodoDePago.Metodosdepagos[0];
                }
            }
            if (rbDebito.Checked == true)
            {
                foreach (MetodoDePago m in MetodoDePago.Metodosdepagos)
                {
                    met = MetodoDePago.Metodosdepagos[1];
                }
            }
            if (rbCredito.Checked == true)
            {
                foreach (MetodoDePago m in MetodoDePago.Metodosdepagos)
                {
                    met = MetodoDePago.Metodosdepagos[2];
                }
            }
            foreach (Combo h in Combo.Combos)
            {
                precio = precio + h.ArosDeCebolla.Precio;
                precio = precio + h.Papas.Precio;
                precio = precio + h.Hamburguesa.Precio;
                precio = precio + h.Bebida.Precio;
            }
            new Pedido(Combo.Combos, precio, met).Agregar();
            
            dgvConfirmar.DataSource = Pedido.Pedidos;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            PPostre.Visible = true;
            PCono.Visible = false;
            PConoR.Visible = false;
            PSundae.Visible = false;
            PCucu.Visible = false;
            panel2.Visible = false; //PKMix
        }

        private void LimpiarPedido_Click_1(object sender, EventArgs e)
        {
            dgvCombo.DataSource = null;
        }
    }
}

