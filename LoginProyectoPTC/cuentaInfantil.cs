﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBPA
{
    public partial class cuentaInfantil : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public cuentaInfantil()
        {
            InitializeComponent();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void cuentaInfantil_Load(object sender, EventArgs e)
        {
            this.Draggable(true);
        }

        public void MostrarDato()
        {
            cuenataInfantilSql cu = new cuenataInfantilSql();

            try
            {
                dgvDatos.DataSource = cu.MostrarDatos();
            }

            catch
            {
                MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombrePadre = txtNombrepadre.Text;
            string nombreMadre = txtNombremadre.Text;
            string numeroCuenta = txtNumerocuenta.Text;
            string NombreBeneficiario = txtNombrebeneficiario.Text;
            int saldoAhorrado =  int.Parse(txtSaldoahorrado.Text.ToString());
            int saldoRetirar = int.Parse(txtRetirar.Text.ToString());
            int saldoAbonar = int.Parse(txtSaldoabonar.Text.ToString());

            cuenataInfantilSql i = new cuenataInfantilSql(nombrePadre, nombreMadre, numeroCuenta, NombreBeneficiario, saldoAhorrado, saldoRetirar, saldoAbonar);
            if (i.agregar() == true)
            {
                MessageBox.Show("Datos ingresados correctamente",
                       "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarDato();
                txtNombrepadre.Clear();
                txtNombremadre.Clear();
                txtNumerocuenta.Clear();
                txtNombrebeneficiario.Clear();
                txtSaldoahorrado.Clear();
                txtSaldoabonar.Clear();
                txtRetirar.Clear();
                MostrarDato();
            }
            else
            {
                MessageBox.Show("Error",
                       "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtNombrepadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNombremadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNumerocuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!txtNumerocuenta.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos númericos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNombrebeneficiario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtSaldoahorrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!txtNumerocuenta.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos númericos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtSaldoabonar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!txtNumerocuenta.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos númericos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtRetirar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!txtNumerocuenta.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos númericos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string numeroCuenta = dgvDatos.CurrentRow.Cells[2].Value.ToString();

                cuenataInfantilSql cu = new cuenataInfantilSql(numeroCuenta);

                if (cu.Eliminar() == true)
                {
                    MessageBox.Show("Cuenta eliminada", "Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarDato();
                    txtNombrepadre.Clear();
                    txtNombremadre.Clear();
                    txtNumerocuenta.Clear();
                    txtNombrebeneficiario.Clear();
                    txtSaldoahorrado.Clear();
                    txtSaldoabonar.Clear();
                    txtRetirar.Clear();
                    MostrarDato();
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Hubo un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDatos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                MostrarDato();
                txtNombrepadre.Text = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                txtNombremadre.Text = dgvDatos.CurrentRow.Cells[1].Value.ToString();
                txtNumerocuenta.Text = dgvDatos.CurrentRow.Cells[2].Value.ToString();
                txtNombrebeneficiario.Text = dgvDatos.CurrentRow.Cells[3].Value.ToString();
                txtSaldoahorrado.Text = dgvDatos.CurrentRow.Cells[4].Value.ToString();
                txtSaldoabonar.Text = dgvDatos.CurrentRow.Cells[5].Value.ToString();
                txtRetirar.Text = dgvDatos.CurrentRow.Cells[6].Value.ToString();
                MostrarDato();
            }

            catch
            {
                MessageBox.Show("Debe hacer doble click en un registro válido");
            }
        }
    }
}
