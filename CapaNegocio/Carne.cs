using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Carne
    {
        private string nombre;
        private static List<Carne> carnes = new List<Carne>();

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public static List<Carne> Carnes
        {
            get
            {
                return carnes;
            }

            set
            {
                carnes = value;
            }
        }
        public Carne()
        {
            this.nombre = null;

        }
        public Carne(string nombre)
        {
            this.nombre = nombre;

        }
        public static List<Carne> Buscar(string buscado)
        {
            buscado = buscado.ToLower().Trim();
            List<Carne> encontrados = new List<Carne>();
            if (buscado != "")
            {
                foreach (Carne m in carnes)
                {
                    if (m.nombre.ToLower().Contains(buscado))
                    {
                        encontrados.Add(m);
                    }
                }
                return encontrados;
            }
            else
            {
                return carnes;

            }

        }
        public void Agregar()
        {
            carnes.Add(this);

        }
        public void Quitar()
        {
            carnes.Remove(this);
        }
        public override string ToString()
        {
            return string.Concat(nombre);
        }
        public static void CargarCarnes()
        {
            new Carne("vacuna").Agregar();
            new Carne("pollo").Agregar();
            new Carne("soja").Agregar();
            new Carne("churrasco").Agregar();
        }
        }
}
