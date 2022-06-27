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
    public partial class PrestamosPersonales : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public PrestamosPersonales()
        {
            InitializeComponent();
            MostrarDatos();
        }

        public void MostrarDatos()
        {
            PrestamosPersonalesSql cuenta = new PrestamosPersonalesSql();

            try
            {
                dgvDato.DataSource = cuenta.MostrarDatos();
            }
            catch
            {
                MessageBox.Show("Error no se pueden mostrar los datos ", "Error de visualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void PrestamosHipotecarios_Load(object sender, EventArgs e)
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

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMontodeprestamo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMontodeprestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!txtNumeroOperacion.Text.Contains(".")))
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
            else if ((e.KeyChar == '.') && (!txtNumeroOperacion.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos númericos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!txtNumeroOperacion.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos númericos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtFondodePago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!txtNumeroOperacion.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos númericos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtTipodeMoneda_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMontosporCuotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!txtNumeroOperacion.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos númericos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtTotaldeInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!txtNumeroOperacion.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos númericos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtMontoTotalaPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!txtNumeroOperacion.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos númericos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNombreCompleto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TipodeDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar))
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

  

        private void txtDirección_KeyPress(object sender, KeyPressEventArgs e)
        {
     
        }

        private void txtNúmerodeTeléfono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '-') && (!txtNumeroOperacion.Text.Contains("-")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos númericos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCorreoElectrónico_KeyPress(object sender, KeyPressEventArgs e)
        {
      
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
            else if ((e.KeyChar == '_') && (!txtNumeroOperacion.Text.Contains("_")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos númericos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtDui.Text) || string.IsNullOrEmpty(txtContraseña.Text)
         || string.IsNullOrEmpty(txtNombreCompleto.Text) || string.IsNullOrEmpty(txtTipodeDocumento.Text) || string.IsNullOrEmpty(txtNumerodeDocumento.Text)
         || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtNumerodeTelefono.Text) || string.IsNullOrEmpty(txtCorreoElectronico.Text)
         || string.IsNullOrEmpty(txtMontodeprestamo.Text) || string.IsNullOrEmpty(txtInteres.Text) || string.IsNullOrEmpty(txtNumeroCuotas.Text)
         || string.IsNullOrEmpty(txtFondodePago.Text) || string.IsNullOrEmpty(txtTipodeMoneda.Text) || string.IsNullOrEmpty(txtMontosporCuotas.Text )
         || string.IsNullOrEmpty(txtTotaldeInteres.Text) || string.IsNullOrEmpty(txtMontoTotalaPagar.Text)
         )
            {
                MessageBox.Show("Error no se aceptan campos vaciós", "Por favor, ingrese texto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PrestamosHipotecariosSql cuenta = new PrestamosHipotecariosSql(txtUsuario.Text, txtDui.Text, txtContraseña.Text, int.Parse(txtNumeroOperacion.Text.ToString()),
                Convert.ToDateTime(dtpFechaRegistro.Text).ToString("yyyy-MM-dd"), txtNombreCompleto.Text, txtTipodeDocumento.Text, txtNumerodeDocumento.Text, txtDireccion.Text, txtNumerodeTelefono.Text, txtCorreoElectronico.Text, int.Parse(txtMontodeprestamo.Text.ToString()),
                int.Parse(txtInteres.Text.ToString()), int.Parse(txtNumeroCuotas.Text.ToString()), int.Parse(txtFondodePago.Text.ToString()), txtTipodeMoneda.Text, Convert.ToDateTime(dtpFechaDeInicio.Text).ToString("yyyy-MM-dd"), int.Parse(txtMontosporCuotas.Text.ToString()),
                int.Parse(txtTotaldeInteres.Text.ToString()), int.Parse(txtMontoTotalaPagar.Text.ToString()));

                if (cuenta.Agregar() == true)
                {
                    MessageBox.Show("cliente agregado exitosamente",
                        "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Clear();
                    txtDui.Clear();
                    txtContraseña.Clear();
                    txtNumeroOperacion.Clear();
                    txtNombreCompleto.Clear();
                    txtTipodeDocumento.Clear();
                    txtNumerodeDocumento.Clear();
                    txtDireccion.Clear();
                    txtNumerodeTelefono.Clear();
                    txtCorreoElectronico.Clear();
                    txtMontodeprestamo.Clear();
                    txtInteres.Clear();
                    txtNumeroCuotas.Clear();
                    txtFondodePago.Clear();
                    txtTipodeMoneda.Clear();
                    txtMontosporCuotas.Clear();
                    txtTotaldeInteres.Clear();
                    txtMontoTotalaPagar.Clear();
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
            string Usuario = dgvDato.CurrentRow.Cells[0].Value.ToString();



            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtDui.Text) || string.IsNullOrEmpty(txtContraseña.Text)
         || string.IsNullOrEmpty(txtNombreCompleto.Text) || string.IsNullOrEmpty(txtTipodeDocumento.Text) || string.IsNullOrEmpty(txtNumerodeDocumento.Text)
         || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtNumerodeTelefono.Text) || string.IsNullOrEmpty(txtCorreoElectronico.Text)
         || string.IsNullOrEmpty(txtMontodeprestamo.Text) || string.IsNullOrEmpty(txtInteres.Text) || string.IsNullOrEmpty(txtNumeroCuotas.Text)
         || string.IsNullOrEmpty(txtFondodePago.Text) || string.IsNullOrEmpty(txtTipodeMoneda.Text) || string.IsNullOrEmpty(txtMontosporCuotas.Text)
         || string.IsNullOrEmpty(txtTotaldeInteres.Text) || string.IsNullOrEmpty(txtMontoTotalaPagar.Text)
         )


            {
                MessageBox.Show("Error no se aceptan campos vaciós", "Por favor, ingrese texto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PrestamosHipotecariosSql cuenta = new PrestamosHipotecariosSql(Usuario, txtDui.Text, txtContraseña.Text, int.Parse(txtNumeroOperacion.Text.ToString()),
                Convert.ToDateTime(dtpFechaRegistro.Text).ToString("yyyy-MM-dd"), txtNombreCompleto.Text, txtTipodeDocumento.Text, txtNumerodeDocumento.Text, txtDireccion.Text, txtNumerodeTelefono.Text, txtCorreoElectronico.Text, int.Parse(txtMontodeprestamo.Text.ToString()),
                int.Parse(txtInteres.Text.ToString()), int.Parse(txtNumeroCuotas.Text.ToString()), int.Parse(txtFondodePago.Text.ToString()), txtTipodeMoneda.Text, Convert.ToDateTime(dtpFechaDeInicio.Text).ToString("yyyy-MM-dd"), int.Parse(txtMontosporCuotas.Text.ToString()),
                int.Parse(txtTotaldeInteres.Text.ToString()), int.Parse(txtMontoTotalaPagar.Text.ToString()));
                if (cuenta.Agregar() == true)
                {
                    MessageBox.Show("cliente agregado exitosamente",
                        "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Clear();
                    txtDui.Clear();
                    txtContraseña.Clear();
                    txtNumeroOperacion.Clear();
                    txtNombreCompleto.Clear();
                    txtTipodeDocumento.Clear();
                    txtNumerodeDocumento.Clear();
                    txtDireccion.Clear();
                    txtNumerodeTelefono.Clear();
                    txtCorreoElectronico.Clear();
                    txtMontodeprestamo.Clear();
                    txtInteres.Clear();
                    txtNumeroCuotas.Clear();
                    txtFondodePago.Clear();
                    txtTipodeMoneda.Clear();
                    txtMontosporCuotas.Clear();
                    txtTotaldeInteres.Clear();
                    txtMontoTotalaPagar.Clear();
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
                string Usuario = dgvDato.CurrentRow.Cells[0].Value.ToString();

                PrestamosPersonalesSql cuenta = new PrestamosPersonalesSql(Usuario);

                if (cuenta.Eliminar() == true)
                {
                    MessageBox.Show("Cuenta Eliminada", " Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Clear();
                    txtDui.Clear();
                    txtContraseña.Clear();
                    txtNumeroOperacion.Clear();
                    txtNombreCompleto.Clear();
                    txtTipodeDocumento.Clear();
                    txtNumerodeDocumento.Clear();
                    txtDireccion.Clear();
                    txtNumerodeTelefono.Clear();
                    txtCorreoElectronico.Clear();
                    txtMontodeprestamo.Clear();
                    txtInteres.Clear();
                    txtNumeroCuotas.Clear();
                    txtFondodePago.Clear();
                    txtTipodeMoneda.Clear();
                    txtMontosporCuotas.Clear();
                    txtTotaldeInteres.Clear();
                    txtMontoTotalaPagar.Clear();
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


                txtUsuario.Text = dgvDato.CurrentRow.Cells[0].Value.ToString();
                txtDui.Text = dgvDato.CurrentRow.Cells[1].Value.ToString();
                txtContraseña.Text = dgvDato.CurrentRow.Cells[2].Value.ToString();
                txtNumeroOperacion.Text = dgvDato.CurrentRow.Cells[3].Value.ToString();
                dtpFechaRegistro.Text = dgvDato.CurrentRow.Cells[4].Value.ToString();
                txtNombreCompleto.Text = dgvDato.CurrentRow.Cells[5].Value.ToString();
                txtTipodeDocumento.Text = dgvDato.CurrentRow.Cells[6].Value.ToString();
                txtNumerodeDocumento.Text = dgvDato.CurrentRow.Cells[7].Value.ToString();
                txtDireccion.Text = dgvDato.CurrentRow.Cells[8].Value.ToString();
                txtNumerodeTelefono.Text = dgvDato.CurrentRow.Cells[9].Value.ToString();
                txtCorreoElectronico.Text = dgvDato.CurrentRow.Cells[10].Value.ToString();
                txtMontodeprestamo.Text = dgvDato.CurrentRow.Cells[11].Value.ToString();
                txtInteres.Text = dgvDato.CurrentRow.Cells[12].Value.ToString();
                txtNumeroCuotas.Text = dgvDato.CurrentRow.Cells[13].Value.ToString();
                txtFondodePago.Text = dgvDato.CurrentRow.Cells[14].Value.ToString();
                txtTipodeMoneda.Text = dgvDato.CurrentRow.Cells[15].Value.ToString();
                dtpFechaDeInicio.Text = dgvDato.CurrentRow.Cells[16].Value.ToString();
                txtMontosporCuotas.Text = dgvDato.CurrentRow.Cells[17].Value.ToString();
                txtTotaldeInteres.Text = dgvDato.CurrentRow.Cells[18].Value.ToString();
                txtMontoTotalaPagar.Text = dgvDato.CurrentRow.Cells[19].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe hacer doble clic en un "
                    + " registro válido");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            dashboard main = new dashboard();
            main.Show();
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
