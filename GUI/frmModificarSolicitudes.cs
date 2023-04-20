using Datos;
using Modelos;
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
    public partial class frmModificarSolicitudes : Form {
        public int IDSolicitud;
        public frmModificarSolicitudes() {
            InitializeComponent();
            cboPrenda.Items.Add("Playera");
            cboPrenda.Items.Add("Sueter");
            cboPrenda.Items.Add("Pantalon");
            cboPrenda.Items.Add("Uniforme");
            cboPrenda.Items.Add("Short");
            cboPrenda.Items.Add("Falda");
        }
        DAOBarraProgreso proc = new DAOBarraProgreso();
        bool flag = true;
        public frmModificarSolicitudes(List<Object> campos) : this()
        {
            IDSolicitud = int.Parse(campos[0].ToString());
            cboPrenda.SelectedItem = int.Parse(campos[1].ToString());
            txtCliente.Text = campos[2].ToString();
            txtPrecioU.Text = campos[3].ToString();
            txtLote.Text = campos[4].ToString();
            txtDescripcion.Text = campos[5].ToString();
            txtImporte.Text = campos[6].ToString();
        }

        public frmModificarSolicitudes(int id_solicitud) : this()
        { 
            IDSolicitud = id_solicitud;
            Datos.VariablesGlobales.IdSolicitud = id_solicitud+"";
            Solicitudes objSolicitud = new DAOSolicitudes().obtenerUno(IDSolicitud);
            cboPrenda.SelectedItem = objSolicitud.NombreProducto;
            txtCliente.Text = objSolicitud.NombreCliente;
            txtPrecioU.Text = objSolicitud.PrecioUnitario.ToString();
            txtLote.Text = objSolicitud.Lote.ToString();
            txtDescripcion.Text = objSolicitud.Descripcion;
            txtImporte.Text = objSolicitud.Importe.ToString();
            cboEstado.SelectedItem = objSolicitud.Estado;
            flag = true;
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
            //frmVentas frm = new frmVentas();
            //sfrm.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            btnSalir_Click(this, new EventArgs());
        }

        private void btnRegresar_Click(object sender, EventArgs e) {
            btnSalir_Click(this, new EventArgs());
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            if (flag == true)
            {


                try
                {
                    if (cboPrenda.SelectedIndex == 0)
                    {
                        ErrorCampos.SetError(this.cboPrenda, "Selecciona una prenda");
                    }
                    else
                    {
                        ErrorCampos.SetError(this.cboPrenda, "");
                    }

                    if (txtCliente.Text == txtCliente.HintValue)
                    {
                        ErrorCampos.SetError(this.txtCliente, "El campo esta vacio");
                    }
                    else
                    {
                        ErrorCampos.SetError(this.txtCliente, "");
                    }

                    if (!(new Validacion().esNumero(txtPrecioU.Text)))
                    {
                        ErrorCampos.SetError(this.txtPrecioU, "Escribe un precio unitario valido");
                    }
                    else
                    {
                        ErrorCampos.SetError(this.txtPrecioU, "");
                    }

                    if (!(new Validacion().esNumero(txtLote.Text)))
                    {
                        ErrorCampos.SetError(this.txtLote, "Escribe un lote valido");
                    }
                    else
                    {
                        ErrorCampos.SetError(this.txtLote, "");
                    }

                    if (txtDescripcion.Text == txtDescripcion.HintValue)
                    {
                        ErrorCampos.SetError(this.txtDescripcion, "El campo esta vacio");
                    }
                    else
                    {
                        ErrorCampos.SetError(this.txtDescripcion, "");
                    }

                    if (!(new Validacion().esNumero(txtImporte.Text)))
                    {
                        ErrorCampos.SetError(this.txtImporte, "Escribe un importe valido");
                    }
                    else
                    {
                        ErrorCampos.SetError(this.txtImporte, "");
                    }

                    if (cboPrenda.SelectedIndex != 0 && txtCliente.Text != txtCliente.HintValue && new Validacion().esNumero(txtPrecioU.Text)
                        && new Validacion().esNumero(txtLote.Text) && txtDescripcion.Text != txtDescripcion.HintValue && new Validacion().esNumero(txtImporte.Text))
                    {
                        Solicitudes objSolicitud = new Solicitudes();
                        objSolicitud.IdSolicitud = IDSolicitud;
                        objSolicitud.NombreCliente = txtCliente.Text;
                        objSolicitud.NombreProducto = cboPrenda.SelectedItem.ToString();
                        objSolicitud.Descripcion = txtDescripcion.Text;
                        objSolicitud.Lote = int.Parse(txtLote.Text);
                        objSolicitud.PrecioUnitario = int.Parse(txtPrecioU.Text);
                        objSolicitud.Importe = int.Parse(txtImporte.Text);
                        objSolicitud.IdUsuario = VariablesGlobales.IdUsuarioLogeado;
                        objSolicitud.Estado = cboEstado.SelectedItem.ToString();
                        if (new DAOSolicitudes().modificar(objSolicitud))
                        {
                            MessageBox.Show("Solicitud modificada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //btnSalir_Click(this, new EventArgs());


                            //MODIFICAR COMPROBANTE (ARREGLALO XAVIS

                            //PARTE DE VARIABLES GLOBALES (NO MOVER NI MODIFICAR).
                            //Asignar valor variables globales.
                            /*
                            DAOSolicitudes sol = new DAOSolicitudes();
                            sol.Asignacion(cboPrenda.Text, txtCliente.Text, txtLote.Text, txtDescripcion.Text, txtPrecioU.Text, Int32.Parse(txtPrecioU.Text) * Int32.Parse(txtLote.Text) + "", txtImporte.Text);
                            if (txtDescripcion.Text.ToLower().Equals("sin falda") || txtDescripcion.Text.ToLower().Equals("sin sueter") || txtDescripcion.Text.ToLower().Equals("sin playera") || txtDescripcion.Text.ToLower().Equals("sin pantalon")) proc.Eliminacion(txtDescripcion.Text.ToLower(), Int16.Parse(txtLote.Text));
                            Mandar a comprobante
                            frmComprobante comp = new frmComprobante();
                            comp.Show();
                            this.Hide();
                            */
                            this.Close();
                            
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar la solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el ingreso de datos. Verifique de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else MessageBox.Show("Debe calcular el importe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

        private void frmModificarSolicitudes_Load(object sender, EventArgs e) {
            // ANIMACIÓN BOTÓN SALIR
            btnSalir.MouseHover += new EventHandler(this.activarMano);
            btnSalir.MouseMove += new MouseEventHandler(this.activarMano);
            btnSalir.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN ATRÁS
            btnAtras.MouseHover += new EventHandler(this.activarMano);
            btnAtras.MouseMove += new MouseEventHandler(this.activarMano);
            btnAtras.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN MODIFICAR
            btnGuardar.MouseHover += new EventHandler(this.activarMano);
            btnGuardar.MouseMove += new MouseEventHandler(this.activarMano);
            btnGuardar.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN ELIMINAR
            btnCancelar.MouseHover += new EventHandler(this.activarMano);
            btnCancelar.MouseMove += new MouseEventHandler(this.activarMano);
            btnCancelar.MouseLeave += new EventHandler(this.desactivarMano);
        }

        private void btnAtras_Click(object sender, EventArgs e) {
            btnSalir_Click(this, new EventArgs());
        }

        private void cboPrenda_TextChanged(object sender, EventArgs e)
        {
            txtPrecioU.Text = proc.PrecioUnitario(cboPrenda.Text);
            flag = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                txtImporte.Text = proc.Seguro(Int16.Parse(txtPrecioU.Text), Int16.Parse(txtLote.Text));
                flag = true;
            }catch (Exception Ex) { 

            }
        }

        private void txtLote_TextChanged(object sender, EventArgs e)
        {
            flag = false;
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
