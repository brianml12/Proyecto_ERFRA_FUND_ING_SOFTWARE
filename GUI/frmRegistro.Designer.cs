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
            this.cboPrenda = new System.Windows.Forms.ComboBox();
            this.txtPrecioU = new Windows.Forms.HintTextBox(this.components);
            this.hintTextBox1 = new Windows.Forms.HintTextBox(this.components);
            this.hintTextBox2 = new Windows.Forms.HintTextBox(this.components);
            this.hintTextBox3 = new Windows.Forms.HintTextBox(this.components);
            this.hintTextBox4 = new Windows.Forms.HintTextBox(this.components);
            this.hintTextBox5 = new Windows.Forms.HintTextBox(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnVer2 = new System.Windows.Forms.Button();
            this.btnVer1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(407, 50);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
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
            this.btnSalir.Location = new System.Drawing.Point(357, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cboPrenda
            // 
            this.cboPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.cboPrenda.ForeColor = System.Drawing.Color.Gray;
            this.cboPrenda.FormattingEnabled = true;
            this.cboPrenda.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cboPrenda.Location = new System.Drawing.Point(58, 140);
            this.cboPrenda.Margin = new System.Windows.Forms.Padding(2);
            this.cboPrenda.Name = "cboPrenda";
            this.cboPrenda.Size = new System.Drawing.Size(270, 28);
            this.cboPrenda.TabIndex = 2;
            this.cboPrenda.Text = "Genero";
            // 
            // txtPrecioU
            // 
            this.txtPrecioU.EnterToTab = false;
            this.txtPrecioU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioU.ForeColor = System.Drawing.Color.Gray;
            this.txtPrecioU.HintColor = System.Drawing.Color.Gray;
            this.txtPrecioU.HintValue = "Nombre";
            this.txtPrecioU.Location = new System.Drawing.Point(58, 69);
            this.txtPrecioU.Multiline = true;
            this.txtPrecioU.Name = "txtPrecioU";
            this.txtPrecioU.Size = new System.Drawing.Size(270, 30);
            this.txtPrecioU.TabIndex = 0;
            this.txtPrecioU.Text = "Nombre";
            this.txtPrecioU.TextForeColor = System.Drawing.Color.Black;
            this.txtPrecioU.Value = "";
            // 
            // hintTextBox1
            // 
            this.hintTextBox1.EnterToTab = false;
            this.hintTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.hintTextBox1.HintColor = System.Drawing.Color.Gray;
            this.hintTextBox1.HintValue = "Apellidos";
            this.hintTextBox1.Location = new System.Drawing.Point(58, 105);
            this.hintTextBox1.Multiline = true;
            this.hintTextBox1.Name = "hintTextBox1";
            this.hintTextBox1.Size = new System.Drawing.Size(270, 30);
            this.hintTextBox1.TabIndex = 1;
            this.hintTextBox1.Text = "Apellidos";
            this.hintTextBox1.TextForeColor = System.Drawing.Color.Black;
            this.hintTextBox1.Value = "";
            // 
            // hintTextBox2
            // 
            this.hintTextBox2.EnterToTab = false;
            this.hintTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintTextBox2.ForeColor = System.Drawing.Color.Gray;
            this.hintTextBox2.HintColor = System.Drawing.Color.Gray;
            this.hintTextBox2.HintValue = "Correo";
            this.hintTextBox2.Location = new System.Drawing.Point(58, 172);
            this.hintTextBox2.Multiline = true;
            this.hintTextBox2.Name = "hintTextBox2";
            this.hintTextBox2.Size = new System.Drawing.Size(270, 30);
            this.hintTextBox2.TabIndex = 3;
            this.hintTextBox2.Text = "Correo";
            this.hintTextBox2.TextForeColor = System.Drawing.Color.Black;
            this.hintTextBox2.Value = "";
            // 
            // hintTextBox3
            // 
            this.hintTextBox3.EnterToTab = false;
            this.hintTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintTextBox3.ForeColor = System.Drawing.Color.Gray;
            this.hintTextBox3.HintColor = System.Drawing.Color.Gray;
            this.hintTextBox3.HintValue = "Usuario";
            this.hintTextBox3.Location = new System.Drawing.Point(58, 208);
            this.hintTextBox3.Multiline = true;
            this.hintTextBox3.Name = "hintTextBox3";
            this.hintTextBox3.Size = new System.Drawing.Size(270, 30);
            this.hintTextBox3.TabIndex = 4;
            this.hintTextBox3.Text = "Usuario";
            this.hintTextBox3.TextForeColor = System.Drawing.Color.Black;
            this.hintTextBox3.Value = "";
            // 
            // hintTextBox4
            // 
            this.hintTextBox4.EnterToTab = false;
            this.hintTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintTextBox4.ForeColor = System.Drawing.Color.Gray;
            this.hintTextBox4.HintColor = System.Drawing.Color.Gray;
            this.hintTextBox4.HintValue = "Contraseña";
            this.hintTextBox4.Location = new System.Drawing.Point(58, 244);
            this.hintTextBox4.Multiline = true;
            this.hintTextBox4.Name = "hintTextBox4";
            this.hintTextBox4.Size = new System.Drawing.Size(270, 30);
            this.hintTextBox4.TabIndex = 5;
            this.hintTextBox4.Text = "Contraseña";
            this.hintTextBox4.TextForeColor = System.Drawing.Color.Black;
            this.hintTextBox4.Value = "";
            // 
            // hintTextBox5
            // 
            this.hintTextBox5.EnterToTab = false;
            this.hintTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintTextBox5.ForeColor = System.Drawing.Color.Gray;
            this.hintTextBox5.HintColor = System.Drawing.Color.Gray;
            this.hintTextBox5.HintValue = "Confirmar contraseña";
            this.hintTextBox5.Location = new System.Drawing.Point(58, 280);
            this.hintTextBox5.Multiline = true;
            this.hintTextBox5.Name = "hintTextBox5";
            this.hintTextBox5.Size = new System.Drawing.Size(270, 30);
            this.hintTextBox5.TabIndex = 7;
            this.hintTextBox5.Text = "Confirmar contraseña";
            this.hintTextBox5.TextForeColor = System.Drawing.Color.Black;
            this.hintTextBox5.Value = "";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.comboBox1.ForeColor = System.Drawing.Color.Gray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBox1.Location = new System.Drawing.Point(58, 314);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 28);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Rol";
            // 
            // btnVer2
            // 
            this.btnVer2.FlatAppearance.BorderSize = 0;
            this.btnVer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer2.Image = global::GUI.Properties.Resources.ojo;
            this.btnVer2.Location = new System.Drawing.Point(334, 279);
            this.btnVer2.Name = "btnVer2";
            this.btnVer2.Size = new System.Drawing.Size(30, 30);
            this.btnVer2.TabIndex = 8;
            this.btnVer2.UseVisualStyleBackColor = true;
            // 
            // btnVer1
            // 
            this.btnVer1.FlatAppearance.BorderSize = 0;
            this.btnVer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer1.Image = global::GUI.Properties.Resources.ojo;
            this.btnVer1.Location = new System.Drawing.Point(334, 243);
            this.btnVer1.Name = "btnVer1";
            this.btnVer1.Size = new System.Drawing.Size(30, 30);
            this.btnVer1.TabIndex = 6;
            this.btnVer1.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnCancelar.Image = global::GUI.Properties.Resources.x__4_;
            this.btnCancelar.Location = new System.Drawing.Point(234, 379);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 35);
            this.btnCancelar.TabIndex = 11;
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
            this.btnRegistrar.Location = new System.Drawing.Point(44, 379);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(130, 35);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = " Registrarse";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 446);
            this.Controls.Add(this.btnVer2);
            this.Controls.Add(this.btnVer1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.hintTextBox5);
            this.Controls.Add(this.hintTextBox4);
            this.Controls.Add(this.hintTextBox3);
            this.Controls.Add(this.hintTextBox2);
            this.Controls.Add(this.hintTextBox1);
            this.Controls.Add(this.txtPrecioU);
            this.Controls.Add(this.cboPrenda);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistro";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cboPrenda;
        private Windows.Forms.HintTextBox txtPrecioU;
        private Windows.Forms.HintTextBox hintTextBox1;
        private Windows.Forms.HintTextBox hintTextBox2;
        private Windows.Forms.HintTextBox hintTextBox3;
        private Windows.Forms.HintTextBox hintTextBox4;
        private Windows.Forms.HintTextBox hintTextBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVer1;
        private System.Windows.Forms.Button btnVer2;
    }
}