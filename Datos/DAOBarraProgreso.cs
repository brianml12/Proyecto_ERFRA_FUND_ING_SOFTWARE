using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAOBarraProgreso
    {
        //Variables para la barra de progreso
        int total = 0;
        int campo1 = 0;
        int campo2 = 0;
        int campo3 = 0;
        int campo4 = 0;
        int campo5 = 0;
        int campo6 = 0;
        int Playera = 100;
        int Sueter = 200;
        int Pantalon = 150;
        int Uniforme = 450;
        int Short = 80;
        int Falda = 150;

        public String progresoPR(String texto)
        {
            if (texto.Equals("Prenda"))
            {
                if (campo1 != 0)
                {
                    campo1 = campo1 - 40;
                    total = total - 40;
                    return total + "";
                }
                return total + "";
            }
            else
            {
                if (texto.Equals(""))
                {
                    return total + "";
                }
                else if (campo1 != 40)
                {
                    campo1 = campo1 + 40;
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
                    campo5 = campo5 - 10;
                    total = total - 10;
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
                else if (campo5 != 10)
                {
                    campo5 = campo5 + 10;
                    total = total + campo5;
                    return total + "";
                }
                return total + "";
            }
        }

        public String PrecioUnitario(String prenda)
        {
            if (prenda.Equals("Playera")) return Playera + "";
            else if (prenda.Equals("Sueter")) return Sueter + "";
            else if (prenda.Equals("Pantalon")) return Pantalon + "";
            else if (prenda.Equals("Uniforme")) return Uniforme + "";
            else if (prenda.Equals("Short")) return Short + "";
            else if (prenda.Equals("Falda")) return Falda + "";
            else return "Precio Unitario";
        }

        public String progresoC(String texto)
        {
            if (texto.Equals(""))
            {
                if (campo6 != 0)
                {
                    campo6 = campo6 - 10;
                    total = total - 10;
                    return total + "";
                }
                return total + "";
            }
            else
            {
                if (texto.Equals("Nombre del cliente"))
                {
                    return total + "";
                }
                else if (campo6 != 10)
                {
                    campo6 = campo6 + 10;
                    total = total + campo6;
                    return total + "";
                }
                return total + "";
            }
        }

        public void Eliminacion(String texto, int lote)
        {
            if(texto.Equals("sin falda"))
            {
                int descuento = Falda * lote;
                int resta = Int16.Parse(Datos.VariablesGlobales.Total) - descuento;
                Datos.VariablesGlobales.Total = resta + "";
            }
            else if (texto.Equals("sin playera"))
            {
                int descuento = Playera * lote;
                int resta = Int16.Parse(Datos.VariablesGlobales.Total) - descuento;
                Datos.VariablesGlobales.Total = resta + "";
            }
            else if (texto.Equals("sin pantalon"))
            {
                int descuento = Pantalon * lote;
                int resta = Int16.Parse(Datos.VariablesGlobales.Total) - descuento;
                Datos.VariablesGlobales.Total = resta + "";
            }
            else if (texto.Equals("sin sueter"))
            {
                int descuento = Sueter * lote;
                int resta = Int16.Parse(Datos.VariablesGlobales.Total) - descuento;
                Datos.VariablesGlobales.Total = resta + "";
            }
        }

        public String Seguro(int PU, int cantidad)
        {
            return (PU * cantidad) / 2 + "";
        }

        public String ac()
        {
            return "";
        }
    }
}
