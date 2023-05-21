using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos {
    public class DAOLogin {
        /// <summary>
        /// Método usado para ver la contraseña de un campo
        /// </summary>
        /// <param name="status"></param>
        /// <returns>Retorna true si se puede visualizar, false en caso contrario</returns>
        public bool VerPassword(bool status) {
            if (status == false) return true;
            else return false;
        }
    }
}
