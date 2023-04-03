using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MessageBox
{
   
    internal class CustomMessage
    {

        public static string ResultDialog;

        /// <summary>
        /// El metodo sirve para hacer un messagebox personalizado, el cual utilizara parametros<br/>
        /// -Para cambiar el icono, el icono debe estar en tamaño x64 y se debe pegar la ruta de la imagen.<br/>
        /// -Se debera escribir el mensaje que se desea mostrar.<br/>
        /// -Por ultimo usar true o false para indicar si el messagebox tendra 1 o 2 opciones de botones.<br/>
        /// MostrarMensaje("ruta","mensaje",true/false);<br/>
        /// </summary>
        public static void MostrarMensaje(string mensaje)
        {
            CustomMessageBox msg = new CustomMessageBox();
            //msg.pictureBox1.BackgroundImage = Image.FromFile(img);
            msg.txtMensaje.Text = mensaje;

            //if (pag == 1) 
            //{
            //    msg.tabControl1.SelectedIndex = 0;
            //}
            //if (pag == 2)
            //{
            //    msg.tabControl1.SelectedIndex = 1;
            //}
            //if (pag == 3)
            //{
            //    msg.tabControl1.SelectedIndex = 2;
            //}
            msg.ShowDialog();   
            if (msg.DialogResult == DialogResult.OK)
            {
                ResultDialog = "OK";
            }
            //if (msg.DialogResult == DialogResult.Yes)
            //{
            //    ResultDialog = "YES";
            //}
            //if (msg.DialogResult == DialogResult.No)
            //{
            //    ResultDialog = "NO";
            //}
            msg.Close();
        }
    }
}
