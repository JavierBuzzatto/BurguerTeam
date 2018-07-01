using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Nuggets
    {
        private double precioTotal;
        private int cantidad;
        private static List<Nuggets> nuggetss = new List<Nuggets>();

        public double PrecioTotal
        {
            get { return precioTotal; }
            set { precioTotal = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public static List<Nuggets> Nuggetss
        {
            get { return nuggetss; }
            set { nuggetss = value; }
        }

        public Nuggets()
        {
            this.precioTotal = 0;
            this.cantidad = 0;
        }
        public Nuggets(int cantidad,double precioTotal)
        {
            this.precioTotal = precioTotal;
            this.cantidad = cantidad;
        }


        public override string ToString()
        {
            return this.cantidad + " Nuggets, $" + this.precioTotal;
        }

        public void Agregar()
        {
            Nuggets.Nuggetss.Add(this);
        }
        public static List<Nuggets> MostrarNuggets()
        {
            return Nuggets.nuggetss;

        }
        public void Eliminar()
        {
            Nuggets.Nuggetss.Remove(this);
        }
        public static void CargarNuggets()
        {
            new Nuggets(5, 10).Agregar();
            new Nuggets(6, 12).Agregar();
            new Nuggets(9, 15).Agregar();
            new Nuggets(12, 20).Agregar();

        }
    }
}
