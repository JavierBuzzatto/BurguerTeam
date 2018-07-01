using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Combo
    {
        private string tamaño;
        //   private double precio;
        Bebida bebida;
        private Papas papas;
        private ArosDeCebolla arosDeCebolla;
        private Hamburguesa hamburguesa;
        
        private static List<Combo> combos = new List<Combo>();

        public Hamburguesa Hamburguesa
        {
            get { return hamburguesa; }
            set { hamburguesa = value; }
        }
 
       /* public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }*/
 
        public Papas Papas
        {
            get { return papas; }
            set { papas = value; }
        }

        public ArosDeCebolla ArosDeCebolla
        {
            get { return arosDeCebolla; }
            set { arosDeCebolla = value; }
        }
        public static List<Combo> Combos
        {
            get { return combos; }
            set { combos = value; }
        }

        public string Tamaño
        {
            get
            {
                return tamaño;
            }

            set
            {
                tamaño = value;
            }
        }

        public Bebida Bebida
        {
            get
            {
                return bebida;
            }

            set
            {
                bebida = value;
            }
        }

        public Combo()
        {
            this.Tamaño = null;
         //   this.precio = 0;
            this.papas = null;
            this.arosDeCebolla = null;
            this.hamburguesa = null;
        }

        public Combo(string tamaño,Bebida bebida,Papas papas, ArosDeCebolla arosDeCebolla, Hamburguesa hamburguesa)
        {
            this.tamaño = tamaño;
            this.bebida = bebida;
       //     this.precio = precio;
            this.papas = papas;
            this.arosDeCebolla = arosDeCebolla;
            this.hamburguesa = hamburguesa;
        }
        public void Modify(string tamaño,Bebida bebida, Papas papas, ArosDeCebolla arosDeCebolla, Hamburguesa hamburguesa)
        {
            this.tamaño = tamaño;
            this.bebida = bebida;
       //     this.precio = precio;
            this.papas = papas;
            this.arosDeCebolla = arosDeCebolla;
            this.hamburguesa = hamburguesa;
        }
        public static void cargarCombos()
        {
            new Combo("pequeño",
                new Bebida(),
                new Papas(20.5,2), 
                new ArosDeCebolla(30,2),
                Hamburguesa.Hamburguesas[0] 
                ).Guardar();
        }
     /*  public double PrecioTotal()
        {
            double precio;
            double precioBebidas=0;
            
            return precio = papas.Precio  + precioBebidas + arosDeCebolla.Precio;
        }

        public override string ToString()
        {
            string strBebidas="";
            foreach (Bebida b in Bebs)
            {
                strBebidas += ", " + b.ToString();
            }
            return this.Tamaño.ToString() + ", " + strBebidas + ", " + this.papas.ToString() + ", " + this.arosDeCebolla.ToString();
        }*/

        public void Guardar()
        {
            Combo.Combos.Add(this);
        }

        public static List<Combo> MostrarCombos()
        {
            return Combo.Combos;
        }

        public void Eliminar()
        {
            Combo.Combos.Remove(this);
        }
    }
}
