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
    public partial class frmVentas : Form {
        public frmVentas() {
            InitializeComponent();
            cargarTabla();
        }
        DAOSolicitudes sol = new DAOSolicitudes();

        public void cargarTabla() {
            dgvSolicitudes.DataSource = new DAOSolicitudes().obtenerTodos();
            dgvSolicitudes.Columns["IdUsuario"].Visible = false;
            dgvSolicitudes.Columns["Total"].Visible = false;
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
            try {
                if (this.Tag.Equals("empleado")) {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes) {
                        frmLogin frm = new frmLogin();
                        frm.Show();
                        this.Close();
                    }
                }
                else if (this.Tag.Equals("admin")) {
                    frmAdministrador frm = new frmAdministrador();
                    frm.Show();
                    this.Close();
                }
            }
            catch {
            }
            
        }

        private void btnAtras_Click(object sender, EventArgs e) {
            btnSalir_Click(this, new EventArgs());
            
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            if (dgvSolicitudes.SelectedRows.Count == 0) {
                MessageBox.Show("No hay ninguna fila seleccionada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                int id = int.Parse(dgvSolicitudes.SelectedRows[0].Cells[0].Value.ToString());
                frmModificarSolicitudes frm = new frmModificarSolicitudes(id);
                frm.ShowDialog();
                cargarTabla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (dgvSolicitudes.SelectedRows.Count == 0) {
                MessageBox.Show("No hay ninguna fila seleccionada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                int id = int.Parse(dgvSolicitudes.SelectedRows[0].Cells[0].Value.ToString());
                if (new DAOSolicitudes().eliminar(id)) {
                    MessageBox.Show("La venta ha sido borrada correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("No se pudo eliminar la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cargarTabla();
            }
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
            // ANIMACIÓN BOTÓN BUSCAR
            // ANIMACIÓN BOTÓN FINALIZAR
            btnFinalizar.MouseHover += new EventHandler(this.activarMano);
            btnFinalizar.MouseMove += new MouseEventHandler(this.activarMano);
            btnFinalizar.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN MODIFICAR
            btnModificar.MouseHover += new EventHandler(this.activarMano);
            btnModificar.MouseMove += new MouseEventHandler(this.activarMano);
            btnModificar.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN ELIMINAR
            btnCancelar.MouseHover += new EventHandler(this.activarMano);
            btnCancelar.MouseMove += new MouseEventHandler(this.activarMano);
            btnCancelar.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN HISTORIAL
            btnHistorial.MouseHover += new EventHandler(this.activarMano);
            btnHistorial.MouseMove += new MouseEventHandler(this.activarMano);
            btnHistorial.MouseLeave += new EventHandler(this.desactivarMano);
        }

        private void btnHistorial_Click(object sender, EventArgs e) {
            frmHistorial frm = new frmHistorial();
            frm.Tag = this.Tag;
            frm.Show();
            this.Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e) {
            if (dgvSolicitudes.SelectedRows.Count == 0) {
                MessageBox.Show("No hay ninguna fila seleccionada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                int id = int.Parse(dgvSolicitudes.SelectedRows[0].Cells[0].Value.ToString());
                if (new DAOSolicitudes().finalizarVenta(id)) {
                    MessageBox.Show("La venta ha sido finalizada y agregada al historial.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("No se pudo finalizar la venta. El estado debe ser \"Terminada\"", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cargarTabla();
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            dgvSolicitudes.DataSource = new DAOSolicitudes().buscarTodos(txtBuscar.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            frmAgregarSolicitudes frm = new frmAgregarSolicitudes();
            int id = sol.obtenerMaxIDSolicitud();
            Datos.VariablesGlobales.IdSolicitud = id+"";
            frm.Tag = this.Tag;
            frm.Show();
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
