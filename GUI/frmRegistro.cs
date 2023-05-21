using Datos;
using Modelos;
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

namespace GUI
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
            cboSexo.SelectedIndex = 0;
            cboRol.SelectedIndex = 0;
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            GraphicsPath borderPath = new GraphicsPath();
            int borderRadius = 25; 
            borderPath.AddArc(ClientRectangle.X, ClientRectangle.Y, borderRadius, borderRadius, 180, 90);
            borderPath.AddArc(ClientRectangle.Width - borderRadius, ClientRectangle.Y, borderRadius, borderRadius, 270, 90);
            borderPath.AddArc(ClientRectangle.Width - borderRadius, ClientRectangle.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            borderPath.AddArc(ClientRectangle.X, ClientRectangle.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            borderPath.CloseAllFigures();
            Region = new Region(borderPath);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; 
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

        private void btnCancelar_Click(object sender, EventArgs e) {
            btnSalir_Click(this, new EventArgs());
        }

        public bool camposValidos(bool EN,bool EA, bool ECO,bool EU,bool EC, bool ECC, bool EP1, bool EP2) {
            if (EN == true && EA == true && ECO == true && EU == true && EC == true && ECC==true && EP1 == true && EP2 == true) return true;
            else return false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            try {
                Validacion validacion = new Validacion();
                bool EN = validacion.validacionNombres(txtNombre.Text);
                if (EN == false) epError.SetError(txtNombre, "Ingrese un nombre valido.");
                else epError.SetError(txtNombre, null);

                bool EA = validacion.validacionNombres(txtApellido.Text);
                if (EA == false) epError.SetError(txtApellido, "Ingrese un apellido valido.");
                else epError.SetError(txtApellido, null);

                bool ECO = validacion.validacionCorreo(txtCorreo.Text);
                if (ECO == false) epError.SetError(txtCorreo, "Ingrese un correo valido.");
                else epError.SetError(txtCorreo, null);

                bool EU = validacion.validacionTexto(txtUsuario.Text);
                if (EU == false) epError.SetError(txtUsuario, "Ingrese un nombre de usuario valido.");
                else epError.SetError(txtUsuario, null);

                bool EC = validacion.password(txtContraseña.Text);
                if (EC == false) epError.SetError(txtContraseña, "La longitud de la contraseña debe ser mayor a 8 digitos.");
                else epError.SetError(txtContraseña, null);

                bool ECC = validacion.passwordsIguales(txtContraseña.Text, txtConfirmacion.Text);
                if (EC == false) epError.SetError(txtConfirmacion, "Las contraseñas no coinciden.");
                else epError.SetError(txtConfirmacion, null);

                bool EP1 = validacion.validacionTexto(txtContraseña.Text);
                if (EP1 == false) epError.SetError(txtContraseña, "No puede estar vacío el campo de contraseña.");
                else epError.SetError(txtContraseña, null);

                bool EP2 = validacion.validacionTexto(txtConfirmacion.Text);
                if (EP2 == false) epError.SetError(txtConfirmacion, "No puede estar vacío el campo de confirmar contraseña.");
                else epError.SetError(txtConfirmacion, null);

                if (camposValidos(EN, EA, ECO, EU, EC, ECC, EP1, EP2) == true)
                {
                    if (new DAOEmpleado().verificaUsuario(txtUsuario.Text) == false)
                    {
                        epError.SetError(txtUsuario, null);
                        Empleado objEmpleado = new Empleado();
                        objEmpleado.Nombre = txtNombre.Text;
                        objEmpleado.Apellidos = txtApellido.Text;
                        objEmpleado.Genero = cboSexo.Text;
                        objEmpleado.Correo = txtCorreo.Text;
                        objEmpleado.NombreUsuario = txtUsuario.Text;
                        objEmpleado.Password = txtConfirmacion.Text;
                        objEmpleado.Rol = cboRol.Text;
                        if (new DAOEmpleado().agregar(objEmpleado))
                        {
                            MessageBox.Show("Empleado registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnSalir_Click(this, new EventArgs());
                        }
                        else
                        {
                            MessageBox.Show("NO se pudo agregar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        epError.SetError(txtUsuario, "El usuario ya existe, elige otro nombre de usuario.");
                    }
                }
            }
            catch {
                MessageBox.Show("Se ha perdido la conexión con la base de datos. Verifique su conexión al servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVer1_Click(object sender, EventArgs e)
        {
            bool status = new Validacion().VerPassword(txtContraseña.UseSystemPasswordChar);
            txtContraseña.UseSystemPasswordChar = status;
        }

        private void btnVer2_Click(object sender, EventArgs e)
        {
            bool status = new Validacion().VerPassword(txtConfirmacion.UseSystemPasswordChar);
            txtConfirmacion.UseSystemPasswordChar = status;
        }
    }
}
