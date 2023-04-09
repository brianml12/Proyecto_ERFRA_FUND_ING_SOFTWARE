using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Datos
{
    public class DAORegistro
    {
        public bool validacionNombres(String nombre)
        {
            Regex regex = new Regex(@"[A-Za-z]+");
            if (nombre.Equals("Nombre")||nombre.Equals("Apellido")) return false;
            else if (nombre.Equals("")) return false;
            else if (regex.IsMatch(nombre)) return true;
            else return false;
        }

        public bool validacionTexto(String texto)
        {
            Regex regex = new Regex(@"[A-Za-z]+([\s]+)*");
            if (texto.Equals("Contraseña")|| texto.Equals("Usuario")) return false;
            else if (regex.IsMatch(texto)) return true;
            else return false;
        }

        public bool validacionConfirmacion(String c1, String c2)
        {
            if (c1.Equals(c2)) return true;
            else return false;
        }

        public bool validacionCorreo(String correo)
        {
            Regex expresion = new Regex(@"\A[^\s@]+@[^\s@]+\.[^\s@]+\Z");
            if (correo.Equals("Correo")) return false;
            else if (expresion.IsMatch(correo)) return true;
            else return false;
        }

        public bool VerPassword(bool status)
        {
            if (status == false) return true;
            else return false;
        }
    }
}
