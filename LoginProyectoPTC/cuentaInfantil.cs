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

        private void button1_Click(object sender, EventArgs e)
        {
            string nombrePadre = txtNombrepadre.Text;
            string nombreMadre = txtNombremadre.Text;
            string nombreCuenta = txtNumerocuenta.Text;
            string NombreBeneficiario = txtNombrebeneficiario.Text;
            int saldoAhorrado =  int.Parse(txtSaldoahorrado.Text.ToString());
            int saldoRetirar = int.Parse(txtRetirar.Text.ToString());
            int saldoAbonar = int.Parse(txtSaldoabonar.Text.ToString());

            cuenataInfantilSql i = new cuenataInfantilSql(nombrePadre, nombreMadre, nombreCuenta, NombreBeneficiario, saldoAhorrado, saldoRetirar, saldoAbonar);
            if (i.agregar() == true)
            {
                MessageBox.Show("Datos ingresados correctamente",
                       "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error",
                       "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
