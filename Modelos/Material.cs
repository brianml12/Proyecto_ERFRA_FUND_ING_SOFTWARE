using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Material
    {
        public int IdMaterial { get; set; }
        public string CodigoMaterial { get; set; }
        public string NombreMaterial { get; set; }
        public string ColorMaterial { get; set; }
        public int CantidadMaterial { get; set; }
        public string TipoMaterial { get; set; }
        public string FechaEntrada { get; set; }
        public string NombreProveedor { get; set; }
        public string DireccionProveedor { get; set; }
        public string TelefonoProveedor { get; set; }
        public string CorreoProveedor { get; set; }
        public string NombreUsuario { get; set; }
        public int IdProveedor { get; set; }
        public int IdUsuario { get; set; }

        public Material() { }
    }
}
