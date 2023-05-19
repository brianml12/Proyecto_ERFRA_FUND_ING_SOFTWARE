using Datos;
using Modelos;
using System;
using System.Collections;
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
    public partial class frmAgregarMaterial : Form {
        public frmAgregarMaterial() {
            InitializeComponent();
            this.cargarProveedores();
        }

        public frmAgregarMaterial(List<Object> campos) : this()
        {
            try {
                this.cargarProveedores();
                txtCodigoMaterial.Text = campos[0].ToString();
                txtNombre.Text = campos[1].ToString();
                txtColor.Text = campos[2].ToString();
                txtCantidad.Text = campos[3].ToString();
                txtTipoMaterial.Text = campos[4].ToString();
                dateTimePicker1.Text = campos[5].ToString();
                if (campos.Count == 7)
                {
                    cboProveedor.SelectedValue = int.Parse(campos[6].ToString());
                }
            }
            catch {
                MessageBox.Show("Se ha perdido la conexión con la base de datos. Verifique su conexión al servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarProveedores() {
            try {
                cboProveedor.DataSource = new DAOMateriaPrima().obtenerProveedores();
                cboProveedor.DisplayMember = "NombreProveedor";
                cboProveedor.ValueMember = "IdProveedor";
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
            frmMateriaPrima frm = new frmMateriaPrima();
            frm.Show();
            this.Close();
        }

        private void frmAgregarMaterial_Load(object sender, EventArgs e) {
            txtUsuario.Text = VariablesGlobales.NombreUsuarioLogeado;
            // ANIMACIÓN BOTÓN SALIR
            btnSalir.MouseHover += new EventHandler(this.activarMano);
            btnSalir.MouseMove += new MouseEventHandler(this.activarMano);
            btnSalir.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN ATRÁS
            btnAtras.MouseHover += new EventHandler(this.activarMano);
            btnAtras.MouseMove += new MouseEventHandler(this.activarMano);
            btnAtras.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN INSERTAR
            btnAgregar.MouseHover += new EventHandler(this.activarMano);
            btnAgregar.MouseMove += new MouseEventHandler(this.activarMano);
            btnAgregar.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN ELIMINAR
            btnCancelar.MouseHover += new EventHandler(this.activarMano);
            btnCancelar.MouseMove += new MouseEventHandler(this.activarMano);
            btnCancelar.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN AGREGAR PROVEEDOR
            btnAgregarProveedor.MouseHover += new EventHandler(this.activarMano);
            btnAgregarProveedor.MouseMove += new MouseEventHandler(this.activarMano);
            btnAgregarProveedor.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN ELIMINAR PROVEEDOR
            btnEliminarProveedor.MouseHover += new EventHandler(this.activarMano);
            btnEliminarProveedor.MouseMove += new MouseEventHandler(this.activarMano);
            btnEliminarProveedor.MouseLeave += new EventHandler(this.desactivarMano);
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            btnSalir_Click(this, new EventArgs());
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            btnSalir_Click(this, new EventArgs());
        }

        public bool camposValidos(bool ECM, bool ENM, bool EC, bool ETM, bool ECMC)
        {
            if (ECM == true && ENM == true && EC == true && ECMC == true && ETM==true) return true;
            else return false;
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            try {
                Validacion validacion = new Validacion();
                bool ECM = validacion.esCodigoMaterial(txtCodigoMaterial.Text);
                if (ECM == false) epError.SetError(txtCodigoMaterial, "Ingrese un codigo de material valido  (10 digitos).");
                else epError.SetError(txtCodigoMaterial, "");

                bool ENM = validacion.validacionTexto(txtNombre.Text);
                if (ENM == false) epError.SetError(txtNombre, "Ingrese un nombre de material valido.");
                else epError.SetError(txtNombre, "");

                bool EC = validacion.validacionTexto(txtColor.Text);
                if (EC == false) epError.SetError(txtColor, "Ingrese un color del material valido.");
                else epError.SetError(txtColor, "");

                bool ECMC = validacion.esCantidadMayorCero(txtCantidad.Text);
                if (ECMC == false) epError.SetError(txtCantidad, "Ingrese una cantidad valida.");
                else epError.SetError(txtCantidad, "");

                bool ETM = validacion.validacionTexto(txtTipoMaterial.Text);
                if (ETM == false) epError.SetError(txtTipoMaterial, "Ingrese una cantidad valida.");
                else epError.SetError(txtTipoMaterial, "");

                if (camposValidos(ECM, ENM, EC, ECMC, ETM) == true)
                {
                    if (new DAOMateriaPrima().verificaMaterialExistente(txtCodigoMaterial.Text) == false)
                    {
                        epError.SetError(txtCodigoMaterial, "");
                        if (cboProveedor.SelectedValue != null)
                        {
                            epError.SetError(cboProveedor, null);
                            Material objMaterial = new Material();
                            objMaterial.CodigoMaterial = txtCodigoMaterial.Text;
                            objMaterial.NombreMaterial = txtNombre.Text;
                            objMaterial.ColorMaterial = txtColor.Text;
                            objMaterial.CantidadMaterial = int.Parse(txtCantidad.Text);
                            objMaterial.TipoMaterial = txtTipoMaterial.Text;
                            objMaterial.FechaEntrada = dateTimePicker1.Text;
                            objMaterial.IdProveedor = int.Parse(cboProveedor.SelectedValue.ToString());
                            objMaterial.IdUsuario = VariablesGlobales.IdUsuarioLogeado;
                            if (new DAOMateriaPrima().agregar(objMaterial))
                            {
                                MessageBox.Show("Material registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnSalir_Click(this, new EventArgs());
                            }
                            else
                            {
                                MessageBox.Show("NO se pudo agregar el material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else {
                            epError.SetError(cboProveedor, "Seleccione o agregue un proveedor.");
                        }
                    }
                    else {
                        epError.SetError(txtCodigoMaterial, "El codigo del material ya existe.");
                    }

                }
            }
            catch {
                MessageBox.Show("Se ha perdido la conexión con la base de datos. Verifique su conexión al servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e) {
            List<Object> campos = new List<Object>();
            campos.Add(txtCodigoMaterial.Text);
            campos.Add(txtNombre.Text);
            campos.Add(txtColor.Text);
            campos.Add(txtCantidad.Text);
            campos.Add(txtTipoMaterial.Text);
            campos.Add(dateTimePicker1.Text);
            if (cboProveedor.SelectedValue != null) {
                campos.Add(int.Parse(cboProveedor.SelectedValue.ToString()));
            }
            frmAgregarProveedor frm = new frmAgregarProveedor(campos);
            frm.Tag = "Agregar";
            frm.Show();
            this.Close();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e) {
            try {
                if (cboProveedor.Items.Count == 1) {
                    MessageBox.Show("Debe haber minimo 1 proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cboProveedor.SelectedValue == null) {
                    MessageBox.Show("No hay ningun proveedor a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    DialogResult ans = MessageBox.Show("¿Está seguro que desea eliminar el proveedor?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (ans == DialogResult.Yes) {
                        if (new DAOMateriaPrima().eliminarProveedor(int.Parse(cboProveedor.SelectedValue.ToString())) == true) {
                            MessageBox.Show("Proveedor eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.cargarProveedores();
                        }
                        else {
                            MessageBox.Show("NO se pudo eliminar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch {
                MessageBox.Show("Se ha perdido la conexión con la base de datos. Verifique su conexión al servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
