using Datos;
using Modelos;
using System;
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
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
        
        }
        DAOLogin log = new DAOLogin();
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
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e) {
            // ANIMACIÓN BOTÓN INICIAR
            btnIniciar.MouseHover += new EventHandler(this.activarMano);
            btnIniciar.MouseMove += new MouseEventHandler(this.activarMano);
            btnIniciar.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN VER
            btnVer.MouseHover += new EventHandler(this.activarMano);
            btnVer.MouseMove += new MouseEventHandler(this.activarMano);
            btnVer.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN SALIR
            btnSalir.MouseHover += new EventHandler(this.activarMano);
            btnSalir.MouseMove += new MouseEventHandler(this.activarMano);
            btnSalir.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN VER
            btnVer.MouseHover += new EventHandler(this.activarMano);
            btnVer.MouseMove += new MouseEventHandler(this.activarMano);
            btnVer.MouseLeave += new EventHandler(this.desactivarMano);
        }

        private void lnkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistro frm = new frmRegistro();
            frm.Show();
            this.Close();
        }

        public bool cajasVacias()
        {
            if (txtUser.Text.Equals(txtUser.HintValue)) return true;
            else if (txtPassword.Text.Equals(txtPassword.HintValue)) return true;
            else return false;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (Conexion.conexionInternet() == true)
            {
                if (cajasVacias())
                {
                    MessageBox.Show("No se permiten campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DAOEmpleado daoempleado = new DAOEmpleado();
                    Empleado objEmpleado = new Empleado(txtUser.Text, txtPassword.Text);
                    switch (daoempleado.IniciarSesion(objEmpleado))
                    {
                        case "Administrador":
                            objEmpleado = new DAOEmpleado().buscarPorUsuario(txtUser.Text);
                            VariablesGlobales.NombreUsuarioLogeado = objEmpleado.NombreUsuario;
                            VariablesGlobales.IdUsuarioLogeado = objEmpleado.IDEmpleado;
                            MessageBox.Show("Bienvenido usuario ADMINISTRADOR " + objEmpleado.NombreUsuario, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmAdministrador frmAdmin = new frmAdministrador();
                            frmAdmin.Tag = "admin";
                            frmAdmin.Show();
                            this.Close();
                            break;
                        case "Empleado":
                            objEmpleado = new DAOEmpleado().buscarPorUsuario(txtUser.Text);
                            VariablesGlobales.NombreUsuarioLogeado = objEmpleado.Nombre;
                            VariablesGlobales.IdUsuarioLogeado = objEmpleado.IDEmpleado;
                            MessageBox.Show("Bienvenido usuario EMPLEADO " + objEmpleado.NombreUsuario, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmVentas frm = new frmVentas();
                            frm.Tag = "empleado";
                            frm.Show();
                            this.Close();
                            break;
                        case "DENEGADO":
                            MessageBox.Show("Usuario y/o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No se pudo establecer conexion a internet", "Verifique conexion a internet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            bool status = log.VerPassword(txtPassword.UseSystemPasswordChar);
            txtPassword.UseSystemPasswordChar = status;
        }
    }
}
