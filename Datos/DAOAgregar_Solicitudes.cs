using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAOAgregar_Solicitudes
    {
        //Variables para la barra de progreso
        int total = 0;
        int campo1 = 0;
        int campo2 = 0;
        int campo3 = 0;
        int campo4 = 0;
        int campo5 = 0;

        public String progresoPR(String texto)
        {
            if (texto.Equals(""))
            {
                if (campo1 != 0)
                {
                    campo1 = campo1 - 20;
                    total = total - 20;
                    return total + "";
                }
                return total + "";
            }
            else
            {
                if (texto.Equals("Prenda"))
                {
                    return total + "";
                }
                else if (campo1 != 20)
                {
                    campo1 = campo1 + 20;
                    total = total + campo1;
                    return total + "";
                }
                return total + "";
            }
        }
        public  String progresoPU(String texto)
        {
            if (texto.Equals(""))
            {
                if (campo2 != 0)
                {
                    campo2 = campo2 - 20;
                    total = total - 20;
                    return total + "";
                }
                return total + "";
            }
            else
            {
                if (texto.Equals("Precio Unitario"))
                {
                    return total + "";
                }
                else if (campo2 != 20)
                {
                    campo2 = campo2 + 20;
                    total = total + campo2;
                    return total + "";
                }
                return total + "";
            }
        }

        public String progresoL(String texto)
        {
            if (texto.Equals(""))
            {
                if (campo3 != 0)
                {
                    campo3 = campo3 - 20;
                    total = total - 20;
                    return total + "";
                }
                return total + "";
            }
            else
            {
                if (texto.Equals("Lote"))
                {
                    return total + "";
                }
                else if (campo3 != 20)
                {
                    campo3 = campo3 + 20;
                    total = total + campo3;
                    return total + "";
                }
                return total + "";
            }
        }

        public String progresoD(String texto)
        {
            if (texto.Equals(""))
            {
                if (campo4 != 0)
                {
                    campo4 = campo4 - 20;
                    total = total - 20;
                    return total + "";
                }
                return total + "";
            }
            else
            {
                if (texto.Equals("Descripción"))
                {
                    return total + "";
                }
                else if (campo4 != 20)
                {
                    campo4 = campo4 + 20;
                    total = total + campo4;
                    return total + "";
                }
                return total + "";
            }
        }

        public String progresoI(String texto)
        {
            if (texto.Equals(""))
            {
                if (campo5 != 0)
                {
                    campo5 = campo5 - 20;
                    total = total - 20;
                    return total + "";
                }
                return total + "";
            }
            else
            {
                if (texto.Equals("Importe"))
                {
                    return total + "";
                }
                else if (campo5 != 20)
                {
                    campo5 = campo5 + 20;
                    total = total + campo5;
                    return total + "";
                }
                return total + "";
            }
        }
    }
}
