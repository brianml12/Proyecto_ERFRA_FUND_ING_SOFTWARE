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
    public partial class frmComprobante : Form {
        public frmComprobante() {
            InitializeComponent();
            MePa();
        }
        DAOComprobante comp = new DAOComprobante();
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
            frmVentas sol = new frmVentas();
            sol.Tag = this.Tag;
            sol.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnSalir_Click(this, new EventArgs());
        }

        private void MePa()
        {
            htxtPrevista.Text=comp.Generar();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            comp.Imprimir();
            frmVentas sol = new frmVentas();
            sol.Tag = this.Tag;
            sol.Show();
            this.Close();
        }
    }
}
