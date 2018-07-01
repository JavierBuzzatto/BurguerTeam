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
    public partial class FormEmpleadoJr : Form
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

        public FormEmpleadoJr()
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
        private void CargoEtiqueta(Font font, Control x)
        {
            float size = 11f;
            FontStyle fontStyle = FontStyle.Regular;

            x.Font = new Font(ff, x.Font.Size, fontStyle);

        }

        private void FormEmpleadoJr_Load(object sender, EventArgs e)
        {
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
        private void aceptarKingJr_Click(object sender, EventArgs e)
        {
            string tamaño = "";
            Papas papasPedidas = new Papas();
            ArosDeCebolla arosPedidos = new ArosDeCebolla();
            Bebida bebidaPedida = new Bebida();
            Hamburguesa hamburguesaPedida = new Hamburguesa();
            Combo comboPedido = new Combo();

            if (radioButton1.Checked == true)
            {
                foreach (Hamburguesa h in Hamburguesa.Hamburguesas)
                {

                    if (h.Nombre == "hamburguesa con queso")
                    {
                        hamburguesaPedida = Hamburguesa.Hamburguesas[4];
                    }
                }
            }

            if (radioButton3.Checked == true)
            {
                foreach (Hamburguesa h in Hamburguesa.Hamburguesas)
                {

                    if (h.Nombre == " hamburguesa simple")
                    {
                        hamburguesaPedida = Hamburguesa.Hamburguesas[3];
                    }
                }
            }
            if (radioButton2.Checked == true)
            {
                foreach (Hamburguesa h in Hamburguesa.Hamburguesas)
                {

                    if (h.Nombre == "hamburguesa con jamon y queso")
                    {
                        hamburguesaPedida = Hamburguesa.Hamburguesas[23];
                    }
                }
            }


            if (radioButton10.Checked == true)
            {

                tamaño = "pequeño";
            }

            if (radioButton8.Checked == true)
            {
                tamaño = "mediano";
            }
            if (radioButton9.Checked == true)
            {

                tamaño = "grande";
            }

            if (radioButton6.Checked == true)
            {
                if (tamaño == "pequeño")
                {
                    papasPedidas.Tamaño = 2;
                    papasPedidas.Precio = 20;
                }
                else
                {
                    if (tamaño == "mediano")
                    {
                        papasPedidas.Tamaño = 3;
                        papasPedidas.Precio = 30;
                    }
                    else
                    {
                        if (tamaño == "grande")
                        {
                            papasPedidas.Tamaño = 4;
                            papasPedidas.Precio = 40;
                        }
                    }
                }
            }
            if (radioButton4.Checked == true)
            {
                if (tamaño == "pequeño")
                {
                    arosPedidos.Tamaño = 2;
                    arosPedidos.Precio = 20;
                }
                else
                {
                    if (tamaño == "mediano")
                    {
                        arosPedidos.Tamaño = 3;
                        arosPedidos.Precio = 30;
                    }
                    else
                    {
                        if (tamaño == "grande")
                        {
                            arosPedidos.Tamaño = 4;
                            arosPedidos.Precio = 40;
                        }
                    }
                }
            }

            bebidaPedida = cmbBebidas.SelectedItem as Bebida;
            Combo l = new Combo(tamaño, bebidaPedida, papasPedidas, arosPedidos, hamburguesaPedida);
            l.Guardar();
            dgvCombo.DataSource = null;
            dgvCombo.DataSource = Combo.Combos;
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

        private void LimpiarPedido_Click_1(object sender, EventArgs e)
        {
            dgvCombo.DataSource = null;
        }
    }
}

