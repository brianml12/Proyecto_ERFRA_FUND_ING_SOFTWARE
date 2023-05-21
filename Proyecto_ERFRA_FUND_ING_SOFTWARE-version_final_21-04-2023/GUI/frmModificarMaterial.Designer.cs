namespace GUI
{
    partial class frmModificarMaterial
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoMaterial = new Windows.Forms.HintTextBox(this.components);
            this.txtNombre = new Windows.Forms.HintTextBox(this.components);
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.txtColor = new Windows.Forms.HintTextBox(this.components);
            this.txtCantidad = new Windows.Forms.HintTextBox(this.components);
            this.txtTipoMaterial = new Windows.Forms.HintTextBox(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUsuario = new Windows.Forms.HintTextBox(this.components);
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(161)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 62);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modificar Material";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::GUI.Properties.Resources._16;
            this.btnSalir.Location = new System.Drawing.Point(588, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(67, 62);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(93, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Modificar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigoMaterial
            // 
            this.txtCodigoMaterial.EnterToTab = false;
            this.txtCodigoMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoMaterial.ForeColor = System.Drawing.Color.Gray;
            this.txtCodigoMaterial.HintColor = System.Drawing.Color.Gray;
            this.txtCodigoMaterial.HintValue = "Clave Material";
            this.txtCodigoMaterial.Location = new System.Drawing.Point(229, 164);
            this.txtCodigoMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoMaterial.Name = "txtCodigoMaterial";
            this.txtCodigoMaterial.ReadOnly = true;
            this.txtCodigoMaterial.Size = new System.Drawing.Size(359, 32);
            this.txtCodigoMaterial.TabIndex = 9;
            this.txtCodigoMaterial.Text = "Codigo Material";
            this.txtCodigoMaterial.TextForeColor = System.Drawing.Color.Gray;
            this.txtCodigoMaterial.Value = "Codigo Material";
            // 
            // txtNombre
            // 
            this.txtNombre.EnterToTab = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.HintColor = System.Drawing.Color.Gray;
            this.txtNombre.HintValue = "Nombre de Material";
            this.txtNombre.Location = new System.Drawing.Point(229, 208);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(359, 32);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.Text = "Nombre de Material";
            this.txtNombre.TextForeColor = System.Drawing.Color.Black;
            this.txtNombre.Value = "";
            // 
            // cboProveedor
            // 
            this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.cboProveedor.ForeColor = System.Drawing.Color.Gray;
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboProveedor.Location = new System.Drawing.Point(229, 426);
            this.cboProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(268, 33);
            this.cboProveedor.TabIndex = 15;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.ForeColor = System.Drawing.Color.Black;
            this.lblPorcentaje.Location = new System.Drawing.Point(589, 373);
            this.lblPorcentaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(0, 22);
            this.lblPorcentaje.TabIndex = 25;
            this.lblPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtColor
            // 
            this.txtColor.EnterToTab = false;
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.ForeColor = System.Drawing.Color.Gray;
            this.txtColor.HintColor = System.Drawing.Color.Gray;
            this.txtColor.HintValue = "Color";
            this.txtColor.Location = new System.Drawing.Point(229, 252);
            this.txtColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(359, 32);
            this.txtColor.TabIndex = 11;
            this.txtColor.Text = "Color";
            this.txtColor.TextForeColor = System.Drawing.Color.Black;
            this.txtColor.Value = "";
            // 
            // txtCantidad
            // 
            this.txtCantidad.EnterToTab = false;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.Gray;
            this.txtCantidad.HintColor = System.Drawing.Color.Gray;
            this.txtCantidad.HintValue = "Cantidad";
            this.txtCantidad.Location = new System.Drawing.Point(229, 297);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(359, 32);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.Text = "Cantidad";
            this.txtCantidad.TextForeColor = System.Drawing.Color.Black;
            this.txtCantidad.Value = "";
            // 
            // txtTipoMaterial
            // 
            this.txtTipoMaterial.EnterToTab = false;
            this.txtTipoMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoMaterial.ForeColor = System.Drawing.Color.Gray;
            this.txtTipoMaterial.HintColor = System.Drawing.Color.Gray;
            this.txtTipoMaterial.HintValue = "Tipo de Material";
            this.txtTipoMaterial.Location = new System.Drawing.Point(229, 341);
            this.txtTipoMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoMaterial.Name = "txtTipoMaterial";
            this.txtTipoMaterial.Size = new System.Drawing.Size(359, 32);
            this.txtTipoMaterial.TabIndex = 13;
            this.txtTipoMaterial.Text = "Tipo de Material";
            this.txtTipoMaterial.TextForeColor = System.Drawing.Color.Black;
            this.txtTipoMaterial.Value = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(229, 383);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(359, 30);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // btnAtras
            // 
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Image = global::GUI.Properties.Resources.flecha_pequena_izquierda__1_;
            this.btnAtras.Location = new System.Drawing.Point(21, 70);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(43, 37);
            this.btnAtras.TabIndex = 20;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnCancelar.Image = global::GUI.Properties.Resources.x__4_;
            this.btnCancelar.Location = new System.Drawing.Point(393, 486);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(173, 43);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "  Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(237)))), ((int)(((byte)(152)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(147)))), ((int)(((byte)(23)))));
            this.btnGuardar.Image = global::GUI.Properties.Resources.disco;
            this.btnGuardar.Location = new System.Drawing.Point(128, 486);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(173, 43);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "  Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "Codigo material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre material";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(147, 251);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 27);
            this.label7.TabIndex = 3;
            this.label7.Text = "Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(108, 297);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 27);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 341);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 27);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tipo Material";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 384);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 425);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Proveedor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(123, 123);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 27);
            this.label10.TabIndex = 0;
            this.label10.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.EnterToTab = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txtUsuario.HintColor = System.Drawing.Color.Gray;
            this.txtUsuario.HintValue = "Clave Material";
            this.txtUsuario.Location = new System.Drawing.Point(229, 122);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(359, 32);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.TextForeColor = System.Drawing.Color.Gray;
            this.txtUsuario.Value = "Usuario";
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.FlatAppearance.BorderSize = 0;
            this.btnAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProveedor.Image = global::GUI.Properties.Resources.agregar_usuario__1_;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(505, 423);
            this.btnAgregarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(43, 37);
            this.btnAgregarProveedor.TabIndex = 16;
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.FlatAppearance.BorderSize = 0;
            this.btnEliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProveedor.Image = global::GUI.Properties.Resources.basura__1_;
            this.btnEliminarProveedor.Location = new System.Drawing.Point(547, 423);
            this.btnEliminarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(43, 37);
            this.btnEliminarProveedor.TabIndex = 17;
            this.btnEliminarProveedor.UseVisualStyleBackColor = true;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // epError
            // 
            this.epError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epError.ContainerControl = this;
            // 
            // frmModificarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 543);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtTipoMaterial);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.cboProveedor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigoMaterial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmModificarMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarMaterial";
            this.Load += new System.EventHandler(this.frmAgregarMaterial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private Windows.Forms.HintTextBox txtCodigoMaterial;
        private Windows.Forms.HintTextBox txtNombre;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Button btnAtras;
        private Windows.Forms.HintTextBox txtColor;
        private Windows.Forms.HintTextBox txtCantidad;
        private Windows.Forms.HintTextBox txtTipoMaterial;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private Windows.Forms.HintTextBox txtUsuario;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.ErrorProvider epError;
    }
}