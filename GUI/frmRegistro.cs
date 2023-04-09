using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace GUI
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
            cboSexo.Items.Add("Hombre");
            cboSexo.Items.Add("Mujer");
            cboSexo.Items.Add("Otro");
            cboSexo.SelectedIndex = 0;
            cboRol.Items.Add("Empleado");
            cboRol.Items.Add("Administrador");
            cboRol.SelectedIndex = 0;
        }
        //Objeto para acceder al DAORegistro.
        DAORegistro reg = new DAORegistro();

        protected override void OnPaint(PaintEventArgs e)
        {
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
            using (Pen borderPen = new Pen(Color.FromArgb(255, 64, 64, 64), 2))
            {
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
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Close();
        }

        private void frmRegistro_Load(object sender, EventArgs e) {
            // ANIMACIÓN BOTÓN REGISTRAR
            btnRegistrar.MouseHover += new EventHandler(this.activarMano);
            btnRegistrar.MouseMove += new MouseEventHandler(this.activarMano);
            btnRegistrar.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN CANCELAR
            btnCancelar.MouseHover += new EventHandler(this.activarMano);
            btnCancelar.MouseMove += new MouseEventHandler(this.activarMano);
            btnCancelar.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN SALIR
            btnSalir.MouseHover += new EventHandler(this.activarMano);
            btnSalir.MouseMove += new MouseEventHandler(this.activarMano);
            btnSalir.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN VER 1
            btnVer1.MouseHover += new EventHandler(this.activarMano);
            btnVer1.MouseMove += new MouseEventHandler(this.activarMano);
            btnVer1.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN VER 2
            btnVer2.MouseHover += new EventHandler(this.activarMano);
            btnVer2.MouseMove += new MouseEventHandler(this.activarMano);
            btnVer2.MouseLeave += new EventHandler(this.desactivarMano);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnSalir_Click(this, new EventArgs());
        }

        private void txtNombreTextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool EN = reg.validacionNombres(txtNombre.Text);
            if (EN == false) epError.SetError(txtNombre, "Ingrese un nombre valido.");
            else epError.SetError(txtNombre, null);

            bool EA = reg.validacionNombres(txtApellido.Text);
            if (EA == false) epError.SetError(txtApellido, "Ingrese un apellido valido.");
            else epError.SetError(txtApellido, null);

            bool ECO = reg.validacionCorreo(txtCorreo.Text);
            if (ECO == false) epError.SetError(txtCorreo, "Ingrese un correo valido.");
            else epError.SetError(txtCorreo, null);

            bool EU = reg.validacionTexto(txtUsuario.Text);
            if (EU == false) epError.SetError(txtUsuario, "Ingrese un nombre de usuario valido.");
            else epError.SetError(txtUsuario, null);

            bool EC = reg.validacionTexto(txtContraseña.Text);
            if (EC == false) epError.SetError(txtContraseña, "Ingrese una contraseña valida.");
            else epError.SetError(txtContraseña, null);

            bool ECC = reg.validacionConfirmacion(txtContraseña.Text, txtConfirmacion.Text);
            if (ECC == false) epError.SetError(txtConfirmacion, "Escriba bien su contraseña.");
            else epError.SetError(txtConfirmacion, null);
        }

        private void btnVer1_Click(object sender, EventArgs e)
        {
            bool status = reg.VerPassword(txtContraseña.UseSystemPasswordChar);
            txtContraseña.UseSystemPasswordChar = status;
        }

        private void btnVer2_Click(object sender, EventArgs e)
        {
            bool status = reg.VerPassword(txtConfirmacion.UseSystemPasswordChar);
            txtConfirmacion.UseSystemPasswordChar = status;
        }
    }
}
