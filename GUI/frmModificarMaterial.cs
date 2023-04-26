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
    public partial class frmModificarMaterial : Form {
        int IDMaterial;

        public frmModificarMaterial() {
            InitializeComponent();
        }

        public frmModificarMaterial(List<Object> campos) : this()
        {
            this.cargarProveedores();
            IDMaterial = int.Parse(campos[0].ToString());
            txtCodigoMaterial.Text = campos[1].ToString();
            txtNombre.Text = campos[2].ToString();
            txtColor.Text = campos[3].ToString();
            txtCantidad.Text = campos[4].ToString();
            txtTipoMaterial.Text = campos[5].ToString();
            dateTimePicker1.Text = campos[6].ToString();
            if (campos.Count == 8)
            {
                cboProveedor.SelectedValue = int.Parse(campos[7].ToString());
            }
        }

        public frmModificarMaterial(int id_material) : this()
        {
            try
            {
                IDMaterial = id_material;
                this.cargarProveedores();
                Material objMaterial = new DAOMateriaPrima().obtenerUno(IDMaterial);
                txtUsuario.Text = VariablesGlobales.NombreUsuarioLogeado;
                txtCodigoMaterial.Text = objMaterial.CodigoMaterial;
                txtNombre.Text = objMaterial.NombreMaterial;
                txtColor.Text = objMaterial.ColorMaterial;
                txtCantidad.Text = objMaterial.CantidadMaterial.ToString();
                txtTipoMaterial.Text = objMaterial.TipoMaterial;
                dateTimePicker1.Text = objMaterial.FechaEntrada;
                cboProveedor.SelectedValue = objMaterial.IdProveedor;
            }
            catch
            {
            }
        }

        public void cargarProveedores()
        {
            cboProveedor.DataSource = new DAOMateriaPrima().obtenerProveedores();
            cboProveedor.DisplayMember = "NombreProveedor";
            cboProveedor.ValueMember = "IdProveedor";
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
            btnGuardar.MouseHover += new EventHandler(this.activarMano);
            btnGuardar.MouseMove += new MouseEventHandler(this.activarMano);
            btnGuardar.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN ELIMINAR
            btnCancelar.MouseHover += new EventHandler(this.activarMano);
            btnCancelar.MouseMove += new MouseEventHandler(this.activarMano);
            btnCancelar.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN AGREGAR PROVEEDOR
            btnAgregarProveedor.MouseHover += new EventHandler(this.activarMano);
            btnAgregarProveedor.MouseMove += new MouseEventHandler(this.activarMano);
            btnAgregarProveedor.MouseLeave += new EventHandler(this.desactivarMano);
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
            if (ECM == true && ENM == true && EC == true && ECMC == true && ETM == true) return true;
            else return false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validacion validacion = new Validacion();
            bool ECM = validacion.esCodigoMaterial(txtCodigoMaterial.Text);
            if (ECM == false) epError.SetError(txtCodigoMaterial, "Ingrese un codigo de material valido.");
            else epError.SetError(txtCodigoMaterial, null);

            bool ENM = validacion.validacionTexto(txtNombre.Text);
            if (ENM == false) epError.SetError(txtNombre, "Ingrese un nombre de material valido.");
            else epError.SetError(txtNombre, null);

            bool EC = validacion.validacionTexto(txtColor.Text);
            if (EC == false) epError.SetError(txtColor, "Ingrese un color del material valido.");
            else epError.SetError(txtColor, null);

            bool ECMC = validacion.esCantidadMayorCero(txtCantidad.Text);
            if (ECMC == false) epError.SetError(txtCantidad, "Ingrese una cantidad valida.");
            else epError.SetError(txtCantidad, null);

            bool ETM = validacion.validacionTexto(txtTipoMaterial.Text);
            if (ETM == false) epError.SetError(txtTipoMaterial, "Ingrese una cantidad valida.");
            else epError.SetError(txtTipoMaterial, null);

            if (camposValidos(ECM, ENM, EC, ECMC, ETM) == true)
            {
                    if (cboProveedor.SelectedValue != null)
                    {
                        epError.SetError(cboProveedor, null);
                        Material objMaterial = new Material();
                        objMaterial.IdMaterial = IDMaterial;
                        objMaterial.CodigoMaterial = txtCodigoMaterial.Text;
                        objMaterial.NombreMaterial = txtNombre.Text;
                        objMaterial.ColorMaterial = txtColor.Text;
                        objMaterial.CantidadMaterial = int.Parse(txtCantidad.Text);
                        objMaterial.TipoMaterial = txtTipoMaterial.Text;
                        objMaterial.FechaEntrada = dateTimePicker1.Text;
                        objMaterial.IdProveedor = int.Parse(cboProveedor.SelectedValue.ToString());
                        objMaterial.IdUsuario = VariablesGlobales.IdUsuarioLogeado;
                        if (new DAOMateriaPrima().modificar(objMaterial))
                        {
                            MessageBox.Show("Material modificado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnSalir_Click(this, new EventArgs());
                        }
                        else
                        {
                            MessageBox.Show("NO se pudo modificar el material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        epError.SetError(cboProveedor, "Seleccione o agregue un proveedor.");
                    }
                }
        }
            private void btnAgregarProveedor_Click(object sender, EventArgs e) {
            List<Object> campos = new List<Object>();
            campos.Add(IDMaterial);
            campos.Add(txtCodigoMaterial.Text);
            campos.Add(txtNombre.Text);
            campos.Add(txtColor.Text);
            campos.Add(txtCantidad.Text);
            campos.Add(txtTipoMaterial.Text);
            campos.Add(dateTimePicker1.Text);
            if (cboProveedor.SelectedValue != null)
            {
                campos.Add(int.Parse(cboProveedor.SelectedValue.ToString()));
            }
            frmAgregarProveedor frm = new frmAgregarProveedor(campos);
            frm.Tag = "Modificar";
            frm.Show();
            this.Close();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (cboProveedor.SelectedValue == null)
            {
                MessageBox.Show("No hay ningun proveedor a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                DialogResult ans = MessageBox.Show("¿Está seguro que desea eliminar el proveedor?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ans == DialogResult.Yes)
                {
                    if (new DAOMateriaPrima().eliminarProveedor(int.Parse(cboProveedor.SelectedValue.ToString())) == true)
                    {
                        MessageBox.Show("Proveedor eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.cargarProveedores();
                    }
                    else
                    {
                        MessageBox.Show("NO se pudo eliminar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }
    }
}
