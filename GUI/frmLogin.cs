using Datos;
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
        //Objeto para acceder al DAOLogin.
        DAOLogin log = new DAOLogin();
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

        private void btnIniciar_Click(object sender, EventArgs e) {
            if(txtUser.Text.Equals("admin") && txtPassword.Text.Equals("purocolageno")) {
                MessageBox.Show("Bienvenido usuario admin", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmAdministrador frm = new frmAdministrador();
                frm.Show();
                this.Close();
            }
            else if(txtUser.Text.Equals("empleado") && txtPassword.Text.Equals("purocolageno")) {
                MessageBox.Show("Bienvenido usuario empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmEmpleado frm = new frmEmpleado();
                frm.Show();
                this.Close();
            }
            else {
                MessageBox.Show("en algo andas mal vale...", "aguas cuidao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Text = "";
                txtPassword.Text = "";
            }
            
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            bool status = log.VerPassword(txtPassword.UseSystemPasswordChar);
            txtPassword.UseSystemPasswordChar = status;
        }
    }
}
