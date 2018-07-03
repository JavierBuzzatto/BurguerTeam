using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaUsuario
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ingrediente.CargarIngredientes(); 
            Usuario.CargarUsuarios();
            Tamaño.CargarTamaños(); 
            Postre.CargarPostres(); 
            Bebida.CargarBebidas();
            Hamburguesa.CargarHamburguesas();
            MetodoDePago.CargarMetDePagos();
            //Pedido.cargarPedidos();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormEmpleado());
            //Application.Run(new FormGerente());
            Application.Run(new FormLogin());
        }
    }
}
