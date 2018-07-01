using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Hamburguesa
    {
        private string nombre;
        private Carne tipoDeCarne;
        private double precio;
        /*private List <Ingrediente> listaIngrediente;*/
        private string ingredientes;
        private static List<Hamburguesa> hamburguesas = new List<Hamburguesa>();


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


        public string Ingredientes
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

        public Carne TipoDeCarne
        {
            get
            {
                return tipoDeCarne;
            }

            set
            {
                tipoDeCarne = value;
            }
        }

        public static List<Hamburguesa> Hamburguesas
        {
            get
            {
                return hamburguesas;
            }

            set
            {
                hamburguesas = value;
            }
        }

        public Hamburguesa()
        {
            this.nombre = null;
            this.TipoDeCarne = null;
            this.precio = 0;
            /*this.listaIngrediente = null;*/
            this.Ingredientes = null;
        }
        public Hamburguesa(string nombre, Carne carne, double precio,/*List<Ingrediente> x,*/ string ingrediente)
        {
            this.nombre = nombre;
            this.TipoDeCarne = carne;
            this.precio = precio;
            /*this.listaIngrediente = x;*/
            this.Ingredientes = ingrediente; ;
        }

        public void Modify(string nombre, Carne carne, double precio, string ingrediente)
        {
            this.nombre = nombre;
            this.TipoDeCarne = carne;
            this.precio = precio;
            this.ingredientes = ingrediente;
        }
        public static List<Hamburguesa> Devolveme(string buscado)
        {
            buscado = buscado.ToLower().Trim();
            List<Hamburguesa> encontrados = new List<Hamburguesa>();
            string[] hamb = buscado.Split(' ');
            foreach (string s in hamb)
            {
                if (s != "")
                {
                    foreach (Hamburguesa m in hamburguesas)
                    {
                        if (m.nombre.ToLower().Contains(s) || s.Contains(m.nombre.ToLower()))
                        {
                            encontrados.Add(m);
                        }
                    }

                }
            }
            return encontrados;
        }

        public static List<Hamburguesa> Buscar(string buscado)
        {
            buscado = buscado.ToLower().Trim();
            List<Hamburguesa> encontrados = new List<Hamburguesa>();
            if (buscado != "")
            {
                foreach (Hamburguesa m in hamburguesas)
                {
                    if (m.nombre.ToLower().Contains(buscado) || buscado.Contains(m.nombre.ToLower()))
                    {
                        encontrados.Add(m);
                    }
                }
                return encontrados;
            }
            else
            {
                return Hamburguesas;

            }

        }

        public static List<Hamburguesa> MostrarHamburguesa()
        {
            return Hamburguesa.Hamburguesas;
        }
        public void Agregar()
        {
            Hamburguesas.Add(this);

        }
        public void Quitar()
        {
            Hamburguesas.Remove(this);
        }
        public override string ToString()
        {
            return string.Concat(nombre,' ', TipoDeCarne,' ', precio,' ', Ingredientes, ' ');
        }

        public static void CargarHamburguesas()
        {
            new Hamburguesa("long clasico", new Carne("vacuna"), 50, "tomate,salsa cheddar,lechuga,mayonesa").Agregar();//0
            new Hamburguesa("long jamon y queso", new Carne("vacuna"), 50, "jamon,salsa cheddar").Agregar();//1
            new Hamburguesa("long bbq", new Carne("vacuna"), 50, "salsa bbq,salsa cheddar,aros de cebolla").Agregar();//2
            new Hamburguesa("hamburguesa simple", new Carne("vacuna"), 30, "no tiene").Agregar();//3
            new Hamburguesa("hamburguesa con queso", new Carne("vacuna"), 35, "queso,aderesos").Agregar();//4
            new Hamburguesa("napolitano", new Carne("vacuna"), 35, "tomate,queso cheddar,jamon").Agregar();//5
            new Hamburguesa("extra burguer", new Carne("vacuna"), 70, "queso,bacon,aderesos").Agregar();//6
            new Hamburguesa("big king", new Carne("vacuna"), 50, "queso chedddar,lechuga,pepino,cebolla,salsa").Agregar();//7
            new Hamburguesa("stacker triple", new Carne("vacuna"), 80, "queso,bacon,adereso").Agregar();//8
            new Hamburguesa("stacker cuadruple", new Carne("vacuna"), 90, "queso,bacon,adereso").Agregar();//9
            new Hamburguesa("whopper", new Carne("vacuna"), 60, "tomate,lechuga fresca, cebolla,pepinillos,ketchup,mayonesa").Agregar();//10
            new Hamburguesa("whopper doble", new Carne("vacuna"), 80, "tomate,lechuga,cebolla,pepinillos,ketchup,mayonesa").Agregar();//11
            new Hamburguesa("whopper extreme", new Carne("vacuna"), 100, "tomate,lechuga,cebolla,pepinillos,bacon,queso,ketchup,mayonesa").Agregar();//12
            new Hamburguesa("whopper jr", new Carne("vacuna"), 50, "tomate,lechuga,cebolla,pepinillos,ketchup,mayonesa").Agregar();//13
            new Hamburguesa("long onion cheddar", new Carne("vacuna"), 50, "salsa cheddar,cebolla,mayonesa").Agregar();//14
            new Hamburguesa("stacker Atomic", new Carne("vacuna"), 100, "bacon,queso,aderezos").Agregar();//15
            new Hamburguesa("big king pollo", new Carne("pollo"), 50, "queso chedddar,lechuga,pepino,cebolla,salsa").Agregar();//16
            new Hamburguesa("king de pollo", new Carne("pollo"), 60, "lechuga,mayonesa").Agregar();//17
            new Hamburguesa("king de pollo frances", new Carne("pollo"), 50, "queso,jamon,mayonesa").Agregar();//18
            new Hamburguesa("churrasquito tradicional", new Carne("churrasco"), 80, "lechuga,tomate,queso cheddar").Agregar();//19
            new Hamburguesa("churrasquito pampeano", new Carne("churrasco"), 80, "jamon,tomate,queso cheddar").Agregar();//20
            new Hamburguesa("soja bio", new Carne("soja"), 90, "lechuga,tomate,queso cheddar,mayonesa").Agregar();//21
            new Hamburguesa("extra burguer xl", new Carne("vacuna"), 70, "queso,bacon,aderesos").Agregar();//22
            new Hamburguesa("hamburguesa con jamon y queso", new Carne("vacuna"), 35, "queso,jamon,aderesos").Agregar();//23
            /*new Hamburguesa("long bbq", new Carne("vacuna", 20), 50, new List<Ingrediente> { new Ingrediente("salsa bbq", true), new Ingrediente("aros de cebolla", true), new Ingrediente("queso cheddar", true) }).Agregar();
            new Hamburguesa("hamburguesa simple", new Carne("vacuna", 20), 30, new List<Ingrediente> { }).Agregar();
            new Hamburguesa("hamburguesa con queso", new Carne("vacuna", 20), 35, new List<Ingrediente> { new Ingrediente("queso", true), new Ingrediente("aderezos", true) }).Agregar();
            new Hamburguesa("napolitano", new Carne("vacuna", 20), 35, new List<Ingrediente> { new Ingrediente("tomate", true), new Ingrediente("aderezos", true), new Ingrediente("queso cheddar", true) }).Agregar();
            new Hamburguesa("extra burguer", new Carne("vacuna", 20), 50, new List<Ingrediente> { new Ingrediente("queso", true), new Ingrediente("bacon", true), new Ingrediente("aderezos", true) }).Agregar();
            new Hamburguesa("big king", new Carne("vacuna", 20), 50, new List<Ingrediente> { new Ingrediente("lechuga", true), new Ingrediente("cebolla", true), new Ingrediente("queso cheddar", true), new Ingrediente("pepino", true), new Ingrediente("salsa", true) }).Agregar();
            new Hamburguesa("stacker triple", new Carne("vacuna", 20), 70, new List<Ingrediente> { new Ingrediente("queso", true), new Ingrediente("bacon", true), new Ingrediente("aderezos", true) }).Agregar();
            new Hamburguesa("stacker cuadruple", new Carne("vacuna", 20), 80, new List<Ingrediente> { new Ingrediente("salsa bbq", true), new Ingrediente("aros de cebolla", true), new Ingrediente("queso cheddar", true) }).Agregar();
            new Hamburguesa("whopper", new Carne("vacuna", 20), 80, new List<Ingrediente> { new Ingrediente("tomate", true), new Ingrediente("lechuga", true), new Ingrediente("cebolla", true), new Ingrediente("pepino", true) }).Agregar();
            new Hamburguesa("whopper doble", new Carne("vacuna", 20), 80, new List<Ingrediente> { new Ingrediente("salsa bbq", true), new Ingrediente("aros de cebolla", true), new Ingrediente("queso cheddar", true), new Ingrediente("aderezos", true) }).Agregar();
            new Hamburguesa("whopper extreme", new Carne("vacuna", 20), 90, new List<Ingrediente> { new Ingrediente("salsa bbq", true), new Ingrediente("aros de cebolla", true), new Ingrediente("queso cheddar", true), new Ingrediente("aderezos", true), new Ingrediente("queso", true), new Ingrediente("bacon", true) }).Agregar();
            new Hamburguesa("whopper jr", new Carne("vacuna", 20), 60, new List<Ingrediente> { new Ingrediente("salsa bbq", true), new Ingrediente("aros de cebolla", true), new Ingrediente("queso cheddar", true), new Ingrediente("aderezos", true) }).Agregar();
            new Hamburguesa("long onion cheddar", new Carne("vacuna", 20), 50, new List<Ingrediente> { new Ingrediente("salsa cheddar", true), new Ingrediente("cebolla", true), new Ingrediente("aderezos", true) }).Agregar();
            new Hamburguesa("stacker Atomic", new Carne("vacuna", 20), 100, new List<Ingrediente> { new Ingrediente("queso", true), new Ingrediente("bacon", true), new Ingrediente("aderezos", true) }).Agregar();
            new Hamburguesa("big king pollo", new Carne("pollo"), 60, new List<Ingrediente> { new Ingrediente("queso cheddar", true), new Ingrediente("lechuga", true), new Ingrediente("pepino", true), new Ingrediente("cebolla", true), new Ingrediente("salsa", true) }).Agregar();
            new Hamburguesa("king de pollo", new Carne("pollo"), 60, new List<Ingrediente> { new Ingrediente("lechuga", true), new Ingrediente("aderezos", true) }).Agregar();
            new Hamburguesa("king de pollo frances", new Carne("pollo"), 50, new List<Ingrediente> { new Ingrediente("queso", true), new Ingrediente("jamon", true), new Ingrediente("aderezos", true) }).Agregar();
            new Hamburguesa("churrasquito tradicional", new Carne("churrasco", 25), 80, new List<Ingrediente> { new Ingrediente("lechuga", true), new Ingrediente("tomate", true), new Ingrediente("queso cheddar", true) }).Agregar();
            new Hamburguesa("churrasquito pampeano", new Carne("churrasco"), 80, new List<Ingrediente> { new Ingrediente("queso cheddar", true), new Ingrediente("jamon", true), new Ingrediente("tomate", true) }).Agregar();
            new Hamburguesa("soja bio", new Carne("soja", 30), 90, new List<Ingrediente> { new Ingrediente("lechuga", true), new Ingrediente("queso cheddar", true), new Ingrediente("tomate", true), new Ingrediente("aderezos", true) }).Agregar();
            /*
            new Hamburguesa("long clasico", new Carne("vacuna", 20), 50, new List<Ingrediente> { new Ingrediente("tomate", true), new Ingrediente("lechuga", true), new Ingrediente("aderezos", true) }).Agregar();
            new Hamburguesa("long jamon y queso", new Carne("vacuna", 20), 50, new List<Ingrediente> { new Ingrediente("jamon", true), new Ingrediente("salsa cheddar", true) }).Agregar();
            new Hamburguesa("long bbq", new Carne("vacuna", 20), 50, new List<Ingrediente> { new Ingrediente("salsa bbq", true), new Ingrediente("aros de cebolla", true), new Ingrediente("queso cheddar", true) }).Agregar();
            new Hamburguesa("hamburguesa simple", new Carne("vacuna", 20), 30, new List<Ingrediente> { }).Agregar();
            new Hamburguesa("hamburguesa con queso", new Carne("vacuna", 20), 35, new List<Ingrediente> { new Ingrediente("queso", true), new Ingrediente("aderezos", true) }).Agregar();
            new Hamburguesa("napolitano", new Carne("vacuna", 20), 35, new List<Ingrediente> { new Ingrediente("tomate", true), new Ingrediente("aderezos", true), new Ingrediente("queso cheddar", true) }).Agregar();
            new Hamburguesa("extra burguer", new Carne("vacuna", 20), 50, new List<Ingrediente> { new Ingrediente("queso", true), new Ingrediente("bacon", true), new Ingrediente("aderezos", true) }).Agregar();
            new Hamburguesa("big king", new Carne("vacuna", 20), 50, new List<Ingrediente> { new Ingrediente("lechuga", true), new Ingrediente("cebolla", true), new Ingrediente("queso cheddar", true), new Ingrediente("pepino", true), new Ingrediente("salsa", true) }).Agregar();
            new Hamburguesa("stacker triple", new Carne("vacuna", 20), 70, new List<Ingrediente> { new Ingrediente("queso", true), new Ingrediente("bacon", true), new Ingrediente("aderezos", true) }).Agregar();
            new Hamburguesa("stacker cuadruple", new Carne("vacuna", 20), 80, new List<Ingrediente> { new Ingrediente("salsa bbq", true), new Ingrediente("aros de cebolla", true), new Ingrediente("queso cheddar", true) }).Agregar();
            new Hamburguesa("whopper", new Carne("vacuna", 20), 80, new List<Ingrediente> { new Ingrediente("tomate", true), new Ingrediente("lechuga", true), new Ingrediente("cebolla", true) , new Ingrediente("pepino", true) }).Agregar();
            new Hamburguesa("whopper doble", new Carne("vacuna", 20), 80, new List<Ingrediente> { new Ingrediente("salsa bbq", true), new Ingrediente("aros de cebolla", true), new Ingrediente("queso cheddar", true),new Ingrediente("aderezos",true) }).Agregar();
            new Hamburguesa("whopper extreme", new Carne("vacuna", 20), 90, new List<Ingrediente> { new Ingrediente("salsa bbq", true), new Ingrediente("aros de cebolla", true), new Ingrediente("queso cheddar", true), new Ingrediente("aderezos", true),new Ingrediente("queso",true),new Ingrediente("bacon",true) }).Agregar();
            new Hamburguesa("whopper jr", new Carne("vacuna", 20), 60, new List<Ingrediente> { new Ingrediente("salsa bbq", true), new Ingrediente("aros de cebolla", true), new Ingrediente("queso cheddar", true), new Ingrediente("aderezos", true) }).Agregar();
            new Hamburguesa("long onion cheddar", new Carne("vacuna", 20), 50, new List<Ingrediente> { new Ingrediente("salsa cheddar", true), new Ingrediente("cebolla", true), new Ingrediente("aderezos", true) }).Agregar();
            new Hamburguesa("stacker Atomic", new Carne("vacuna", 20), 100, new List<Ingrediente> { new Ingrediente("queso", true), new Ingrediente("bacon", true), new Ingrediente("aderezos", true) }).Agregar();
            new Hamburguesa("big king pollo", new Carne("pollo"), 60, new List<Ingrediente> { new Ingrediente("queso cheddar", true), new Ingrediente("lechuga", true), new Ingrediente("pepino", true), new Ingrediente("cebolla", true), new Ingrediente("salsa", true) }).Agregar();
            new Hamburguesa("king de pollo", new Carne("pollo"), 60, new List<Ingrediente> { new Ingrediente("lechuga", true), new Ingrediente("aderezos", true) }).Agregar();
            new Hamburguesa("king de pollo frances", new Carne("pollo"), 50, new List<Ingrediente> { new Ingrediente("queso", true),new Ingrediente("jamon",true), new Ingrediente("aderezos", true) }).Agregar();
            new Hamburguesa("churrasquito tradicional", new Carne("churrasco", 25), 80, new List<Ingrediente> { new Ingrediente("lechuga", true), new Ingrediente("tomate", true), new Ingrediente("queso cheddar", true) }).Agregar();
            new Hamburguesa("churrasquito pampeano", new Carne("churrasco"), 80, new List<Ingrediente> { new Ingrediente("queso cheddar", true), new Ingrediente("jamon", true), new Ingrediente("tomate", true) }).Agregar();
            new Hamburguesa("soja bio", new Carne("soja", 30), 90, new List<Ingrediente> { new Ingrediente("lechuga", true), new Ingrediente("queso cheddar", true), new Ingrediente("tomate", true),new Ingrediente("aderezos",true) }).Agregar();

        }*/ //javier pidio 2 strings en vez de la lista de ingredientes. lo de dicha lista esta comentado, y todo este metodo hay que modificarlo. ademas, tomas se la come
        }
    }
}
