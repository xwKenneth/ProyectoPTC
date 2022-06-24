
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
            this.txtNumerocuenta = new System.Windows.Forms.TextBox();
            this.txtNombremadre = new System.Windows.Forms.TextBox();
            this.txtNombrepadre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSaldoahorrado = new System.Windows.Forms.TextBox();
            this.txtSaldoabonar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRetirar = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.txtNombrebeneficiario);
            this.panel1.Controls.Add(this.txtNumerocuenta);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 267);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // txtNombrebeneficiario
            // 
            this.txtNombrebeneficiario.Location = new System.Drawing.Point(451, 215);
            this.txtNombrebeneficiario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombrebeneficiario.Name = "txtNombrebeneficiario";
            this.txtNombrebeneficiario.Size = new System.Drawing.Size(190, 27);
            this.txtNombrebeneficiario.TabIndex = 9;
            this.txtNombrebeneficiario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrebeneficiario_KeyPress);
            // 
            // txtNumerocuenta
            // 
            this.txtNumerocuenta.Location = new System.Drawing.Point(451, 171);
            this.txtNumerocuenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumerocuenta.Name = "txtNumerocuenta";
            this.txtNumerocuenta.Size = new System.Drawing.Size(114, 27);
            this.txtNumerocuenta.TabIndex = 8;
            this.txtNumerocuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerocuenta_KeyPress);
            // 
            // txtNombremadre
            // 
            this.txtNombremadre.Location = new System.Drawing.Point(451, 117);
            this.txtNombremadre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombremadre.Name = "txtNombremadre";
            this.txtNombremadre.Size = new System.Drawing.Size(190, 27);
            this.txtNombremadre.TabIndex = 7;
            this.txtNombremadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombremadre_KeyPress);
            // 
            // txtNombrepadre
            // 
            this.txtNombrepadre.Location = new System.Drawing.Point(451, 72);
            this.txtNombrepadre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombrepadre.Name = "txtNombrepadre";
            this.txtNombrepadre.Size = new System.Drawing.Size(190, 27);
            this.txtNombrepadre.TabIndex = 6;
            this.txtNombrepadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrepadre_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(219, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nombre del beneficiario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(219, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numero de cuenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(219, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre de la madre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(219, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del padre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(401, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos personales";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SBPA.Properties.Resources.png_clipart_computer_icons_user_profile_avatar_profile_heroes_profile_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(14, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 596);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(914, 216);
            this.dataGridView1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(173, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Saldo ahorrado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(173, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Saldo a abonar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(71, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Saldo";
            // 
            // txtSaldoahorrado
            // 
            this.txtSaldoahorrado.Location = new System.Drawing.Point(341, 337);
            this.txtSaldoahorrado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSaldoahorrado.Name = "txtSaldoahorrado";
            this.txtSaldoahorrado.Size = new System.Drawing.Size(149, 27);
            this.txtSaldoahorrado.TabIndex = 5;
            this.txtSaldoahorrado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldoahorrado_KeyPress);
            // 
            // txtSaldoabonar
            // 
            this.txtSaldoabonar.Location = new System.Drawing.Point(341, 417);
            this.txtSaldoabonar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSaldoabonar.Name = "txtSaldoabonar";
            this.txtSaldoabonar.Size = new System.Drawing.Size(149, 27);
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
            this.btnAgregar.Location = new System.Drawing.Point(717, 293);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 84);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar cuenta";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(717, 391);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 84);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar cuenta";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Black;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(717, 483);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(129, 84);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar cuenta";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(173, 495);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Saldo a retirar:";
            // 
            // txtRetirar
            // 
            this.txtRetirar.Location = new System.Drawing.Point(341, 483);
            this.txtRetirar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRetirar.Name = "txtRetirar";
            this.txtRetirar.Size = new System.Drawing.Size(149, 27);
            this.txtRetirar.TabIndex = 11;
            this.txtRetirar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRetirar_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cuentaInfantil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(914, 812);
            this.Controls.Add(this.txtRetirar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtSaldoabonar);
            this.Controls.Add(this.txtSaldoahorrado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "cuentaInfantil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuenta de ahorro infantil";
            this.Load += new System.EventHandler(this.cuentaInfantil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombrebeneficiario;
        private System.Windows.Forms.TextBox txtNumerocuenta;
        private System.Windows.Forms.TextBox txtNombremadre;
        private System.Windows.Forms.TextBox txtNombrepadre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSaldoahorrado;
        private System.Windows.Forms.TextBox txtSaldoabonar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRetirar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

