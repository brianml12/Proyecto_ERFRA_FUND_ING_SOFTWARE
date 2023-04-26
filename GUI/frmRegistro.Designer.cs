namespace GUI
{
    partial class frmRegistro
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
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new Windows.Forms.HintTextBox(this.components);
            this.txtApellido = new Windows.Forms.HintTextBox(this.components);
            this.txtCorreo = new Windows.Forms.HintTextBox(this.components);
            this.txtUsuario = new Windows.Forms.HintTextBox(this.components);
            this.txtContraseña = new Windows.Forms.HintTextBox(this.components);
            this.txtConfirmacion = new Windows.Forms.HintTextBox(this.components);
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.btnVer2 = new System.Windows.Forms.Button();
            this.btnVer1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(699, 62);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::GUI.Properties.Resources._16;
            this.btnSalir.Location = new System.Drawing.Point(632, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(67, 62);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.cboSexo.ForeColor = System.Drawing.Color.Gray;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cboSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Otro"});
            this.cboSexo.Location = new System.Drawing.Point(272, 208);
            this.cboSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(359, 33);
            this.cboSexo.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.EnterToTab = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.HintColor = System.Drawing.Color.Gray;
            this.txtNombre.HintValue = "Nombre";
            this.txtNombre.Location = new System.Drawing.Point(272, 121);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(359, 32);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextForeColor = System.Drawing.Color.Black;
            this.txtNombre.Value = "";
            // 
            // txtApellido
            // 
            this.txtApellido.EnterToTab = false;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.Gray;
            this.txtApellido.HintColor = System.Drawing.Color.Gray;
            this.txtApellido.HintValue = "Apellido";
            this.txtApellido.Location = new System.Drawing.Point(272, 165);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(359, 32);
            this.txtApellido.TabIndex = 9;
            this.txtApellido.Text = "Apellido";
            this.txtApellido.TextForeColor = System.Drawing.Color.Black;
            this.txtApellido.Value = "";
            // 
            // txtCorreo
            // 
            this.txtCorreo.EnterToTab = false;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Gray;
            this.txtCorreo.HintColor = System.Drawing.Color.Gray;
            this.txtCorreo.HintValue = "Correo";
            this.txtCorreo.Location = new System.Drawing.Point(272, 247);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(359, 32);
            this.txtCorreo.TabIndex = 11;
            this.txtCorreo.Text = "Correo";
            this.txtCorreo.TextForeColor = System.Drawing.Color.Black;
            this.txtCorreo.Value = "";
            // 
            // txtUsuario
            // 
            this.txtUsuario.EnterToTab = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txtUsuario.HintColor = System.Drawing.Color.Gray;
            this.txtUsuario.HintValue = "Usuario";
            this.txtUsuario.Location = new System.Drawing.Point(272, 292);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(359, 32);
            this.txtUsuario.TabIndex = 12;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.TextForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Value = "";
            // 
            // txtContraseña
            // 
            this.txtContraseña.EnterToTab = false;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Gray;
            this.txtContraseña.HintColor = System.Drawing.Color.Gray;
            this.txtContraseña.HintValue = "Contraseña";
            this.txtContraseña.Location = new System.Drawing.Point(272, 336);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(359, 32);
            this.txtContraseña.TabIndex = 13;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.TextForeColor = System.Drawing.Color.Black;
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.Value = "";
            // 
            // txtConfirmacion
            // 
            this.txtConfirmacion.EnterToTab = false;
            this.txtConfirmacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacion.ForeColor = System.Drawing.Color.Gray;
            this.txtConfirmacion.HintColor = System.Drawing.Color.Gray;
            this.txtConfirmacion.HintValue = "Confirmar contraseña";
            this.txtConfirmacion.Location = new System.Drawing.Point(272, 380);
            this.txtConfirmacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.Size = new System.Drawing.Size(359, 32);
            this.txtConfirmacion.TabIndex = 15;
            this.txtConfirmacion.Text = "Confirmar contraseña";
            this.txtConfirmacion.TextForeColor = System.Drawing.Color.Black;
            this.txtConfirmacion.UseSystemPasswordChar = true;
            this.txtConfirmacion.Value = "";
            // 
            // cboRol
            // 
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.cboRol.ForeColor = System.Drawing.Color.Gray;
            this.cboRol.FormattingEnabled = true;
            this.cboRol.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cboRol.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cboRol.Location = new System.Drawing.Point(272, 422);
            this.cboRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(359, 33);
            this.cboRol.TabIndex = 17;
            // 
            // btnVer2
            // 
            this.btnVer2.FlatAppearance.BorderSize = 0;
            this.btnVer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer2.Image = global::GUI.Properties.Resources.ojo;
            this.btnVer2.Location = new System.Drawing.Point(640, 379);
            this.btnVer2.Margin = new System.Windows.Forms.Padding(4);
            this.btnVer2.Name = "btnVer2";
            this.btnVer2.Size = new System.Drawing.Size(40, 37);
            this.btnVer2.TabIndex = 16;
            this.btnVer2.UseVisualStyleBackColor = true;
            this.btnVer2.Click += new System.EventHandler(this.btnVer2_Click);
            // 
            // btnVer1
            // 
            this.btnVer1.FlatAppearance.BorderSize = 0;
            this.btnVer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer1.Image = global::GUI.Properties.Resources.ojo;
            this.btnVer1.Location = new System.Drawing.Point(640, 335);
            this.btnVer1.Margin = new System.Windows.Forms.Padding(4);
            this.btnVer1.Name = "btnVer1";
            this.btnVer1.Size = new System.Drawing.Size(40, 37);
            this.btnVer1.TabIndex = 14;
            this.btnVer1.UseVisualStyleBackColor = true;
            this.btnVer1.Click += new System.EventHandler(this.btnVer1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnCancelar.Image = global::GUI.Properties.Resources.x__4_;
            this.btnCancelar.Location = new System.Drawing.Point(411, 489);
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
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(244)))), ((int)(((byte)(216)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(159)))), ((int)(((byte)(130)))));
            this.btnRegistrar.Image = global::GUI.Properties.Resources.agregar_usuario;
            this.btnRegistrar.Location = new System.Drawing.Point(157, 489);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(173, 43);
            this.btnRegistrar.TabIndex = 18;
            this.btnRegistrar.Text = " Registrarse";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // epError
            // 
            this.epError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epError.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 293);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 341);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 27);
            this.label7.TabIndex = 5;
            this.label7.Text = "Contraseña";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 382);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 27);
            this.label8.TabIndex = 6;
            this.label8.Text = "Confirmar Contraseña";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(219, 423);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 27);
            this.label9.TabIndex = 7;
            this.label9.Text = "Rol";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 76);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 31);
            this.label10.TabIndex = 21;
            this.label10.Text = "Registro";
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 562);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVer2);
            this.Controls.Add(this.btnVer1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cboRol);
            this.Controls.Add(this.txtConfirmacion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistro";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cboSexo;
        private Windows.Forms.HintTextBox txtNombre;
        private Windows.Forms.HintTextBox txtApellido;
        private Windows.Forms.HintTextBox txtCorreo;
        private Windows.Forms.HintTextBox txtUsuario;
        private Windows.Forms.HintTextBox txtContraseña;
        private Windows.Forms.HintTextBox txtConfirmacion;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVer1;
        private System.Windows.Forms.Button btnVer2;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
    }
}