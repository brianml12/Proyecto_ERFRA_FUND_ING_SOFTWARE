using Datos;
using Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class frmAgregarProveedor : Form {
        List<Object> camposTexto;
        public frmAgregarProveedor(List<Object> campos) {
            InitializeComponent();
            camposTexto = new List<Object>();
            camposTexto.AddRange(campos);
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            // Crea un nuevo objeto GraphicsPath que describa la forma del borde.
            GraphicsPath borderPath = new GraphicsPath();
            int borderRadius = 25; // El radio de las esquinas redondeadas.
            borderPath.AddArc(ClientRectangle.X, ClientRectangle.Y, borderRadius, borderRadius, 180, 90);
            borderPath.AddArc(ClientRectangle.Width - borderRadius, ClientRectangle.Y, borderRadius, borderRadius, 270, 90);
            borderPath.AddArc(ClientRectangle.Width - borderRadius, ClientRectangle.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            borderPath.AddArc(ClientRectangle.X, ClientRectangle.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            borderPath.CloseAllFigures();

            // Establece la propiedad Region del formulario en un nuevo objeto Region que contenga el borde.
            Region = new Region(borderPath);

            // Dibuja el borde en el objeto Graphics del evento Paint.
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Habilita el antialiasing para esquinas suaves.
            using (Pen borderPen = new Pen(Color.FromArgb(255, 64, 64, 64), 2)) {
                e.Graphics.DrawPath(borderPen, borderPath);
            }
        }

        public void activarMano(object sender, EventArgs e) {
            Cursor = Cursors.Hand;
        }

        public void desactivarMano(object sender, EventArgs e) {
            Cursor = Cursors.Default;
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            if (this.Tag.ToString().Equals("Agregar"))
            {
                frmAgregarMaterial frm = new frmAgregarMaterial(camposTexto);
                frm.Show();
                this.Close();
            }
            else if(this.Tag.ToString().Equals("Modificar"))
            {
                frmModificarMaterial frm = new frmModificarMaterial(camposTexto);
                frm.Show();
                this.Close();
            }
        }

        private void frmAgregarProveedor_Load(object sender, EventArgs e) {
            // ANIMACIÓN BOTÓN SALIR
            btnSalir.MouseHover += new EventHandler(this.activarMano);
            btnSalir.MouseMove += new MouseEventHandler(this.activarMano);
            btnSalir.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN ATRÁS
            btnAtras.MouseHover += new EventHandler(this.activarMano);
            btnAtras.MouseMove += new MouseEventHandler(this.activarMano);
            btnAtras.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN INSERTAR
            btnAgregar.MouseHover += new EventHandler(this.activarMano);
            btnAgregar.MouseMove += new MouseEventHandler(this.activarMano);
            btnAgregar.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN ELIMINAR
            btnCancelar.MouseHover += new EventHandler(this.activarMano);
            btnCancelar.MouseMove += new MouseEventHandler(this.activarMano);
            btnCancelar.MouseLeave += new EventHandler(this.desactivarMano);
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            btnSalir_Click(this, new EventArgs());
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            btnSalir_Click(this, new EventArgs());
        }

        public bool camposValidos(bool EN, bool ED, bool ET, bool EC)
        {
            if (EN == true && ED == true && ET == true && EC == true) return true;
            else return false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Validacion validacion = new Validacion();
            bool EN = validacion.validacionNombres(txtNombre.Text);
            if (EN == false) epError.SetError(txtNombre, "Ingrese un nombre valido.");
            else epError.SetError(txtNombre, null);

            bool ED = validacion.validacionTexto(txtDireccion.Text);
            if (ED == false) epError.SetError(txtDireccion, "Ingrese una direccion valida.");
            else epError.SetError(txtDireccion, null);

            bool ET = validacion.esTelefono(txtTelefono.Text);
            if (ET == false) epError.SetError(txtTelefono, "Ingrese un telefono valido.");
            else epError.SetError(txtTelefono, null);

            bool EC = validacion.validacionCorreo(txtCorreo.Text.ToLower());
            if (EC == false) epError.SetError(txtCorreo, "Ingrese un correo valido.");
            else epError.SetError(txtCorreo, null);

            if (camposValidos(EN, ED, ET, EC) == true)
            {
                Proveedor objProveedor = new Proveedor();
                objProveedor.NombreProveedor = txtNombre.Text;
                objProveedor.DireccionProveedor = txtDireccion.Text;
                objProveedor.TelefonoProveedor = txtTelefono.Text;
                objProveedor.CorreoProveedor = txtCorreo.Text;
                if (new DAOProveedor().agregar(objProveedor))
                {
                    MessageBox.Show("Proveedor registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSalir_Click(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("NO se pudo agregar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
