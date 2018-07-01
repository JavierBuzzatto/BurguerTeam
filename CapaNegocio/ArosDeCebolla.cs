 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ArosDeCebolla
    {

        private double precio;
        private int tamaño;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }

        public ArosDeCebolla()
        {
            this.precio = 0;
            this.tamaño = 0;
        }
        public ArosDeCebolla(double precio, int tamaño)
        {
            this.precio = precio;
            this.tamaño = tamaño;
        }

        public override string ToString()
        {
            if (tamaño == 0)
                return "Sin Aros";
            if (tamaño == 1)
                return "Con Aros";
            if (tamaño == 2)
                return "Aros Chicas, $" + this.precio;
            if (tamaño == 3)
                return "Aros Medianas, $" + this.precio;
            if (tamaño == 4)
                return "Aros Grandes, $" + this.precio;
            return "Valor inválido";
        }
    }
}
