using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Ingrediente
    {
        private string nombre;
        private bool siono;
        private static List<Ingrediente> ingredientes = new List<Ingrediente>();

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

        public bool Siono
        {
            get
            {
                return siono;
            }

            set
            {
                siono = value;
            }
        }

       

        public static List<Ingrediente> Ingredientes
        {
            get
            {
                return ingredientes;
            }

            set
            {
                ingredientes = value;
            }
        }
        public Ingrediente()
        {
            this.nombre = null;
            this.siono = false;
        }
        public Ingrediente(string nombre, bool siono)
        {
            this.nombre = nombre;
            this.siono = siono;

        }
        public static List<Ingrediente> Buscar(string buscado)
        {
            buscado = buscado.Trim().ToLower();
            List<Ingrediente> encontrados = new List<Ingrediente>();
            if (buscado != "")
            {
                foreach (Ingrediente m in ingredientes)
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
                return ingredientes;

            }
         }
    

        
        public void Agregar()
        {
            ingredientes.Add(this);
        }
        public void Quitar()
        {
            ingredientes.Remove(this);
        }
        public override string ToString()
        {
            return string.Concat(nombre, siono);
        }
        public static void CargarIngredientes()
        {
            new Ingrediente("Queso", false).Agregar();
            new Ingrediente("Jamon", false).Agregar();
            new Ingrediente("Salsa", false).Agregar();
            new Ingrediente("Beacon", false).Agregar();
            new Ingrediente("Cebolla", false).Agregar();
            new Ingrediente("Tomate", false).Agregar();
            new Ingrediente("Lechuga", false).Agregar();
            new Ingrediente("Pepino", false).Agregar();
        } 

    }
}
