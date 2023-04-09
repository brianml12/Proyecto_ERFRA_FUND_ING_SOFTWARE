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
    public partial class frmAgregarSolicitudes : Form {
        public frmAgregarSolicitudes() {
            InitializeComponent();
            cboPrenda.Items.Add("Playera");
            cboPrenda.Items.Add("Sueter");
            cboPrenda.Items.Add("Pantalon");
            cboPrenda.Items.Add("Uniforme");
            cboPrenda.Items.Add("Short");
            cboPrenda.Items.Add("Falda");

        }
        //Objeto para el aumento de la barra de progreso.
        DAOAgregar_Solicitudes proc = new DAOAgregar_Solicitudes();

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
            this.Close();
        }

        private void frmAgregarSolicitudes_Load(object sender, EventArgs e) {
            // ANIMACIÓN BOTÓN SALIR
            btnSalir.MouseHover += new EventHandler(this.activarMano);
            btnSalir.MouseMove += new MouseEventHandler(this.activarMano);
            btnSalir.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN ATRÁS
            btnAtras.MouseHover += new EventHandler(this.activarMano);
            btnAtras.MouseMove += new MouseEventHandler(this.activarMano);
            btnAtras.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN INSERTAR
            btnInsertar.MouseHover += new EventHandler(this.activarMano);
            btnInsertar.MouseMove += new MouseEventHandler(this.activarMano);
            btnInsertar.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN ELIMINAR
            btnCancelar.MouseHover += new EventHandler(this.activarMano);
            btnCancelar.MouseMove += new MouseEventHandler(this.activarMano);
            btnCancelar.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACION BARRA
            lblPorcentaje.Text = pbPorcentaje.Value+"%";
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            btnSalir_Click(this, new EventArgs());
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            btnSalir_Click(this, new EventArgs());
        }

        private void cboPrenda_TextChanged(object sender, EventArgs e)
        {
            lblPorcentaje.Text = proc.progresoPR(cboPrenda.Text) + "%";
            pbPorcentaje.Value = Int16.Parse(proc.progresoPR(cboPrenda.Text));
        }

        private void txtPrecioU_TextChanged(object sender, EventArgs e)
        {
            lblPorcentaje.Text  = proc.progresoPU(txtPrecioU.Text) + "%";
            pbPorcentaje.Value = Int16.Parse(proc.progresoPU(txtPrecioU.Text));
            }
        

        private void txtLote_TextChanged(object sender, EventArgs e)
        {
            lblPorcentaje.Text = proc.progresoL(txtLote.Text) + "%";
            pbPorcentaje.Value = Int16.Parse(proc.progresoL(txtLote.Text));
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            lblPorcentaje.Text = proc.progresoD(txtDescripcion.Text) + "%";
            pbPorcentaje.Value = Int16.Parse(proc.progresoD(txtDescripcion.Text));
        }

        private void txtImporte_TextChanged(object sender, EventArgs e)
        {
            lblPorcentaje.Text = proc.progresoI(txtImporte.Text) + "%";
            pbPorcentaje.Value = Int16.Parse(proc.progresoI(txtImporte.Text));
        }
    }
}
