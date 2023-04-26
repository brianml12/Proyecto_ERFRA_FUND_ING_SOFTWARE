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
    public partial class frmMateriaPrima : Form {
        public frmMateriaPrima() {
            InitializeComponent();
            cargarTabla();
        }

        public void cargarTabla()
        {
            dgvMateriaPrima.DataSource = new DAOMateriaPrima().obtenerTodos();
            dgvMateriaPrima.Columns["IdMaterial"].Visible = false;
            dgvMateriaPrima.Columns["IdProveedor"].Visible = false;
            dgvMateriaPrima.Columns["IdUsuario"].Visible = false;
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            GraphicsPath borderPath = new GraphicsPath();
            int borderRadius = 25; // El radio de las esquinas redondeadas.
            borderPath.AddArc(ClientRectangle.X, ClientRectangle.Y, borderRadius, borderRadius, 180, 90);
            borderPath.AddArc(ClientRectangle.Width - borderRadius, ClientRectangle.Y, borderRadius, borderRadius, 270, 90);
            borderPath.AddArc(ClientRectangle.Width - borderRadius, ClientRectangle.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            borderPath.AddArc(ClientRectangle.X, ClientRectangle.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            borderPath.CloseAllFigures();
            Region = new Region(borderPath);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen borderPen = new Pen(System.Drawing.Color.FromArgb(255, 64, 64, 64), 2)) {
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
            frmAdministrador frm = new frmAdministrador();
            frm.Show();
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e) {
            btnSalir_Click(this, new EventArgs());
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            if (dgvMateriaPrima.SelectedRows.Count == 0)
            {
                MessageBox.Show("No hay ninguna fila seleccionada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id_m = int.Parse(dgvMateriaPrima.SelectedRows[0].Cells[0].Value.ToString());
                frmModificarMaterial frm = new frmModificarMaterial(id_m);
                frm.Show();
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (dgvMateriaPrima.SelectedRows.Count == 0)
            {
                MessageBox.Show("No hay ninguna fila seleccionada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id_m = int.Parse(dgvMateriaPrima.SelectedRows[0].Cells[0].Value.ToString());
                DialogResult ans = MessageBox.Show("¿Está seguro que desea eliminar el producto seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ans == DialogResult.Yes)
                {
                    if (new DAOMateriaPrima().eliminar(id_m))
                    {
                        MessageBox.Show("Material eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarTabla();
                        //btnSalir_Click(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("NO se pudo eliminar el material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void frmMateriaPrima_Load(object sender, EventArgs e) {
            // ANIMACIÓN BOTÓN SALIR
            btnSalir.MouseHover += new EventHandler(this.activarMano);
            btnSalir.MouseMove += new MouseEventHandler(this.activarMano);
            btnSalir.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN ATRÁS
            btnAtras.MouseHover += new EventHandler(this.activarMano);
            btnAtras.MouseMove += new MouseEventHandler(this.activarMano);
            btnAtras.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN BUSCAR
           
            // ANIMACIÓN BOTÓN AGREGAR
            btnAgregar.MouseHover += new EventHandler(this.activarMano);
            btnAgregar.MouseMove += new MouseEventHandler(this.activarMano);
            btnAgregar.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN MODIFICAR
            btnModificar.MouseHover += new EventHandler(this.activarMano);
            btnModificar.MouseMove += new MouseEventHandler(this.activarMano);
            btnModificar.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN ELIMINAR
            btnEliminar.MouseHover += new EventHandler(this.activarMano);
            btnEliminar.MouseMove += new MouseEventHandler(this.activarMano);
            btnEliminar.MouseLeave += new EventHandler(this.desactivarMano);
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            frmAgregarMaterial frm = new frmAgregarMaterial();
            frm.Show();
            this.Close();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            dgvMateriaPrima.DataSource = new DAOMateriaPrima().buscarTodos(txtBuscar.Text);
            dgvMateriaPrima.Columns["IdMaterial"].Visible = false;
            dgvMateriaPrima.Columns["IdProveedor"].Visible = false;
            dgvMateriaPrima.Columns["IdUsuario"].Visible = false;
        }
    }
}
