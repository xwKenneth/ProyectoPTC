﻿
namespace SBPA
{
    partial class cuentaInfantil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombrebeneficiario = new System.Windows.Forms.TextBox();
            this.txtNombreCuenta = new System.Windows.Forms.TextBox();
            this.txtNombremadre = new System.Windows.Forms.TextBox();
            this.txtNombrepadre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSaldoahorrado = new System.Windows.Forms.TextBox();
            this.txtSaldoabonar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRetirar = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.txtNombrebeneficiario);
            this.panel1.Controls.Add(this.txtNombreCuenta);
            this.panel1.Controls.Add(this.txtNombremadre);
            this.panel1.Controls.Add(this.txtNombrepadre);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 200);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // txtNombrebeneficiario
            // 
            this.txtNombrebeneficiario.Location = new System.Drawing.Point(395, 161);
            this.txtNombrebeneficiario.Name = "txtNombrebeneficiario";
            this.txtNombrebeneficiario.Size = new System.Drawing.Size(167, 23);
            this.txtNombrebeneficiario.TabIndex = 9;
            this.txtNombrebeneficiario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrebeneficiario_KeyPress);
            // 
            // txtNombreCuenta
            // 
            this.txtNombreCuenta.Location = new System.Drawing.Point(395, 128);
            this.txtNombreCuenta.Name = "txtNombreCuenta";
            this.txtNombreCuenta.Size = new System.Drawing.Size(100, 23);
            this.txtNombreCuenta.TabIndex = 8;
            this.txtNombreCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerocuenta_KeyPress);
            // 
            // txtNombremadre
            // 
            this.txtNombremadre.Location = new System.Drawing.Point(395, 88);
            this.txtNombremadre.Name = "txtNombremadre";
            this.txtNombremadre.Size = new System.Drawing.Size(167, 23);
            this.txtNombremadre.TabIndex = 7;
            this.txtNombremadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombremadre_KeyPress);
            // 
            // txtNombrepadre
            // 
            this.txtNombrepadre.Location = new System.Drawing.Point(395, 54);
            this.txtNombrepadre.Name = "txtNombrepadre";
            this.txtNombrepadre.Size = new System.Drawing.Size(167, 23);
            this.txtNombrepadre.TabIndex = 6;
            this.txtNombrepadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrepadre_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(192, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nombre del beneficiario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(192, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre de la cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(192, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre de la madre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(192, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del padre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos personales";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SBPA.Properties.Resources.png_clipart_computer_icons_user_profile_avatar_profile_heroes_profile_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(151, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Saldo ahorrado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(151, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Saldo a abonar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(62, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Saldo";
            // 
            // txtSaldoahorrado
            // 
            this.txtSaldoahorrado.Location = new System.Drawing.Point(298, 253);
            this.txtSaldoahorrado.Name = "txtSaldoahorrado";
            this.txtSaldoahorrado.Size = new System.Drawing.Size(131, 23);
            this.txtSaldoahorrado.TabIndex = 5;
            this.txtSaldoahorrado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldoahorrado_KeyPress);
            // 
            // txtSaldoabonar
            // 
            this.txtSaldoabonar.Location = new System.Drawing.Point(298, 313);
            this.txtSaldoabonar.Name = "txtSaldoabonar";
            this.txtSaldoabonar.Size = new System.Drawing.Size(131, 23);
            this.txtSaldoabonar.TabIndex = 6;
            this.txtSaldoabonar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldoabonar_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(627, 220);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 63);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar cuenta";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(627, 293);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 63);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar cuenta";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Black;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(627, 362);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(113, 63);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar cuenta";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(151, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Saldo a retirar:";
            // 
            // txtRetirar
            // 
            this.txtRetirar.Location = new System.Drawing.Point(298, 362);
            this.txtRetirar.Name = "txtRetirar";
            this.txtRetirar.Size = new System.Drawing.Size(131, 23);
            this.txtRetirar.TabIndex = 11;
            this.txtRetirar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRetirar_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDatos.GridColor = System.Drawing.SystemColors.Window;
            this.dgvDatos.Location = new System.Drawing.Point(0, 437);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 25;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(800, 172);
            this.dgvDatos.TabIndex = 15;
            this.dgvDatos.DoubleClick += new System.EventHandler(this.dgvDatos_DoubleClick_1);
            // 
            // cuentaInfantil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtRetirar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtSaldoabonar);
            this.Controls.Add(this.txtSaldoahorrado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cuentaInfantil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuenta de ahorro infantil";
            this.Load += new System.EventHandler(this.cuentaInfantil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombrebeneficiario;
        private System.Windows.Forms.TextBox txtNombreCuenta;
        private System.Windows.Forms.TextBox txtNombremadre;
        private System.Windows.Forms.TextBox txtNombrepadre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSaldoahorrado;
        private System.Windows.Forms.TextBox txtSaldoabonar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRetirar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}

