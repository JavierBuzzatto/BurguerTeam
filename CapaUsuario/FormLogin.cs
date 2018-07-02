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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            
            LBLUincorrecto.Hide();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

        }

        private void PBXAceptar_Click(object sender, EventArgs e)
        {
            foreach(Usuario u in Usuario.Usuarios)
            {
                if (u.NombreDeUsuario.Equals(TXTNombreUsuario.Text))
                {
                    LBLUincorrecto.Visible = false;
                    if (u.Contraseña.Equals(TXTContraseña.Text))
                    {

                        LBLUincorrecto.Visible = false;
                        if (u.EsAdmin.Equals(true))
                        {
                            this.Hide();
                            new FormGerente().ShowDialog();
                            LBLUincorrecto.Visible = false;
                            this.Close();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("xD");
                            this.Hide();
                            new FormEmpleado().ShowDialog();
                            LBLUincorrecto.Visible = false;

                            this.Close();
                            break;
                        }

                    }
                    else if(LBLUincorrecto.Visible == false)
                    {
                        
                        LBLUincorrecto.Visible = true;
                    }
                }
                else if (LBLUincorrecto.Visible == false)
                {
                    
                    LBLUincorrecto.Visible = true;
                }
                
            }
        }

        private void LBLUincorrecto_Click(object sender, EventArgs e)
        {

        }
    }
}
