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
        }

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
    }
}
