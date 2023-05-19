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
using Datos;

namespace GUI {
    public partial class frmHistorial : Form {
        public frmHistorial() {
            InitializeComponent();
            cargarTabla();
        }

        public void cargarTabla() {
            try {
                dgvSolicitudes.DataSource = new DAOSolicitudes().obtenerHistorial();
                dgvSolicitudes.Columns["Importe"].Visible = false;
                dgvSolicitudes.Columns["IdUsuario"].Visible = false;
                dgvSolicitudes.Columns["PrecioUnitario"].Visible = false;
                dgvSolicitudes.Columns["Estado"].Visible = false;
            }
            catch {
                MessageBox.Show("Se ha perdido la conexión con la base de datos. Verifique su conexión al servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            frmVentas frm = new frmVentas();
            frm.Tag = this.Tag;
            frm.Show();
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e) {
            btnSalir_Click(this, new EventArgs());
        }


        private void frmSolicitudes_Load(object sender, EventArgs e) {
            // ANIMACIÓN BOTÓN SALIR
            btnSalir.MouseHover += new EventHandler(this.activarMano);
            btnSalir.MouseMove += new MouseEventHandler(this.activarMano);
            btnSalir.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN ATRÁS
            btnAtras.MouseHover += new EventHandler(this.activarMano);
            btnAtras.MouseMove += new MouseEventHandler(this.activarMano);
            btnAtras.MouseLeave += new EventHandler(this.desactivarMano);
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e) {
            try {
                dgvSolicitudes.DataSource = new DAOSolicitudes().buscarTodosHistorial(txtBuscar.Text);
                dgvSolicitudes.Columns["Importe"].Visible = false;
                dgvSolicitudes.Columns["IdUsuario"].Visible = false;
                dgvSolicitudes.Columns["PrecioUnitario"].Visible = false;
                dgvSolicitudes.Columns["Estado"].Visible = false;
            }
            catch {
                MessageBox.Show("Se ha perdido la conexión con la base de datos. Verifique su conexión al servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
