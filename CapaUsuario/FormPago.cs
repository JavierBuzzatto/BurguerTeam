using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace CapaUsuario
{
    public partial class FormPago : Form
    {
        public FormPago()
        {
            InitializeComponent();
            pedido2.DataSource = Pedido.Pedidos;
        }
        private void PEfecti_Click(object sender, EventArgs e)
        {
            PEfectivo.Visible = true;
            PTarjeta.Visible = false;
        }

        private void PTarje_Click(object sender, EventArgs e)
        {
            PEfectivo.Visible = false;
            PTarjeta.Visible = true;
        }

        private void PCruz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Felicidades acabas de vender grasa saturada a otro ser de tu raza, para acortar su vida y acabar con la sobrepoblacion");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Felicidades acabas de vender grasa saturada a otro ser de tu raza, para acortar su vida y acabar con la sobrepoblacion, OJO Con tarjeta");
        }
    }
}
