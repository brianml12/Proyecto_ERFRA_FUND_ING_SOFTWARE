using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Empleado
    {
        public int IDEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string NombreUsuario { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        public string Genero { get; set; }
        public string Rol { get; set; }

        public Empleado(string usuario, string password) { 
            this.NombreUsuario = usuario;
            this.Password = password;
        }

        public Empleado() {}
    }
}
