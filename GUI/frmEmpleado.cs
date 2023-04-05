﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

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

        public void activarMano(object sender, EventArgs e) {
            Cursor = Cursors.Hand;
        }

        public void desactivarMano(object sender, EventArgs e) {
            Cursor = Cursors.Default;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e) {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(respuesta == DialogResult.Yes) {
                frmLogin frm = new frmLogin();
                frm.Show();
                this.Close();
            }
        }

        private void btnSolicitudes_Click(object sender, EventArgs e)
        {
            frmSolicitudes solicitudes = new frmSolicitudes();
            solicitudes.Show();
            this.Hide();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            // ANIMACIÓN BOTÓN SALIR
            btnSalir.MouseHover += new EventHandler(this.activarMano);
            btnSalir.MouseMove += new MouseEventHandler(this.activarMano);
            btnSalir.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN VENTAS
            btnVentas.MouseHover += new EventHandler(this.activarMano);
            btnVentas.MouseMove += new MouseEventHandler(this.activarMano);
            btnVentas.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN MATERIA PRIMA
            btnSolicitudes.MouseHover += new EventHandler(this.activarMano);
            btnSolicitudes.MouseMove += new MouseEventHandler(this.activarMano);
            btnSolicitudes.MouseLeave += new EventHandler(this.desactivarMano);
            // ANIMACIÓN BOTÓN CERRAR SESIÓN
            btnCerrarSesion.MouseHover += new EventHandler(this.activarMano);
            btnCerrarSesion.MouseMove += new MouseEventHandler(this.activarMano);
            btnCerrarSesion.MouseLeave += new EventHandler(this.desactivarMano);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e) {
            btnSalir_Click(this, new EventArgs());
        }
    }
}
