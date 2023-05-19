namespace GUI
{
    partial class frmAgregarSolicitudes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecioU = new Windows.Forms.HintTextBox(this.components);
            this.txtLote = new Windows.Forms.HintTextBox(this.components);
            this.txtDescripcion = new Windows.Forms.HintTextBox(this.components);
            this.txtImporte = new Windows.Forms.HintTextBox(this.components);
            this.cboPrenda = new System.Windows.Forms.ComboBox();
            this.pbPorcentaje = new System.Windows.Forms.ProgressBar();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtCliente = new Windows.Forms.HintTextBox(this.components);
            this.ErrorCampos = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCampos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(161)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 50);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregar Solicitud";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::GUI.Properties.Resources._16;
            this.btnSalir.Location = new System.Drawing.Point(457, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnCancelar.Image = global::GUI.Properties.Resources.x__4_;
            this.btnCancelar.Location = new System.Drawing.Point(286, 397);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 35);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "  Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(244)))), ((int)(((byte)(216)))));
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(159)))), ((int)(((byte)(130)))));
            this.btnInsertar.Image = global::GUI.Properties.Resources.mas__1_;
            this.btnInsertar.Location = new System.Drawing.Point(93, 397);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(130, 35);
            this.btnInsertar.TabIndex = 7;
            this.btnInsertar.Text = "  Insertar";
            this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(70, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Agregar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrecioU
            // 
            this.txtPrecioU.EnterToTab = false;
            this.txtPrecioU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioU.ForeColor = System.Drawing.Color.Gray;
            this.txtPrecioU.HintColor = System.Drawing.Color.Gray;
            this.txtPrecioU.HintValue = "Precio Unitario";
            this.txtPrecioU.Location = new System.Drawing.Point(131, 194);
            this.txtPrecioU.Name = "txtPrecioU";
            this.txtPrecioU.ReadOnly = true;
            this.txtPrecioU.Size = new System.Drawing.Size(270, 27);
            this.txtPrecioU.TabIndex = 2;
            this.txtPrecioU.Text = "Precio Unitario";
            this.txtPrecioU.TextForeColor = System.Drawing.Color.Black;
            this.txtPrecioU.Value = "";
            // 
            // txtLote
            // 
            this.txtLote.EnterToTab = false;
            this.txtLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.ForeColor = System.Drawing.Color.Gray;
            this.txtLote.HintColor = System.Drawing.Color.Gray;
            this.txtLote.HintValue = "Lote";
            this.txtLote.Location = new System.Drawing.Point(131, 230);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(270, 27);
            this.txtLote.TabIndex = 3;
            this.txtLote.Text = "Lote";
            this.txtLote.TextForeColor = System.Drawing.Color.Black;
            this.txtLote.Value = "";
            this.txtLote.TextChanged += new System.EventHandler(this.txtLote_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.EnterToTab = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.txtDescripcion.HintColor = System.Drawing.Color.Gray;
            this.txtDescripcion.HintValue = "Descripción";
            this.txtDescripcion.Location = new System.Drawing.Point(131, 266);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(270, 27);
            this.txtDescripcion.TabIndex = 4;
            this.txtDescripcion.Text = "Descripción";
            this.txtDescripcion.TextForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Value = "";
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtImporte
            // 
            this.txtImporte.EnterToTab = false;
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.ForeColor = System.Drawing.Color.Gray;
            this.txtImporte.HintColor = System.Drawing.Color.Gray;
            this.txtImporte.HintValue = "Importe";
            this.txtImporte.Location = new System.Drawing.Point(131, 302);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(270, 27);
            this.txtImporte.TabIndex = 5;
            this.txtImporte.Text = "Importe";
            this.txtImporte.TextForeColor = System.Drawing.Color.Black;
            this.txtImporte.Value = "";
            this.txtImporte.TextChanged += new System.EventHandler(this.txtImporte_TextChanged);
            // 
            // cboPrenda
            // 
            this.cboPrenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.cboPrenda.ForeColor = System.Drawing.Color.Gray;
            this.cboPrenda.FormattingEnabled = true;
            this.cboPrenda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboPrenda.Location = new System.Drawing.Point(132, 122);
            this.cboPrenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboPrenda.Name = "cboPrenda";
            this.cboPrenda.Size = new System.Drawing.Size(270, 28);
            this.cboPrenda.TabIndex = 0;
            this.cboPrenda.TextChanged += new System.EventHandler(this.cboPrenda_TextChanged);
            // 
            // pbPorcentaje
            // 
            this.pbPorcentaje.Location = new System.Drawing.Point(131, 349);
            this.pbPorcentaje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbPorcentaje.Name = "pbPorcentaje";
            this.pbPorcentaje.Size = new System.Drawing.Size(247, 19);
            this.pbPorcentaje.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbPorcentaje.TabIndex = 24;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.ForeColor = System.Drawing.Color.Black;
            this.lblPorcentaje.Location = new System.Drawing.Point(325, 353);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(0, 18);
            this.lblPorcentaje.TabIndex = 25;
            this.lblPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAtras
            // 
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Image = global::GUI.Properties.Resources.flecha_pequena_izquierda__1_;
            this.btnAtras.Location = new System.Drawing.Point(16, 65);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(32, 30);
            this.btnAtras.TabIndex = 9;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.EnterToTab = false;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.Gray;
            this.txtCliente.HintColor = System.Drawing.Color.Gray;
            this.txtCliente.HintValue = "Nombre del cliente";
            this.txtCliente.Location = new System.Drawing.Point(132, 159);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(270, 27);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.Text = "Nombre del cliente";
            this.txtCliente.TextForeColor = System.Drawing.Color.Black;
            this.txtCliente.Value = "";
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // ErrorCampos
            // 
            this.ErrorCampos.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorCampos.ContainerControl = this;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(410, 306);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(57, 30);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 22);
            this.label10.TabIndex = 26;
            this.label10.Text = "Prenda";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Precio Uni.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "Lote";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "Descripción";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 22);
            this.label7.TabIndex = 31;
            this.label7.Text = "Proceso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 32;
            this.label8.Text = "Importe";
            // 
            // frmAgregarSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 464);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.pbPorcentaje);
            this.Controls.Add(this.cboPrenda);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.txtPrecioU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarSolicitudes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarSolicitudes";
            this.Load += new System.EventHandler(this.frmAgregarSolicitudes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCampos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private Windows.Forms.HintTextBox txtPrecioU;
        private Windows.Forms.HintTextBox txtLote;
        private Windows.Forms.HintTextBox txtDescripcion;
        private Windows.Forms.HintTextBox txtImporte;
        private System.Windows.Forms.ComboBox cboPrenda;
        private System.Windows.Forms.ProgressBar pbPorcentaje;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Button btnAtras;
        private Windows.Forms.HintTextBox txtCliente;
        private System.Windows.Forms.ErrorProvider ErrorCampos;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}