using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Uso de un nuevo objeto con la referencia para Word.
using objWord = Microsoft.Office.Interop.Word;

namespace Datos {
    public class DAOComprobante {
        /// <summary>
        /// Método usado para generar el texto que irá en el word
        /// </summary>
        /// <returns>Retorna un string: el texto que se colocará en el word</returns>
        public String Generar() {
            String cad = "ERFRA                                          Fecha: " + DateTime.UtcNow.ToString("MM-dd-yyyy") +
                "------------------------------------------------------------------------------------" +
                "ID de la solicitud:........................"+ Datos.VariablesGlobales.IdSolicitud +
                "\r\nPrenda:........................................" + Datos.VariablesGlobales.Prenda +
                "\r\nCliente:........................................" + Datos.VariablesGlobales.Cliente +
                "\r\nCantidad de prendas:.................." + Datos.VariablesGlobales.CantidadPrendas +
                "\r\nDescripción:................................" + Datos.VariablesGlobales.Descripcion +
                "\r\nPrecio unitario:...........................$" + Datos.VariablesGlobales.PrecioU +
                "\r\nTotal:.........................................$" + Datos.VariablesGlobales.Total +
                "\r\nImporte:......................................$" + Datos.VariablesGlobales.Importe;
            return cad;
        }

        /// <summary>
        /// Método usado para crear y escribir sobre el word
        /// </summary>
        public void Imprimir() {
            //Ruta de guardado.
            String ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //Objeto de aplicacion.
            objWord.Application objAplicacion = new objWord.Application();
            //Objeto de documento.
            objWord.Document objDocumento = objAplicacion.Documents.Add();
            //Activacion.
            objDocumento.Activate();
            //Objeto para los parrafos.
            objWord.Paragraph objParrafo1 = objDocumento.Content.Paragraphs.Add(Type.Missing);

            //Comenzar a escribir
            objParrafo1.Range.Font.Size = 22;
            objParrafo1.Range.Font.Color = objWord.WdColor.wdColorDarkBlue;
            objParrafo1.Range.Text = "ERFRA                                          Fecha: " + DateTime.UtcNow.ToString("MM-dd-yyyy"); ;
            objParrafo1.Range.InsertParagraphAfter();

            //Crear parrafos para el comprobante
            objWord.Paragraph objParrafo2 = objDocumento.Content.Paragraphs.Add(Type.Missing);
            objParrafo2.Range.Font.Size = 26;
            objParrafo2.Range.Font.Color = objWord.WdColor.wdColorDarkBlue;
            objParrafo2.Range.Text = "-------------------------------------------------------";
            objParrafo2.Range.InsertParagraphAfter();

            objWord.Paragraph objParrafo3 = objDocumento.Content.Paragraphs.Add(Type.Missing);
            objParrafo3.Range.Font.Size = 16;
            objParrafo3.Range.Font.Color = objWord.WdColor.wdColorDarkBlue;
            objParrafo3.Range.Text = "ID de la solicitud:.........." + Datos.VariablesGlobales.IdSolicitud;
            objParrafo3.Range.InsertParagraphAfter();

            objWord.Paragraph objParrafo4 = objDocumento.Content.Paragraphs.Add(Type.Missing);
            objParrafo4.Range.Font.Size = 16;
            objParrafo4.Range.Font.Color = objWord.WdColor.wdColorDarkBlue;
            objParrafo4.Range.Text = "Prenda:…………………….." + Datos.VariablesGlobales.Prenda;
            objParrafo4.Range.InsertParagraphAfter();

            objWord.Paragraph objParrafo5 = objDocumento.Content.Paragraphs.Add(Type.Missing);
            objParrafo5.Range.Font.Size = 16;
            objParrafo5.Range.Font.Color = objWord.WdColor.wdColorDarkBlue;
            objParrafo5.Range.Text = "Nombre del cliente:….." + Datos.VariablesGlobales.Cliente;
            objParrafo5.Range.InsertParagraphAfter();

            objWord.Paragraph objParrafo6 = objDocumento.Content.Paragraphs.Add(Type.Missing);
            objParrafo6.Range.Font.Size = 16;
            objParrafo6.Range.Font.Color = objWord.WdColor.wdColorDarkBlue;
            objParrafo6.Range.Text = "Cantidad de prendas:…" + Datos.VariablesGlobales.CantidadPrendas;
            objParrafo6.Range.InsertParagraphAfter();

            objWord.Paragraph objParrafo7 = objDocumento.Content.Paragraphs.Add(Type.Missing);
            objParrafo7.Range.Font.Size = 16;
            objParrafo7.Range.Font.Color = objWord.WdColor.wdColorDarkBlue;
            objParrafo7.Range.Text = "Descripción:………………" + Datos.VariablesGlobales.Descripcion;
            objParrafo7.Range.InsertParagraphAfter();

            objWord.Paragraph objParrafo8 = objDocumento.Content.Paragraphs.Add(Type.Missing);
            objParrafo8.Range.Font.Size = 16;
            objParrafo8.Range.Font.Color = objWord.WdColor.wdColorDarkBlue;
            objParrafo8.Range.Text = "Precio unitario:…………." + Datos.VariablesGlobales.PrecioU;
            objParrafo8.Range.InsertParagraphAfter();

            objWord.Paragraph objParrafo9 = objDocumento.Content.Paragraphs.Add(Type.Missing);
            objParrafo9.Range.Font.Size = 16;
            objParrafo9.Range.Font.Color = objWord.WdColor.wdColorDarkBlue;
            objParrafo9.Range.Text = "Precio total:………………" + Datos.VariablesGlobales.Total;
            objParrafo9.Range.InsertParagraphAfter();

            objWord.Paragraph objParrafo10 = objDocumento.Content.Paragraphs.Add(Type.Missing);
            objParrafo10.Range.Font.Size = 16;
            objParrafo10.Range.Font.Color = objWord.WdColor.wdColorDarkBlue;
            objParrafo10.Range.Text = "Importe:……………………" + Datos.VariablesGlobales.Importe;
            objParrafo10.Range.InsertParagraphAfter();

            //Guardar archivo.
            objDocumento.SaveAs2(ruta + "\\Comprobante.docx");
            //Cerrar archivo.
            objDocumento.Close();
            //Terminar el proceso de la aplicacion.
            objAplicacion.Quit();
        }
    }
}
