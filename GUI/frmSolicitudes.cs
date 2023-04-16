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
    public partial class frmSolicitudes : Form {
        public frmSolicitudes() {
            InitializeComponent();
            cargarTabla();
        }

        public void cargarTabla()
        {
            dgvSolicitudes.DataSource = new DAOSolicitudes().obtenerTodos();
            dgvSolicitudes.Columns["IdSolicitud"].Visible = false;
            dgvSolicitudes.Columns["IdUsuario"].Visible = false;
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
            frmEmpleado empleados = new frmEmpleado();
            empleados.Show();
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e) {
            btnSalir_Click(this, new EventArgs());
        }

        private void btnInsertar_Click(object sender, EventArgs e) {
            frmAgregarSolicitudes frm = new frmAgregarSolicitudes();
            frm.Show();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            if (dgvSolicitudes.SelectedRows.Count == 0)
            {
                MessageBox.Show("No hay ninguna fila seleccionada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id_s = int.Parse(dgvSolicitudes.SelectedRows[0].Cells[0].Value.ToString());
                frmModificarSolicitudes frm = new frmModificarSolicitudes(id_s);
                frm.Show();
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (dgvSolicitudes.SelectedRows.Count == 0)
            {
                MessageBox.Show("No hay ninguna fila seleccionada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id_s = int.Parse(dgvSolicitudes.SelectedRows[0].Cells[0].Value.ToString());
                DialogResult ans = MessageBox.Show("¿Está seguro que desea eliminar la solicitud seleccionada?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ans == DialogResult.Yes)
                {
                    if (new DAOSolicitudes().eliminar(id_s))
                    {
                        MessageBox.Show("Solicitud eliminada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarTabla();
                        //btnSalir_Click(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("NO se pudo eliminar la Solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
            btnBuscar.MouseHover += new EventHandler(this.activarMano);
            btnBuscar.MouseMove += new MouseEventHandler(this.activarMano);
            btnBuscar.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN INSERTAR
            btnInsertar.MouseHover += new EventHandler(this.activarMano);
            btnInsertar.MouseMove += new MouseEventHandler(this.activarMano);
            btnInsertar.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN MODIFICAR
            btnModificar.MouseHover += new EventHandler(this.activarMano);
            btnModificar.MouseMove += new MouseEventHandler(this.activarMano);
            btnModificar.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN ELIMINAR
            btnEliminar.MouseHover += new EventHandler(this.activarMano);
            btnEliminar.MouseMove += new MouseEventHandler(this.activarMano);
            btnEliminar.MouseLeave += new EventHandler(this.desactivarMano);
        }

        
    }
}
