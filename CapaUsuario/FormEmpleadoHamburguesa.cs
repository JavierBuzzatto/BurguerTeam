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
    public partial class FormEmpleadoHamburguesa : Form
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

        public FormEmpleadoHamburguesa()
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
        
/*private void PBHamb_Click(object sender, EventArgs e) //podria hacer que vuelva a hamburguesa
        {
            PHamb.Visible = true;
            PPri.Visible = false;
        }*/

        private void BTNVolver_Click_1(object sender, EventArgs e) //EL BOTON DE LA CRUZ
        {
            this.Hide();


        }
        private void PBHam_Click(object sender, EventArgs e)
        {
            LHambS.Visible = true;
            PHamb.Visible = false;
        }

        private void PBHNapo_Click(object sender, EventArgs e)
        {
            PNapo.Visible = true;
            PHamb.Visible = false;
        }

        private void PBExtraBurguer_Click(object sender, EventArgs e)
        {
            PExtraB.Visible = true;
            PHamb.Visible = false;
        }

        private void PBWhopper_Click(object sender, EventArgs e)
        {
            PWhopper.Visible = true;
            PHamb.Visible = false;
        }

        private void PBStacker_Click(object sender, EventArgs e)
        {
            PStacker.Visible = true;
            PHamb.Visible = false;
        }

        private void PBLong_Click(object sender, EventArgs e)
        {
            PLong.Visible = true;
            PHamb.Visible = false;
        }

        private void PBLongc_Click(object sender, EventArgs e)
        {
            PLongC.Visible = true;
            PLong.Visible = false;
        }

        private void PBLongBBQ_Click(object sender, EventArgs e)
        {
            PLongBBQ.Visible = true;
            PLong.Visible = false;
        }

        private void PBLongJQ_Click(object sender, EventArgs e)
        {
            PLongJQ.Visible = true;
            PLong.Visible = false;
        }

        private void PBLongO_Click(object sender, EventArgs e)
        {
            PLongO.Visible = true;
            PLong.Visible = false;
        }
        private void CargoEtiqueta(Font font, Control x)
        {
            float size = 11f;
            FontStyle fontStyle = FontStyle.Regular;

            x.Font = new Font(ff, x.Font.Size, fontStyle);

        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            pictureBoxHQ.Size = new System.Drawing.Size(193, 56);
            pictureBoxBKS.Size = new System.Drawing.Size(193, 56);
            pictureBoxWH.Size = new System.Drawing.Size(193, 56);
            pictureBoxLong.Size = new System.Drawing.Size(193, 56);
            pictureBoxNapo.Size = new System.Drawing.Size(193, 56);
            pictureBoxEx.Size = new System.Drawing.Size(193, 56);
            pictureBoxLBBQ.Size = new System.Drawing.Size(193, 56);
            pictureBoxLOC.Size = new System.Drawing.Size(193, 56);
            pictureBoxLJQ.Size = new System.Drawing.Size(193, 56);
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
            CargoEtiqueta(font, label128);
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void radioButton89_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void aceptarWhopper_Click(object sender, EventArgs e)
        {
            string tamaño = "";
            Papas papasPedidas = new Papas();
            ArosDeCebolla arosPedidos = new ArosDeCebolla();
            Bebida bebidaPedida = new Bebida();
            Hamburguesa hamburguesaPedida = new Hamburguesa();
            Combo comboPedido = new Combo();

            if (radioButton82.Checked == true)
            {
                foreach (Hamburguesa h in Hamburguesa.Hamburguesas)
                {

                    if (h.Nombre == "whopper")
                    {
                        hamburguesaPedida = Hamburguesa.Hamburguesas[10];
                    }
                }
            }

            if (radioButton81.Checked == true)
            {
                foreach (Hamburguesa h in Hamburguesa.Hamburguesas)
                {

                    if (h.Nombre == " whopper jr")
                    {
                        hamburguesaPedida = Hamburguesa.Hamburguesas[13];
                    }
                }
            }
            if (radioButton101.Checked == true)
            {
                foreach (Hamburguesa h in Hamburguesa.Hamburguesas)
                {

                    if (h.Nombre == "whopper extreme")
                    {
                        hamburguesaPedida = Hamburguesa.Hamburguesas[12];
                    }
                }
            }

            if (radioButton88.Checked == true)
            {

                hamburguesaPedida.Ingredientes = "";
            }
            if (radioButton85.Checked == true)
            {

                tamaño = "pequeño";
            }

            if (radioButton83.Checked == true)
            {
                tamaño = "mediano";
            }
            if (radioButton84.Checked == true)
            {

                tamaño = "grande";
            }

            if (radioButton87.Checked == true)
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
            if (radioButton89.Checked == true)
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

        private void agregarPedido_Click(object sender, EventArgs e)
        {
            PHamb.Visible = true;
        }

        private void aceptarNapolitano_Click(object sender, EventArgs e)
        {
            string tamaño = "";
            Papas papasPedidas = new Papas();
            ArosDeCebolla arosPedidos = new ArosDeCebolla();
            Bebida bebidaPedida = new Bebida();
            Hamburguesa hamburguesaPedida = new Hamburguesa();
            Combo comboPedido = new Combo();
            foreach (Hamburguesa h in Hamburguesa.Hamburguesas)
            {

                if (h.Nombre == "napolitano")
                {
                    hamburguesaPedida = Hamburguesa.Hamburguesas[5];
                }
            }


            if (radioButton77.Checked == true)
            {
                hamburguesaPedida.Ingredientes = "";

            }

            if (radioButton74.Checked == true)
            {

                tamaño = "pequeño";
            }

            if (radioButton72.Checked == true)
            {
                tamaño = "mediano";
            }
            if (radioButton73.Checked == true)
            {

                tamaño = "grande";
            }

            if (radioButton76.Checked == true)
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
            if (radioButton75.Checked == true)
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
            Combo c = new Combo(tamaño, bebidaPedida, papasPedidas, arosPedidos, hamburguesaPedida);
            c.Guardar();
            dgvCombo.DataSource = null;
            dgvCombo.DataSource = Combo.Combos;
        }

        private void aceptarExtra_Click(object sender, EventArgs e)
        {
            string tamaño = "";
            Papas papasPedidas = new Papas();
            ArosDeCebolla arosPedidos = new ArosDeCebolla();
            Bebida bebidaPedida = new Bebida();
            Hamburguesa hamburguesaPedida = new Hamburguesa();
            Combo comboPedido = new Combo();
            if (radioButton80.Checked == true)
            {
                foreach (Hamburguesa h in Hamburguesa.Hamburguesas)
                {

                    if (h.Nombre == "extra burguer")
                    {
                        hamburguesaPedida = Hamburguesa.Hamburguesas[6];
                    }
                }
            }
            if (radioButton79.Checked == true)
            {
                foreach (Hamburguesa h in Hamburguesa.Hamburguesas)
                {

                    if (h.Nombre == "extra burguer xl")
                    {
                        hamburguesaPedida = h;
                    }
                }
            }

            if (radioButton147.Checked == true)
            {

                hamburguesaPedida.Ingredientes = "";
            }
            if (radioButton67.Checked == true)
            {

                tamaño = "pequeño";
            }

            if (radioButton65.Checked == true)
            {
                tamaño = "mediano";
            }
            if (radioButton66.Checked == true)
            {

                tamaño = "grande";
            }

            if (radioButton69.Checked == true)
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
            if (radioButton68.Checked == true)
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
            Combo c = new Combo(tamaño, bebidaPedida, papasPedidas, arosPedidos, hamburguesaPedida);
            c.Guardar();
            dgvCombo.DataSource = null;
            dgvCombo.DataSource = Combo.Combos;
        }

        private void aceptarHambConQueso_Click(object sender, EventArgs e)
        {
            string tamaño = "";
            Papas papasPedidas = new Papas();
            ArosDeCebolla arosPedidos = new ArosDeCebolla();
            Bebida bebidaPedida = new Bebida();
            Hamburguesa hamburguesaPedida = new Hamburguesa();
            Combo comboPedido = new Combo();
            foreach (Hamburguesa h in Hamburguesa.Hamburguesas)
            {

                if (h.Nombre == "hamburguesa con queso")
                {
                    hamburguesaPedida = Hamburguesa.Hamburguesas[4];
                }
            }

            if (radioButton63.Checked == true)
            {

                hamburguesaPedida.Ingredientes = "";
            }
            if (radioButton60.Checked == true)
            {

                tamaño = "pequeño";
            }

            if (radioButton58.Checked == true)
            {
                tamaño = "mediano";
            }
            if (radioButton59.Checked == true)
            {

                tamaño = "grande";
            }

            if (radioButton62.Checked == true)
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
            if (radioButton61.Checked == true)
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
            Combo c = new Combo(tamaño, bebidaPedida, papasPedidas, arosPedidos, hamburguesaPedida);
            c.Guardar();
            dgvCombo.DataSource = null;
            dgvCombo.DataSource = Combo.Combos;
        }
        private void aceptarLongOnion_Click(object sender, EventArgs e)
        {
            string tamaño = "";
            Papas papasPedidas = new Papas();
            ArosDeCebolla arosPedidos = new ArosDeCebolla();
            Bebida bebidaPedida = new Bebida();
            Hamburguesa hamburguesaPedida = new Hamburguesa();
            Combo comboPedido = new Combo();
            foreach (Hamburguesa h in Hamburguesa.Hamburguesas)
            {

                if (h.Nombre == "long onion cheddar")
                {
                    hamburguesaPedida = Hamburguesa.Hamburguesas[14];
                }
            }

            if (radioButton158.Checked == true)
            {

                hamburguesaPedida.Ingredientes = "";
            }
            if (radioButton155.Checked == true)
            {

                tamaño = "pequeño";
            }

            if (radioButton153.Checked == true)
            {
                tamaño = "mediano";
            }
            if (radioButton154.Checked == true)
            {

                tamaño = "grande";
            }

            if (radioButton157.Checked == true)
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
            if (radioButton156.Checked == true)
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
            Combo c = new Combo(tamaño, bebidaPedida, papasPedidas, arosPedidos, hamburguesaPedida);
            c.Guardar();
            dgvCombo.DataSource = null;
            dgvCombo.DataSource = Combo.Combos;
        }

        private void aceptarLongJYQ_Click(object sender, EventArgs e)
        {

            string tamaño = "";
            Papas papasPedidas = new Papas();
            ArosDeCebolla arosPedidos = new ArosDeCebolla();
            Bebida bebidaPedida = new Bebida();
            Hamburguesa hamburguesaPedida = new Hamburguesa();
            Combo comboPedido = new Combo();
            foreach (Hamburguesa h in Hamburguesa.Hamburguesas)
            {

                if (h.Nombre == "long jamon y queso")
                {
                    hamburguesaPedida = Hamburguesa.Hamburguesas[1];
                }
            }

            if (radioButton147.Checked == true)
            {

                hamburguesaPedida.Ingredientes = "";
            }
            if (radioButton144.Checked == true)
            {

                tamaño = "pequeño";
            }

            if (radioButton142.Checked == true)
            {
                tamaño = "mediano";
            }
            if (radioButton143.Checked == true)
            {

                tamaño = "grande";
            }

            if (radioButton146.Checked == true)
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
            if (radioButton145.Checked == true)
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
            Combo c = new Combo(tamaño, bebidaPedida, papasPedidas, arosPedidos, hamburguesaPedida);
            c.Guardar();
            dgvCombo.DataSource = null;
            dgvCombo.DataSource = Combo.Combos;
        }

        private void aceptarLongRodeo_Click(object sender, EventArgs e)
        {
            string tamaño = "";
            Papas papasPedidas = new Papas();
            ArosDeCebolla arosPedidos = new ArosDeCebolla();
            Bebida bebidaPedida = new Bebida();
            Hamburguesa hamburguesaPedida = new Hamburguesa();
            Combo comboPedido = new Combo();
            foreach (Hamburguesa h in Hamburguesa.Hamburguesas)
            {

                if (h.Nombre == "long bbq")
                {
                    hamburguesaPedida = Hamburguesa.Hamburguesas[2];
                }
            }


            if (radioButton137.Checked == true)
            {


            }
            if (radioButton147.Checked == true)
            {

                hamburguesaPedida.Ingredientes = "";
            }
            if (radioButton133.Checked == true)
            {

                tamaño = "pequeño";
            }

            if (radioButton131.Checked == true)
            {
                tamaño = "mediano";
            }
            if (radioButton132.Checked == true)
            {

                tamaño = "grande";
            }

            if (radioButton135.Checked == true)
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
            if (radioButton145.Checked == true)
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
            Combo c = new Combo(tamaño, bebidaPedida, papasPedidas, arosPedidos, hamburguesaPedida);
            c.Guardar();
            dgvCombo.DataSource = null;
            dgvCombo.DataSource = Combo.Combos;

        }

        private void label111_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void aceptarStacker_Click(object sender, EventArgs e)
        {
            string tamaño = "";
            Papas papasPedidas = new Papas();
            ArosDeCebolla arosPedidos = new ArosDeCebolla();
            Bebida bebidaPedida = new Bebida();
            Hamburguesa hamburguesaPedida = new Hamburguesa();
            Combo comboPedido = new Combo();

            if (radioButton110.Checked == true)
            {

            }

            if (radioButton103.Checked == true)
            {
                foreach (Hamburguesa h in Hamburguesa.Hamburguesas)
                {

                    if (h.Nombre == " stacker triple")
                    {
                        hamburguesaPedida = Hamburguesa.Hamburguesas[8];
                    }
                }
            }

            if (radioButton102.Checked == true)
            {
                foreach (Hamburguesa h in Hamburguesa.Hamburguesas)
                {

                    if (h.Nombre == " stacker cuadruple")
                    {
                        hamburguesaPedida = Hamburguesa.Hamburguesas[9];
                    }
                }
            }
            if (radioButton101.Checked == true)
            {
                foreach (Hamburguesa h in Hamburguesa.Hamburguesas)
                {

                    if (h.Nombre == " stacker Atomic")
                    {
                        hamburguesaPedida = Hamburguesa.Hamburguesas[15];
                    }
                }
            }

            /*if (radioButton30.Checked == true) //chequear
            {

                hamburguesaPedida.Ingredientes = "";
            }*/
            if (radioButton106.Checked == true)
            {

                tamaño = "pequeño";
            }

            if (radioButton104.Checked == true)
            {
                tamaño = "mediano";
            }
            if (radioButton105.Checked == true)
            {

                tamaño = "grande";
            }

            if (radioButton108.Checked == true)
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
            if (radioButton107.Checked == true)
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

        private void aceptarLong_Click(object sender, EventArgs e)
        {

            string tamaño = "";
            Papas papasPedidas = new Papas();
            ArosDeCebolla arosPedidos = new ArosDeCebolla();
            Bebida bebidaPedida = new Bebida();
            Hamburguesa hamburguesaPedida = new Hamburguesa();
            Combo comboPedido = new Combo();
            foreach (Hamburguesa h in Hamburguesa.Hamburguesas)
            {

                if (h.Nombre == " long clasico")
                {
                    hamburguesaPedida = Hamburguesa.Hamburguesas[0];
                }
            }

            /*if (radioButton13.Checked == true) //chequear
            {

                hamburguesaPedida.Ingredientes = "";
            }*/
            if (radioButton96.Checked == true)
            {

                tamaño = "pequeño";
            }

            if (radioButton94.Checked == true)
            {
                tamaño = "mediano";
            }
            if (radioButton95.Checked == true)
            {

                tamaño = "grande";
            }

            if (radioButton98.Checked == true)
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
            if (radioButton97.Checked == true)
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

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            PHamb.Visible = true;
            LHambS.Visible = false;
            PNapo.Visible = false;
            PExtraB.Visible = false;
            PWhopper.Visible = false;
            PStacker.Visible = false;
            PLong.Visible = false;
            PLongC.Visible = false;
            PLongBBQ.Visible = false;
            PLongJQ.Visible = false;
            PLongO.Visible = false;
        }

        private void LimpiarPedido_Click_1(object sender, EventArgs e)
        {
            dgvCombo.DataSource = null;
        }
    }
}

