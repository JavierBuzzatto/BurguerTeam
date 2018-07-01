using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Papas
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

        public Papas()
        {
            this.precio = 0;
            this.tamaño = 0;
        }
        public Papas(double precio, int tamaño)
        {
            this.precio = precio;
            this.tamaño = tamaño;
        }

        public override string ToString()
        {
            if (tamaño == 0)
                return "Sin papas";
            if (tamaño == 1)
                return "Con papas";
            if (tamaño == 2)
                return "Papas Chicas, $" + this.precio;
            if (tamaño == 3)
                return "Papas Medianas, $" + this.precio;
            if (tamaño == 4)
                return "Papas Grandes, $" + this.precio;
            return "Valor inválido";
        }
    }
}
