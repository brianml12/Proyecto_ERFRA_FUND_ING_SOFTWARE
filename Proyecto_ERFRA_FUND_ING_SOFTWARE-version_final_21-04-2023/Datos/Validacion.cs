using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Datos {
    public class Validacion {
        /// <summary>
        /// Expresión regular usada para determinar si la entrada es un número
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Retorna true si la entrada es número y false en caso contrario</returns>
        public bool esNumero(string input) {
            Regex expresion = new Regex("^[0-9]{1,10}([.][0-9]{1,10})?$");
            if (expresion.IsMatch(input)) return true;
            else return false;
        }

        /// <summary>
        /// Expresión regular usada para determinar si la entrada es un número entero
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Retorna true si la entrada es número entero y false en caso contrario</returns>
        public bool esNumeroEntero(string input) {
            Regex expresion = new Regex(@"\A[0-9]{1,10}\Z");
            if (expresion.IsMatch(input)) return true;
            else return false;
        }

        /// <summary>
        /// Expresión regular usada para determinar si la entrada es un número decimal
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Retorna true si la entrada es número decimal y false en caso contrario</returns>
        public bool esNumeroDecimal(string input) {
            Regex expresion = new Regex(@"\A[0-9]{1,10}[.]*[0-9]{1,10}\Z");
            if (expresion.IsMatch(input)) return true;
            else return false;
        }

        /// <summary>
        /// Expresión regular usada para determinar si la entrada es un nombre de pila válido
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>Retorna true si la entrada es un nombre de pila válido y un false en caso contrario</returns>
        public bool validacionNombres(String nombre) {
            Regex regex = new Regex(@"[A-Za-z]+");
            if (nombre.Equals("Nombre") || nombre.Equals("Apellido")) return false;
            else if (nombre.Equals("")) return false;
            else if (regex.IsMatch(nombre)) return true;
            else return false;
        }

        /// <summary>
        /// Expresión regular usada para determinar si la entrada es texto válido
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>Retorna true si la entrada es un texto válido y false en caso contrario</returns>
        public bool validacionTexto(String texto) {
            Regex regex = new Regex(@"[A-Za-z]+([\s]+)*");
            if (texto.Equals("Contraseña") || texto.Equals("Usuario") || texto.Equals("Dirección") || texto.Equals("Nombre de Material") || texto.Equals("Color") || texto.Equals("Tipo de Material")) return false;
            else if (texto.Equals("")) return false;
            else if (regex.IsMatch(texto)) return true;
            else return false;
        }

        /// <summary>
        /// Expresión regular usada para determinar si un correo electrónico es válido
        /// </summary>
        /// <param name="correo"></param>
        /// <returns>Regresa true si la entrada es un correo válido y false en caso contrario</returns>
        public bool validacionCorreo(String correo) {
            Regex expresion = new Regex(@"\A[^\s@]+@[^\s@]+\.[^\s@]+\Z");
            if (correo.Equals("Correo")) return false;
            else if (expresion.IsMatch(correo)) return true;
            else return false;
        }

        /// <summary>
        /// Método usado para ver el password de una caja de texto
        /// </summary>
        /// <param name="status"></param>
        /// <returns>Retorna true si se puede ver la contraseña y false si no</returns>
        public bool VerPassword(bool status) {
            if (status == false) return true;
            else return false;
        }

        /// <summary>
        /// Método usado para determinar si dos contraseñas son iguales
        /// </summary>
        /// <param name="pass1"></param>
        /// <param name="pass2"></param>
        /// <returns>Retorna true si las contraseñas coinciden y false si no es así</returns>
        public bool passwordsIguales(string pass1, string pass2) {
            if (pass1.Equals(pass2)) return true;
            return false;
        }

        /// <summary>
        /// Método usado para saber si una contraseña cumple la caracteristica de ser mayor o igual a 8 caracteres
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Retorna true si la contraseña es mayor o igual a 8 caracteres</returns>
        public bool password(string input) {
            if (input.Length>=8) return true;
            else return false;
        }

        /// <summary>
        /// Expresión regular para determinar si un número de teléfono es válido
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Retorna true si un número de teléfono es válido</returns>
        public bool esTelefono(string input) {
            Regex expresion = new Regex(@"\A[0-9]{10}\Z");
            if (expresion.IsMatch(input)) return true;
            else return false;
        }

        /// <summary>
        /// Expresión regular usada para saber si un material cumple con la regla de tener de un código con 10 digitos
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Retorna true si el código del material es de 10 digitos</returns>
        public bool esCodigoMaterial(String input) {
            Regex regex = new Regex(@"\A[0-9]{10}\Z");
            if (input.Equals("Codigo Material")) return false;
            else if (input.Equals("")) return false;
            else if (regex.IsMatch(input)) return true;
            else return false;
        }

        /// <summary>
        /// Método para determinar si cierta cantidad es mayor a 0
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Retorna true si la cantidad es mayor a 0 y false en caso contrario</returns>
        public bool esCantidadMayorCero(String input) {
            bool isNumeric = input.All(char.IsDigit);
            if (isNumeric==true) return true;
            else return false;
        }

        /// <summary>
        /// Método para determinar que la cantidad de prendas es la establecida (20-500 prendas inclusive)
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Retorna true en caso de que el valor sea valido y false en caso contrario</returns>
        public bool cantidadPrendasValida(string value) {
            int number;
            int.TryParse(value, out number);
            if (number >= 20 && number <= 500) return true;
            return false;
        }

    }
}
