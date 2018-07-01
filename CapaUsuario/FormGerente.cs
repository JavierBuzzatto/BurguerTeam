using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using CapaNegocio;

namespace CapaUsuario
{

    public partial class FormGerente : Form
    {
        public FormGerente()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            //Tamaño.CargarTamaños();
            Hamburguesa.CargarHamburguesas();
            Bebida.CargarBebidas();
            Carne.CargarCarnes();
            Ingrediente.CargarIngredientes();
            Postre.CargarPostres();
            Nuggets.CargarNuggets();
            MostrarB();
            MostrarC();
            MostrarH();
            MostrarSH();
            ActualizarCmb();
            OcultarBtnBebidas();
            OcultarBtnHamburguesas();
            OcultarBtnCombo();
            pnlNugget.Enabled = false;
            cmbHamburguesa.Enabled = false;
            CargarPie1();
            CargarPie2();
            PBModificarC.Hide();

        }
        private void OcultarBtnCombo()
        {
            pnlAgregarCombo.Enabled = false;
            PBAceptarC.Hide();
            PBCancelarC.Hide();
            PBAceptarModC.Hide();
            PBCancelarModC.Hide();
        }
        public void CargarPie2()
        {
            Func<ChartPoint, string> labelPoint = null;

            pieChart2.Series = new SeriesCollection
            { };
            int c = 0;
            int d = 0;
            int e = 0;

            foreach (Pedido x in Pedido.Pedidos)
            {

                if (x.MetodoDePago.Equals(MetodoDePago.Metodosdepagos[2]))
                {
                    c++;
                }
                else if (x.MetodoDePago.Equals(MetodoDePago.Metodosdepagos[1]))
                {
                    d++;
                }
                else if (x.MetodoDePago.Equals(MetodoDePago.Metodosdepagos[0]))
                {
                    e++;
                }
               labelPoint = chartPoint =>
            string.Format( x.MetodoDePago.ToString(), chartPoint.Participation);
            }
                pieChart2.Series.Add(new PieSeries
                {
                    Title = "Tarjeta de credito",
                    Values = new ChartValues<double> { c },
                    DataLabels = true,
                    LabelPoint = labelPoint
                });
                pieChart2.Series.Add(new PieSeries
                {
                    Title = "Tarjeta de Debito",
                    Values = new ChartValues<double> {d },
                    DataLabels = true,
                    LabelPoint = labelPoint
                });
                pieChart2.Series.Add(new PieSeries
                {
                    Title = "Efectivo",
                    Values = new ChartValues<double> { e },
                    DataLabels = true,
                    LabelPoint = labelPoint
                });


            pieChart2.DataTooltip.Visibility = System.Windows.Visibility.Hidden;
            pieChart2.LegendLocation = LegendLocation.Bottom;
        }

        private void CargarPie1()
        {
            Func<ChartPoint, string> labelPoint = null;

            pieChart1.Series = new SeriesCollection
            { };
            Dictionary<Hamburguesa, int> contadores = new Dictionary<Hamburguesa, int>();
            contadores.Add(new Hamburguesa(), 0);
            Dictionary<Hamburguesa, int> contadoresAux = new Dictionary<Hamburguesa, int>(); ;


            foreach (Pedido x in Pedido.Pedidos)
            {
                foreach (Combo z in x.Combos)
                {
                    if (contadoresAux.ContainsKey(z.Hamburguesa))
                    {
                        contadoresAux[z.Hamburguesa] = contadoresAux[z.Hamburguesa] + 1;
                    }
                    else
                    {
                        contadoresAux.Add(z.Hamburguesa, new int() + 1);
                    }
                    labelPoint = chartPoint =>
                    string.Format(z.Hamburguesa.ToString(), chartPoint.Participation);
                }
                

            }
            foreach (KeyValuePair<Hamburguesa, int> x in contadoresAux)
            {
                pieChart1.Series.Add(new PieSeries
                {
                    Title = x.Key.ToString(),
                    Values = new ChartValues<double> { x.Value },
                    DataLabels = true,
                    LabelPoint = labelPoint
                });
            }

            pieChart1.DataTooltip.Visibility = System.Windows.Visibility.Hidden;
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }
        
        private void OcultarBtnHamburguesas()
        {
            PBAceptarH.Hide();
            PBCancelarH.Hide();
            PBAceptarModH.Hide();
            PBCancelarModH.Hide();
            pnlAgregarH.Enabled = false;
        }
        private void OcultarBtnBebidas()
        {
            PBAceptarB.Hide();
            PBCancelarB.Hide();
            PBAceptarModB.Hide();
            PBCancelarModB.Hide();
            pnlAgregarBebida.Enabled = false;
        }
        private void ActualizarCmb()
        {
            cmbTamB.DataSource = null;
            cmbTamB.DataSource = Tamaño.Tamaños;
            cmbTamanoC.DataSource = null;
            cmbTamanoC.DataSource = Tamaño.Tamaños;
            cmbHamburguesa.DataSource = null;
            cmbHamburguesa.DataSource = Hamburguesa.Hamburguesas;
            cmbTipoDeCarne.DataSource = null;
            cmbTipoDeCarne.DataSource = Carne.Carnes;
            cmbNuggets.DataSource = null;
            cmbNuggets.DataSource = Nuggets.Nuggetss;
        }
        private void btnAgregarHamburguesa(object sender, EventArgs e)
        {

        }

        private void MostrarSH()
        {
            dgvSelecH.DataSource = null;
            dgvSelecH.DataSource = Hamburguesa.MostrarHamburguesa();
        }
        private void MostrarH()
        {
            dgv_hamburguesas.DataSource = null;
            dgv_hamburguesas.DataSource = Hamburguesa.MostrarHamburguesa();
        }
        private void MostrarB()
        {
            dgv_bebidas.DataSource = null;
            dgv_bebidas.DataSource = Bebida.MostrarBebida();
        }
        private void MostrarC()
        {
            dgv_combos.DataSource = null;
            dgv_combos.DataSource = Combo.MostrarCombos();
        }

        private void FormGerente_Load(object sender, EventArgs e)
        {

        }

        private void dgv_hamburguesas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_bebidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_combos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarH_Click(object sender, EventArgs e)
        {
        }

        private void btnAgregarBebida_Click(object sender, EventArgs e)
        {
            pnlAgregarBebida.Show();
        }

        private void radbtnH_CheckedChanged(object sender, EventArgs e)
        {
            pnlNugget.Enabled = false;
            pnlHamburguesa.Enabled = true;
        }

        private void radbtnN_CheckedChanged(object sender, EventArgs e)
        {
            pnlNugget.Enabled = true;
            pnlHamburguesa.Enabled = false;
        }

        private void btnAgregarB_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCombos_Click(object sender, EventArgs e)
        {
            pnlAgregarCombo.Show();

                  
            
        }

        private void btnAceptarH_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void FormGerente_Load_1(object sender, EventArgs e)
        {

        }

        private void PBAceptarB_Click(object sender, EventArgs e)
        {
            if (txtNombreB.Text.Trim() != "" && numPrecioB.Value != 0 && cmbTamB.SelectedItem != null)
            {
                Bebida bebidas = new Bebida(txtNombreB.Text, cmbTamB.SelectedItem as Tamaño, (double)numPrecioB.Value);
                bebidas.Agregar();
                MostrarB();
                pnlAgregarBebida.Enabled = false;
                PBAceptarB.Hide();
                PBCancelarB.Hide();
                dgv_bebidas.Enabled = true;
                txtNombreB.Clear();
                numPrecioB.Value = 0;
                PBModificarB.Show();
            }
            else
            {
                MessageBox.Show("Complete los datos de la Bebida antes de agregar una", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PBCancelarB_Click(object sender, EventArgs e)
        {
            pnlAgregarBebida.Enabled = false;
            PBAceptarB.Hide();
            PBCancelarB.Hide();
            dgv_bebidas.Enabled = true;
            txtNombreB.Clear();
            numPrecioB.Value = 0;
            PBModificarB.Show();
        }

        private void btnCancelarB_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbTamB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PBAgregarBebida_Click(object sender, EventArgs e)
        {
            pnlAgregarBebida.Enabled = true;
            dgv_bebidas.Enabled = false;
            PBAceptarB.Show();
            PBCancelarB.Show();
            PBAceptarModB.Hide();
            PBCancelarModB.Hide();
            PBModificarB.Hide();

        }

        private void PBVolverLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().ShowDialog();
        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void PBAceptarModB_Click(object sender, EventArgs e)
        {
            if (txtNombreB.Text.Trim() != "" && numPrecioB.Value > 0 && cmbTamB.SelectedItem != null)
            {
                if (dgv_bebidas.CurrentRow != null && dgv_bebidas.CurrentRow.DataBoundItem != null)
                {
                    Bebida b = (dgv_bebidas.CurrentRow.DataBoundItem as Bebida);
                    b.Modify(txtNombreB.Text, cmbTamB.SelectedItem as Tamaño, (double)numPrecioB.Value);
                    MostrarH();
                    pnlAgregarBebida.Enabled = false;
                    dgv_bebidas.Enabled = false;
                    PBAceptarB.Hide();
                    PBCancelarB.Hide();
                    PBAceptarModB.Hide();
                    PBCancelarModB.Hide();
                    PBAgregarBebida.Show();
                }
            }
            else
            {
                MessageBox.Show("Complete los datos de la Bebida antes de agregar una", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void PBModificarB_Click(object sender, EventArgs e)
        {
            if (dgv_bebidas.CurrentRow != null && dgv_bebidas.CurrentRow.DataBoundItem != null)
            {
                Bebida b = (dgv_bebidas.CurrentRow.DataBoundItem as Bebida);
                txtNombreB.Text = b.Nombre;
                cmbTamB.SelectedItem = b.Tamaño;
                numPrecioB.Value = (decimal)b.Precio;
            }
                pnlAgregarBebida.Enabled = true;
                dgv_bebidas.Enabled = true;
                PBAceptarB.Hide();
                PBCancelarB.Hide();
                PBAceptarModB.Show();
                PBCancelarModB.Show();
                PBAgregarBebida.Hide();
        }

        private void PBCancelarModB_Click(object sender, EventArgs e)
        {
            pnlAgregarBebida.Enabled = false;
            dgv_bebidas.Enabled = false;
            PBAceptarB.Hide();
            PBCancelarB.Hide();
            PBAceptarModB.Hide();
            PBCancelarModB.Hide();
            PBAgregarBebida.Show();
        }

        private void PBEliminarB_Click(object sender, EventArgs e)
        {
            if (dgv_bebidas.CurrentRow != null && dgv_bebidas.CurrentRow.DataBoundItem != null)
            {
                Bebida b = (dgv_bebidas.CurrentRow.DataBoundItem as Bebida);
                b.Eliminar();
            }
            MostrarB();
        }

        private void PBAgregarH_Click(object sender, EventArgs e)
        {
            pnlAgregarH.Enabled = true;
            PBAceptarH.Show();
            PBCancelarH.Show();
            PBAceptarModH.Hide();
            PBCancelarModH.Hide();
            PBModificarH.Hide();
        }


        private void PBCancelarH_Click(object sender, EventArgs e)
        {
            pnlAgregarH.Enabled = false;
            PBAceptarH.Hide();
            PBCancelarH.Hide();
            PBAceptarModH.Hide();
            PBCancelarModH.Hide();
            PBModificarH.Hide();
            txtNombre.Clear();
            numPrecioHam.Value = 0;
            txtIngredientesH.Clear();
            PBModificarH.Show();
            PBAgregarH.Show();
        }

        private void PBModificarH_Click(object sender, EventArgs e)
        {
            if (dgv_hamburguesas.CurrentRow != null && dgv_hamburguesas.CurrentRow.DataBoundItem != null)
            {
                Hamburguesa h = (dgv_hamburguesas.CurrentRow.DataBoundItem as Hamburguesa);
                txtNombre.Text = h.Nombre;
                numPrecioHam.Value = (decimal)h.Precio;
                cmbTipoDeCarne.SelectedItem = h.TipoDeCarne;
                txtIngredientesH.Text = h.Ingredientes;
               
                
            }
            pnlAgregarH.Enabled = true;
            PBAceptarH.Hide();
            PBCancelarH.Hide();
            PBAceptarModH.Show();
            PBCancelarModH.Show();
            PBAgregarH.Hide();
            PBModificarH.Show();
        }

        private void PBAceptarModH_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() != "" && numPrecioHam.Value > 0 && cmbTipoDeCarne.SelectedItem != null && txtIngredientesH.Text.Trim() != "")
            {
                if (dgv_hamburguesas.CurrentRow != null && dgv_hamburguesas.CurrentRow.DataBoundItem != null)
                {
                    Hamburguesa h = (dgv_hamburguesas.CurrentRow.DataBoundItem as Hamburguesa);
                    h.Modify(txtNombre.Text, cmbTipoDeCarne.SelectedItem as Carne, (double)numPrecioHam.Value, txtIngredientesH.Text);
                    MostrarH();
                    pnlAgregarH.Enabled = false;
                    PBAceptarH.Hide();
                    PBCancelarH.Hide();
                    PBAceptarModH.Hide();
                    PBCancelarModH.Hide();
                    PBModificarH.Hide();
                    PBModificarH.Show();
                    PBAgregarH.Show();
                }
            }
            else
            {
                MessageBox.Show("Complete los datos de la Hamburguesa antes de agregar una", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void PBAceptarH_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() != "" && numPrecioHam.Value != 0 && cmbTipoDeCarne.SelectedItem != null && txtIngredientesH.Text.Trim() != "")
            {
                Hamburguesa h = new Hamburguesa(txtNombre.Text, cmbTipoDeCarne.SelectedItem as Carne, (double)numPrecioHam.Value,txtIngredientesH.Text);
                h.Agregar();
                MostrarH();
                pnlAgregarH.Enabled = false;
                PBAceptarH.Hide();
                PBCancelarH.Hide();
                PBAceptarModH.Hide();
                PBCancelarModH.Hide();
                PBModificarH.Hide();
                txtNombre.Clear();
                numPrecioHam.Value = 0;
                txtIngredientesH.Clear();
                PBModificarH.Show();
                PBAgregarH.Show();
            }
            else
            {
                MessageBox.Show("Complete los datos de la Hamburguesa antes de agregar una", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PBCancelarModH_Click(object sender, EventArgs e)
        {
            MostrarH();
            pnlAgregarH.Enabled = false;
            PBAceptarH.Hide();
            PBCancelarH.Hide();
            PBAceptarModH.Hide();
            PBCancelarModH.Hide();
            txtNombre.Clear();
            numPrecioHam.Value = 0;
            txtIngredientesH.Clear();
            PBModificarH.Show();
            PBAgregarH.Show();
        }

        private void PBEliminarH_Click(object sender, EventArgs e)
        {
            if (dgv_hamburguesas.CurrentRow != null && dgv_hamburguesas.CurrentRow.DataBoundItem != null)
            {
                Hamburguesa h = (dgv_hamburguesas.CurrentRow.DataBoundItem as Hamburguesa);
                h.Quitar();
            }
            MostrarH();
        }
        private void MostrarDgvCombo()
        {
            MostrarC();
            MostrarSH();
        }
        private void PBAgregarC_Click(object sender, EventArgs e)
        {
            pnlAgregarCombo.Enabled = true;
            PBAceptarC.Show();
            PBCancelarC.Show();
            PBModificarC.Hide();
            PBAceptarModC.Hide();
            PBCancelarModC.Hide();
            MostrarDgvCombo();
        }
        private void PBCancelarC_Click(object sender, EventArgs e)
        {
            pnlAgregarCombo.Enabled = false;
            PBAceptarC.Hide();
            PBCancelarC.Hide();
            PBModificarC.Hide();
            PBAceptarModC.Hide();
            PBCancelarModC.Hide();
            MostrarDgvCombo();
            numPrecioC.Value = 0;

        }

        private void PBEliminarC_Click(object sender, EventArgs e)
        {
            
                //Combo c = (dgv_combos.CurrentRow.DataBoundItem as Combo);
                //c.Eliminar();
            
            //MostrarDgvCombo();
        }

        private void PBAceptarC_Click(object sender, EventArgs e)
        {
           /* if (radbtnPapas.Checked == true)
            {
                if (radbtnH.Checked == true)
                {
                    if (cmbTamanoC.SelectedItem != null && numPrecioC.Value > 0 && cmbHamburguesa.SelectedItem != null)
                    {
                        Combo combos = new Combo(cmbTamanoC.SelectedItem as Tamaño, (double)numPrecioC.Value, new Papas(0, 1), new Nuggets(), new ArosDeCebolla(0, 0), cmbHamburguesa.SelectedItem as Hamburguesa);
                        combos.Guardar();
                        pnlAgregarCombo.Enabled = false;
                        PBAceptarC.Hide();
                        PBCancelarC.Hide();
                        PBModificarC.Hide();
                        PBAceptarModC.Hide();
                        PBCancelarModC.Hide();
                        MostrarDgvCombo();
                        numPrecioC.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Complete los datos del Combo antes de agregar uno", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (cmbTamanoC.SelectedItem != null && numPrecioC.Value > 0 && cmbNuggets.SelectedItem != null)
                    {
                        Combo combos = new Combo(cmbTamanoC.SelectedItem as Tamaño, (double)numPrecioC.Value, new Papas(0, 1), cmbNuggets.SelectedItem as Nuggets, new ArosDeCebolla(0, 0), new Hamburguesa());
                        combos.Guardar();
                        pnlAgregarCombo.Enabled = false;
                        PBAceptarC.Hide();
                        PBCancelarC.Hide();
                        PBModificarC.Hide();
                        PBAceptarModC.Hide();
                        PBCancelarModC.Hide();
                        MostrarDgvCombo();
                        numPrecioC.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Complete los datos del Combo antes de agregar uno", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if (radbtnH.Checked == true)
                {
                    if (cmbTamanoC.SelectedItem != null && numPrecioC.Value > 0 && cmbHamburguesa.SelectedItem != null)
                    {
                        Combo combos = new Combo(cmbTamanoC.SelectedItem as Tamaño, (double)numPrecioC.Value, new Papas(0, 0), new Nuggets(), new ArosDeCebolla(0, 1), cmbHamburguesa.SelectedItem as Hamburguesa);
                        combos.Guardar();
                        pnlAgregarCombo.Enabled = false;
                        PBAceptarC.Hide();
                        PBCancelarC.Hide();
                        PBModificarC.Hide();
                        PBAceptarModC.Hide();
                        PBCancelarModC.Hide();
                        MostrarDgvCombo();
                        numPrecioC.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Complete los datos del Combo antes de agregar uno", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (cmbTamanoC.SelectedItem != null && numPrecioC.Value > 0 && cmbNuggets.SelectedItem != null)
                    {
                        Combo combos = new Combo(cmbTamanoC.SelectedItem as Tamaño, (double)numPrecioC.Value, new Papas(0, 0), cmbNuggets.SelectedItem as Nuggets, new ArosDeCebolla(0, 1), new Hamburguesa());
                        combos.Guardar();
                        pnlAgregarCombo.Enabled = false;
                        PBAceptarC.Hide();
                        PBCancelarC.Hide();
                        PBModificarC.Hide();
                        PBAceptarModC.Hide();
                        PBCancelarModC.Hide();
                        MostrarDgvCombo();
                        numPrecioC.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Complete los datos del Combo antes de agregar uno", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }*/
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void TPEstadisticas_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            PNLVentaMensual.Visible = false;
            HambVendida.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PNLVentaMensual.Visible = true;
            HambVendida.Visible = false;
        }

        /*private void PBModificarC_Click(object sender, EventArgs e)
        {
            if (dgv_combos.CurrentRow != null && dgv_combos.CurrentRow.DataBoundItem != null)
            {
                Combo c = (dgv_combos.CurrentRow.DataBoundItem as Combo);
                cmbTamanoC.SelectedItem = c.Tamaño;
                numPrecioC.Value = (decimal)c.Precio;
                


            }
            pnlAgregarCombo.Enabled = true;
            PBAceptarC.Hide();
            PBCancelarC.Hide();
            PBModificarC.Show();
            PBAceptarModC.Show();
            PBCancelarModC.Show();
            MostrarDgvCombo();
        }*/
    }
}
