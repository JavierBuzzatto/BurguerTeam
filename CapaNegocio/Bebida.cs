using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Bebida
    {
        private string nombre;
        private Tamaño tamaño;
        private double precio;
        private static List<Bebida> bebidas = new List<Bebida>();

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Tamaño Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public static List<Bebida> Bebidas
        {
            get { return bebidas; }
            set { bebidas = value; }
        }

        public Bebida()
        {
            this.nombre = "";
            this.tamaño = null;
            this.precio = 0;
        }
        public Bebida(string nombre, Tamaño tamaño, double precio)
        {
            this.nombre = nombre;
            this.tamaño = tamaño;
            this.precio = precio;
        }
        public Bebida(string nom)
        {
            this.nombre = nom;
        }

        public override string ToString()
        {
            return this.nombre + ", " + this.tamaño + ", $" + this.precio;
        }

        public void Agregar()
        {
            Bebida.Bebidas.Add(this);
        }

        public void Modify(string nombre, Tamaño tamaño, double precio)
        {
            this.nombre = nombre;
            this.tamaño = tamaño;
            this.precio = precio;
        }

        public static List<Bebida> Buscar(string busqueda)
        {
            busqueda = busqueda.ToLower().Trim();
            List<Bebida> resultados = new List<Bebida>();
            if (busqueda != "")
            {
                foreach (Bebida b in Bebidas)
                {
                    if (b.nombre.ToLower().Contains(busqueda))
                    {
                        resultados.Add(b);
                    }
                    if (b.precio.ToString().Contains(busqueda))
                    {
                        resultados.Add(b);
                    }
                }
                return resultados;
            }
            return Bebidas;
        }
        public static List<Bebida> MostrarBebida()
        {
            return Bebida.bebidas;

        }
        public void Eliminar()
        {
            Bebida.Bebidas.Remove(this);
        }
        public static void CargarBebidas()
        {
            new Bebida("Pepsi",new Tamaño("Pequeño"),10).Agregar();
            new Bebida("Pepsi", new Tamaño("Regular"), 15).Agregar();
            new Bebida("Pepsi", new Tamaño("Mediano"), 20).Agregar();
            new Bebida("Pepsi", new Tamaño("Grande"), 25).Agregar();
            new Bebida("Pepsi Light", new Tamaño("Pequeño"),10).Agregar();
            new Bebida("Pepsi Light", new Tamaño("Regular"), 15).Agregar();
            new Bebida("Pepsi Light", new Tamaño("Mediano"), 20).Agregar();
            new Bebida("Pepsi Light", new Tamaño("Grande"), 25).Agregar();
            new Bebida("7up",new Tamaño("Pequeño"), 10).Agregar();
            new Bebida("7up", new Tamaño("Regular"), 15).Agregar();
            new Bebida("7up", new Tamaño("Mediano"), 20).Agregar();
            new Bebida("7up", new Tamaño("Grande"), 25).Agregar();
            new Bebida("7up Light",new Tamaño("Pequeño"), 10).Agregar();
            new Bebida("7up Light", new Tamaño("Regular"), 15).Agregar();
            new Bebida("7up Light", new Tamaño("Mediano"), 20).Agregar();
            new Bebida("7up Light", new Tamaño("Grande"), 25).Agregar();
            new Bebida("Fanta", new Tamaño("Pequeño"), 10).Agregar();
            new Bebida("Fanta", new Tamaño("Regular"), 15).Agregar();
            new Bebida("Fanta", new Tamaño("Mediano"), 20).Agregar();
            new Bebida("Fanta", new Tamaño("Grande"), 25).Agregar();
            new Bebida("Fanta Light", new Tamaño("Pequeño"), 10).Agregar();
            new Bebida("Fanta Light", new Tamaño("Regular"), 15).Agregar();
            new Bebida("Fanta Light", new Tamaño("Mediano"), 20).Agregar();
            new Bebida("Fanta Light", new Tamaño("Grande"), 25).Agregar();
            new Bebida("Paso de los Toros", new Tamaño("Pequeño"), 10).Agregar();
            new Bebida("Paso de los Toros", new Tamaño("Regular"), 15).Agregar();
            new Bebida("Paso de los Toros", new Tamaño("Mediano"), 20).Agregar();
            new Bebida("Paso de los Toros", new Tamaño("Grande"), 25).Agregar();
            new Bebida("H2OH", new Tamaño("Pequeño"), 10).Agregar();
            new Bebida("H2OH", new Tamaño("Regular"), 15).Agregar();
            new Bebida("H2OH", new Tamaño("Mediano"), 20).Agregar();
            new Bebida("H2OH", new Tamaño("Grande"), 25).Agregar();
            new Bebida("Agua", new Tamaño("Pequeño"), 10).Agregar();
            new Bebida("Agua", new Tamaño("Regular"), 15).Agregar();
            new Bebida("Agua", new Tamaño("Mediano"), 20).Agregar();
            new Bebida("Agua", new Tamaño("Grande"), 25).Agregar();
        }
    }
}
