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
        DAOSolicitudes sol;

        public void cargarTabla() {
            try {
                sol = new DAOSolicitudes();
                dgvSolicitudes.DataSource = new DAOSolicitudes().obtenerTodos();
                dgvSolicitudes.Columns["IdUsuario"].Visible = false;
                dgvSolicitudes.Columns["Total"].Visible = false;
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
                MessageBox.Show("Se ha perdido la conexión con la base de datos. Verifique su conexión al servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try {
                if (dgvSolicitudes.SelectedRows.Count == 0) {
                    MessageBox.Show("No hay ninguna fila seleccionada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    DialogResult ans = MessageBox.Show("¿Está seguro que desea eliminar la solicitud seleccionada?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(ans == DialogResult.Yes) { 
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
            }
            catch {
                MessageBox.Show("Se ha perdido la conexión con la base de datos. Verifique su conexión al servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSolicitudes_Load(object sender, EventArgs e) {
            // ANIMACIÓN BOTÓN INSERTAR
            btnAgregar.MouseHover += new EventHandler(this.activarMano);
            btnAgregar.MouseMove += new MouseEventHandler(this.activarMano);
            btnAgregar.MouseLeave += new EventHandler(this.desactivarMano);
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
            try {
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
            catch {
                MessageBox.Show("Se ha perdido la conexión con la base de datos. Verifique su conexión al servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            dgvSolicitudes.DataSource = new DAOSolicitudes().buscarTodos(txtBuscar.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            try {
                frmAgregarSolicitudes frm = new frmAgregarSolicitudes();
                int id = sol.obtenerMaxIDSolicitud();
                Datos.VariablesGlobales.IdSolicitud = id+"";
                frm.Tag = this.Tag;
                frm.Show();
                this.Close();
            }
            catch {
                MessageBox.Show("Se ha perdido la conexión con la base de datos. Verifique su conexión al servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
