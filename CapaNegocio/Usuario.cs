using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Usuario
    {
        #region VARIABLES MIEMBRO
        private string nombre;
        private string apellido;
        private string nombreDeUsuario;
        private string contraseña;
        private Boolean esAdmin;
        private static List<Usuario> usuarios = new List<Usuario>();
        #endregion

        #region PROPIEDADES
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

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        public string NombreDeUsuario
        {
            get
            {
                return nombreDeUsuario;
            }

            set
            {
                nombreDeUsuario = value;
            }

        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }

            set
            {
                contraseña = value;
            }

        }

        public bool EsAdmin
        {
            get
            {
                return esAdmin;
            }

            set
            {
                esAdmin = value;
            }

        }

        public static List<Usuario> Usuarios
        {
            get
            {
                return usuarios;
            }

            set
            {
                usuarios = value;
            }
        }

        #endregion

        #region CONSTRUCTORES
        public Usuario(string nombre, string apellido, string nombreDeUsuario, string contraseña, Boolean esAdmin)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreDeUsuario = nombreDeUsuario;
            this.contraseña = contraseña;
            this.esAdmin = esAdmin;
        }
        private Usuario(string nombre, string apellido, string nombreDeUsuario, string contraseña)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreDeUsuario = nombreDeUsuario;
            this.contraseña = contraseña;
            this.esAdmin = false;
        }

        #endregion

        #region METODOS
        public void Eliminar()
        {
            Usuario.usuarios.Remove(this);
        }
        public void Agregar()
        {
            Usuario.usuarios.Add(this);
        }
        public void Modificar(string nom, string ape, string nomUsu, string cont)
        {
            this.nombre = nom;
            this.apellido = ape;
            this.nombreDeUsuario = nomUsu;
            this.contraseña = cont;
        }
        public static List<Usuario> Buscar(string buscado)
        {
            buscado = buscado.ToLower().Trim();
            List<Usuario> encontrados = new List<Usuario>();
            if (buscado != "")
            {
                foreach(Usuario u in usuarios)
                {
                    if (buscado == "" || u.nombre.ToLower().Contains(buscado) ||
                        u.apellido.ToLower().Contains(buscado) ||
                        u.nombreDeUsuario.ToLower().Contains(buscado))
                    {
                        encontrados.Add(u);
                    }
                }
                return encontrados;
            }
            return usuarios;
        }
        public static List<Usuario> Mostrar()
        {
            return Usuario.usuarios;
        }
        public override string ToString()
        {
            return string.Concat(nombre, apellido, nombreDeUsuario);
        }
        public static void CargarUsuarios()
        {
            new Usuario("Juan", "Cabrera", "x", "123456", true).Agregar();
            new Usuario("Jorge", "Campos", "z", "123456").Agregar();
            new Usuario("Mario", "Gonzalez", "mariogonzalez", "123456").Agregar();
            new Usuario("Daniel", "Hernandez", "danielhernandez", "123456").Agregar();
            new Usuario("Diego", "Fernandez", "diegofernandez", "123456").Agregar();
            new Usuario("Roberto", "Afflitto", "robertoafflitto", "654321").Agregar();
            new Usuario("Javier", "Cirio", "javiercirio", "654321").Agregar();
            new Usuario("Carlos", "Damiano", "carlosdamiano", "654321").Agregar();
            new Usuario("Lorena", "Ricci", "lorenaricci", "654321").Agregar();
            new Usuario("Agustina", "Ali", "agustinaali", "654321").Agregar();
        }
        #endregion

    }
}
       