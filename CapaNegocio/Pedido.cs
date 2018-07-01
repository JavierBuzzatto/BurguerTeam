using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Pedido
    {
        private List<Combo> combos = new List<Combo>();
        private double precio;
        private MetodoDePago metodoDePago; 
        DateTime fecha;
        private static List<Pedido> pedidos = new List<Pedido>();

       


        public double Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

 

        public static List<Pedido> Pedidos
        {
            get
            {
                return pedidos;
            }

            set
            {
                pedidos = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }


        public List<Combo> Combos
        {
            get
            {
                return combos;
            }

            set
            {
                combos = value;
            }
        }

        public MetodoDePago MetodoDePago
        {
            get
            {
                return metodoDePago;
            }

            set
            {
                metodoDePago = value;
            }
        }

        public Pedido()
        {
            this.combos = null;
            this.precio = 0;
            this.MetodoDePago = null;
            this.fecha = DateTime.Today;
        }
        public Pedido(List<Combo>combos,  double precio, MetodoDePago metodoDePago)
        {
            this.combos = combos;
            this.precio = precio;
            this.MetodoDePago = metodoDePago;
            this.Fecha = DateTime.Today;
        }

        public static List<Pedido> Buscar(string buscado)
        {
            buscado = buscado.ToLower().Trim();
            List<Pedido> encontrados = new List<Pedido>();
            if (buscado != "")
            {
                foreach (Pedido p in pedidos)
                {
                    if (
                       p.precio.ToString().ToLower().Contains(buscado) ||
                        p.MetodoDePago.ToString().ToLower().Contains(buscado))
                    {
                        encontrados.Add(p);
                    }
                }
                return encontrados;
            }
            else
            {
                return pedidos;

            }
        }
        public void Agregar()
        {
            pedidos.Add(this);
        }
        public void Quitar()
        {
            pedidos.Remove(this);
        }
        public override string ToString()
        {
            return string.Concat(combos, precio, MetodoDePago);
        }
/*
        public static void cargarPedidos()
        {
            new Pedido(Hamburguesa.Hamburguesas[1],"",20,"Debito").Agregar();
            new Pedido(Hamburguesa.Hamburguesas[1], "", 20, "Debito").Agregar();
            new Pedido(Hamburguesa.Hamburguesas[3], "", 50, "Credito").Agregar();
            new Pedido(Hamburguesa.Hamburguesas[2], "", 25, "Efectivo").Agregar();
            new Pedido(Hamburguesa.Hamburguesas[0], "", 70, "Efectivo").Agregar();
        }*/
    }
}