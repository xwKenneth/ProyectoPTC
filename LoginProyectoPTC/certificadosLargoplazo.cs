using System;
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

    public partial class certificadosLargoplazo : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public certificadosLargoplazo()
        {
            InitializeComponent();
            MostrarDatos();
        }

        public void MostrarDatos()
        {
            certificadosLargoplazoSql cuenta = new certificadosLargoplazoSql();

            try
            {
                dgvDatos.DataSource = cuenta.MostrarDatos();
            }
            catch
            {
                MessageBox.Show("Error no se pueden mostrar los datos ", "Error de visualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Draggable(true);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txtDinero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!txtDinero.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos númericos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!txtInteres.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos númericos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!txtTotal.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos númericos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
       
        }

        private void txtDui_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDui.Text) || string.IsNullOrEmpty(txtCuenta.Text) ||
                string.IsNullOrEmpty(txtDinero.Text) || string.IsNullOrEmpty(txtInteres.Text) || string.IsNullOrEmpty(txtTotal.Text))
            {
                MessageBox.Show("Error no se aceptan campos vacíos", "Porfavor ingrese texto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                certificadosLargoplazoSql cuenta = new certificadosLargoplazoSql(txtNombre.Text, txtDui.Text, txtCuenta.Text, int.Parse(txtDinero.Text.ToString()), int.Parse(txtInteres.Text.ToString()), int.Parse(txtTotal.Text.ToString()), Convert.ToDateTime(dtpFechaVencimiento.Text).ToString("yyyy-MM-dd"));
                if (cuenta.Agregar() == true)
                {
                    MessageBox.Show("Cuenta agregada exitosamente",
                        "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    txtDui.Clear();
                    txtCuenta.Clear();
                    txtDui.Clear();
                    txtDinero.Clear();
                    txtInteres.Clear();
                    txtTotal.Clear();
                    MostrarDatos();
                }
                else
                {
                    MessageBox.Show("Hubo un error",
                       "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string NumeroCuenta = dgvDatos.CurrentRow.Cells[2].Value.ToString();

                certificadosLargoplazoSql cuenta = new certificadosLargoplazoSql(NumeroCuenta);

                if (cuenta.Eliminar() == true)
                {
                    MessageBox.Show("Cuenta Eliminada", " Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtNombre.Clear();
                    txtDui.Clear();
                    txtCuenta.Clear();
                    txtDui.Clear();
                    txtDinero.Clear();
                    txtInteres.Clear();
                    txtTotal.Clear();
                    MostrarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar" + " una fila para borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string Dui = txtDui.Text;
            string NumeroCuenta = dgvDatos.CurrentRow.Cells[2].Value.ToString();
            int DineroGuardar = int.Parse(txtDinero.Text.ToString());
            int Interes = int.Parse(txtInteres.Text.ToString());
            int Total = int.Parse(txtTotal.Text.ToString());
            string FechaVencimiento = Convert.ToDateTime(dtpFechaVencimiento.Text).ToString("yyyy-MM-dd");

            certificadosLargoplazoSql cuenta = new certificadosLargoplazoSql(Nombre, Dui, NumeroCuenta, DineroGuardar, Interes, Total, FechaVencimiento);
            if (cuenta.Actualizar() == true)
            {
                MessageBox.Show("Cliente Actualizado", " Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtNombre.Clear();
                txtDui.Clear();
                txtCuenta.Clear();
                txtDui.Clear();
                txtDinero.Clear();
                txtInteres.Clear();
                txtTotal.Clear();
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Hubo un error", " Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDatos_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                txtNombre.Text = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                txtDui.Text = dgvDatos.CurrentRow.Cells[1].Value.ToString();
                txtCuenta.Text = dgvDatos.CurrentRow.Cells[2].Value.ToString();
                txtDinero.Text = dgvDatos.CurrentRow.Cells[3].Value.ToString();
                txtInteres.Text = dgvDatos.CurrentRow.Cells[4].Value.ToString();
                txtTotal.Text = dgvDatos.CurrentRow.Cells[5].Value.ToString();
                dtpFechaVencimiento.Text = dgvDatos.CurrentRow.Cells[6].Value.ToString();


   

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe hacer doble clic en un "
                    + " registro válido");
            }
        }
    }
}
