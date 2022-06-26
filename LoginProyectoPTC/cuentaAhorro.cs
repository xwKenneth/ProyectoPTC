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
    public partial class cuentaAhorro : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public cuentaAhorro()
        {
            InitializeComponent();
            MostrarDatos();
        }


        public void MostrarDatos()
        {
            cuentaAhorroSql cuenta = new cuentaAhorroSql();

            try
            {
                dgvDato.DataSource = cuenta.MostrarDatos();
            }
            catch
            {
                MessageBox.Show("Error no se pueden mostrar los datos ", "Error de visualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void cuentaAhorro_Load(object sender, EventArgs e)
        {
            this.Draggable(true);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


         

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDui.Text) || string.IsNullOrEmpty(txtNumeroCuenta.Text) ||
                string.IsNullOrEmpty(txtAhorrado.Text) || string.IsNullOrEmpty(txtAbonar.Text) || string.IsNullOrEmpty(txtRetirar.Text))
            {
                MessageBox.Show("Error no se aceptan campos vacíos", "Por favor, ingrese texto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cuentaAhorroSql cuenta = new cuentaAhorroSql(txtNombre.Text, txtDui.Text, txtNumeroCuenta.Text, int.Parse(txtAhorrado.Text.ToString()), int.Parse(txtAbonar.Text.ToString()), int.Parse(txtRetirar.Text.ToString()));
                if (cuenta.Agregar() == true)
                {
                    MessageBox.Show("Cuenta agregada exitosamente",
                        "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    txtDui.Clear();
                    txtNumeroCuenta.Clear();
                    txtDui.Clear();
                    txtAhorrado.Clear();
                    txtAbonar.Clear();
                    txtRetirar.Clear();
                    MostrarDatos();
                }
                else
                {
                    MessageBox.Show("Hubo un error",
                       "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
      

            string NumeroCuenta = dgvDato.CurrentRow.Cells[2].Value.ToString();

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDui.Text) || string.IsNullOrEmpty(txtNumeroCuenta.Text) ||
                string.IsNullOrEmpty(txtAhorrado.Text) || string.IsNullOrEmpty(txtAbonar.Text) || string.IsNullOrEmpty(txtRetirar.Text))
            {
                MessageBox.Show("Error no se aceptan campos vacíos", "Por favor, ingrese texto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cuentaAhorroSql cuenta = new cuentaAhorroSql(txtNombre.Text, txtDui.Text, NumeroCuenta, int.Parse(txtAhorrado.Text.ToString()), int.Parse(txtAbonar.Text.ToString()), int.Parse(txtRetirar.Text.ToString()));
                if (cuenta.Actualizar() == true)
                {
                    MessageBox.Show("Cliente Actualizado", " Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtNombre.Clear();
                    txtDui.Clear();
                    txtNumeroCuenta.Clear();
                    txtDui.Clear();
                    txtAhorrado.Clear();
                    txtAbonar.Clear();
                    txtRetirar.Clear();
                    MostrarDatos();
                }
                else
                {
                    MessageBox.Show("Hubo un error", " Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string Numero_Cuenta = dgvDato.CurrentRow.Cells[2].Value.ToString();

                cuentaAhorroSql cuenta = new cuentaAhorroSql(Numero_Cuenta);

                if (cuenta.Eliminar() == true)
                {
                    MessageBox.Show("Cuenta Eliminada", " Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtNombre.Clear();
                    txtDui.Clear();
                    txtNumeroCuenta.Clear();
                    txtDui.Clear();
                    txtAhorrado.Clear();
                    txtAbonar.Clear();
                    txtRetirar.Clear();
                    MostrarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar" + " una fila para borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDato_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtNombre.Text = dgvDato.CurrentRow.Cells[0].Value.ToString();
                txtDui.Text = dgvDato.CurrentRow.Cells[1].Value.ToString();
                txtNumeroCuenta.Text = dgvDato.CurrentRow.Cells[2].Value.ToString();
                txtAhorrado.Text = dgvDato.CurrentRow.Cells[3].Value.ToString();
                txtAbonar.Text = dgvDato.CurrentRow.Cells[4].Value.ToString();
                txtRetirar.Text = dgvDato.CurrentRow.Cells[5].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe hacer doble clic en un "
                    + " registro válido");
            }    
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

        private void txtDui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '-') && (!txtDui.Text.Contains("-")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos númericos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNumeroCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            
  
        }

        private void txtAhorrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!txtAhorrado.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos númericos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtAbonar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!txtAbonar.Text.Contains(".")))
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
            else if ((e.KeyChar == '.') && (!txtRetirar.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos númericos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
