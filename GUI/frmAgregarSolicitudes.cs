using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class frmAgregarSolicitudes : Form
    {
        public frmAgregarSolicitudes()
        {
            InitializeComponent();
            cboPrenda.Items.Add("Prenda");
            cboPrenda.SelectedIndex = 0;
            cboPrenda.Items.Add("Playera");
            cboPrenda.Items.Add("Sueter");
            cboPrenda.Items.Add("Pantalon");
            cboPrenda.Items.Add("Uniforme");
            cboPrenda.Items.Add("Short");
            cboPrenda.Items.Add("Falda");
        }
        //Objeto para el aumento de la barra de progreso.
        DAOBarraProgreso proc = new DAOBarraProgreso();
        bool flag = false;

        protected override void OnPaint(PaintEventArgs e)
        {
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
            using (Pen borderPen = new Pen(Color.FromArgb(255, 64, 64, 64), 2))
            {
                e.Graphics.DrawPath(borderPen, borderPath);
            }
        }

        public void activarMano(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        public void desactivarMano(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmVentas frm = new frmVentas();
            frm.Tag = this.Tag;
            frm.Show();
            this.Close();
        }

        private void frmAgregarSolicitudes_Load(object sender, EventArgs e)
        {
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
            lblPorcentaje.Text = pbPorcentaje.Value + "%";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
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
            txtPrecioU.Text = proc.PrecioUnitario(cboPrenda.Text);
            flag = false;
        }

        private void txtLote_TextChanged(object sender, EventArgs e)
        {
            lblPorcentaje.Text = proc.progresoL(txtLote.Text) + "%";
            pbPorcentaje.Value = Int16.Parse(proc.progresoL(txtLote.Text));
            flag = false;
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
            flag = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
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
                        objSolicitud.NombreCliente = txtCliente.Text;
                        objSolicitud.NombreProducto = cboPrenda.SelectedItem.ToString();
                        objSolicitud.Descripcion = txtDescripcion.Text;
                        objSolicitud.Lote = int.Parse(txtLote.Text);
                        objSolicitud.PrecioUnitario = int.Parse(txtPrecioU.Text);
                        objSolicitud.Importe = int.Parse(txtImporte.Text);
                        objSolicitud.IdUsuario = VariablesGlobales.IdUsuarioLogeado;
                        if (new DAOSolicitudes().agregar(objSolicitud))
                        {
                            MessageBox.Show("Solicitud registrada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //btnSalir_Click(this, new EventArgs());
                            //PARTE DE VARIABLES GLOBALES (NO MOVER NI MODIFICAR).
                            DAOSolicitudes sol = new DAOSolicitudes();
                            sol.Asignacion(cboPrenda.Text, txtCliente.Text, txtLote.Text, txtDescripcion.Text, txtPrecioU.Text, Int32.Parse(txtPrecioU.Text) * Int32.Parse(txtLote.Text) + "", txtImporte.Text);
                            
                            frmComprobante comp = new frmComprobante();
                            comp.Tag = this.Tag;
                            comp.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar la solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el ingreso de datos. Verifique de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else MessageBox.Show("Debe calcular el precio", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Boton para probar el comprobante
        

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            lblPorcentaje.Text = proc.progresoC(txtCliente.Text) + "%";
            pbPorcentaje.Value = Int16.Parse(proc.progresoC(txtCliente.Text));
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                txtImporte.Text = proc.Seguro(Int16.Parse(txtPrecioU.Text), Int16.Parse(txtLote.Text));
                flag = true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No se puede calcular, Complete los datos.", MessageBoxIcon.Error + "");
                
            }
        }
    }
}
