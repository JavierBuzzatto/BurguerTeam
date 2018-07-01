using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Tamaño
    {
        private string nombre;
        private static List<Tamaño> tamaños = new List<Tamaño>();

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public static List<Tamaño> Tamaños
        {
            get { return tamaños; }
            set { tamaños = value; }
        }

        public Tamaño()
        {
            this.nombre = "";
        }
        public Tamaño(string nombre)
        {
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public void Guardar()
        {
            Tamaño.Tamaños.Add(this);
        }

        public static List<Tamaño> Buscar()
        {
            return Tamaño.Tamaños;
        }

        /* public static List<Tamaño> Buscar(string busqueda)
         {
             busqueda = busqueda.ToLower().Trim();
             List<Tamaño> resultados = new List<Tamaño>();
             if (busqueda != "")
             {
                 foreach (Tamaño b in Tamaños)
                 {
                     if (b.nombre.ToLower().Contains(busqueda))
                     {
                         resultados.Add(b);
                     }
                 }
                 return resultados;
             }
             return Tamaños;
         }

         public void Eliminar()
         {
             Tamaño.Tamaños.Remove(this);
         }*/
        public static void CargarTamaños()
        {
            new Tamaño("Regular").Guardar();
            new Tamaño("Pequeño").Guardar();
            new Tamaño("Mediano").Guardar();
            new Tamaño("Grande").Guardar();
        }
    }
}
