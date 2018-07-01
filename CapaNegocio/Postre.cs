using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Postre
    {
        private string nombre;
        private double precio;
        private static List<Postre> postres = new List<Postre>();

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

        public static List<Postre> Postres
        {
            get
            {
                return postres;
            }

            set
            {
                postres = value;
            }
        }
        public Postre()
        {
            this.nombre = "";
            this.precio = 0;
        }
        public Postre(string nombre, double precio0)
        {
            this.nombre = nombre;
            this.precio = precio0;
        }
        public void Agregar()
        {
            Postre.postres.Add(this);
        }
        public void Eliminar()
        {
            Postre.postres.Remove(this);
        }

        public static List<Postre> Buscar(string buscado)
        {
            buscado = buscado.ToLower().Trim();
            List<Postre> encontrados = new List<Postre>();
            if (buscado != "")
            {
                foreach (Postre m in postres)
                {
                    if (m.nombre.ToString().ToLower().Contains(buscado))
                    {
                        encontrados.Add(m);
                    }
                }
                return encontrados;
            }
            else
            {
                return postres;

            }
        }
        public override string ToString()
        {
            return string.Concat(nombre, precio);
        }

        public static void CargarPostres()
        {
            new Postre("Cono Americana", 20).Agregar();
            new Postre("Cono Dulce De Leche", 20).Agregar();
            new Postre("Cono Mixta", 20).Agregar();
            new Postre("Cono relleno Chocolate", 30).Agregar();
            new Postre("Cono relleno Dulce De Leche", 30).Agregar();
            new Postre("Sundae Frutilla", 40).Agregar();
            new Postre("Sundae Chocolate", 40).Agregar();
            new Postre("Sundae Dulce De Leche", 40).Agregar();
            new Postre("Cucuruchon", 40).Agregar();
            new Postre("Cucuruchon - Rocklets", 40).Agregar();
            new Postre("Cucuruchon - Toddy Chocolat", 40).Agregar();
            new Postre("King Mix", 40).Agregar();
            new Postre("King Mix - Rocklets", 40).Agregar();
            new Postre("King Mix - Toddy Chocolat", 40).Agregar();
        }
        }
}
