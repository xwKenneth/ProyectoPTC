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
    public partial class creacionCliente : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public creacionCliente()
        {
            InitializeComponent();
        }



        private void creacionCliente_Load(object sender, EventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string FechaNacimiento = Convert.ToDateTime(dtpFechaNacimiento.Text).ToString("yyyy-MM-dd");
            string Dui = txtDui.Text;
            string Direccion = txtDireccion.Text;
            string LugarNacimiento = txtLugarNacimiento.Text;
            string LugarTrabajo = txtLugarTrabajo.Text;
            string NombrePadre = txtNombrePadre.Text;
            string NombreMadre = txtNombreMadre.Text;
            string NumeroCelular = txtnumeroCelular.Text;
            string NumeroCasa = txtNumeroCasa.Text;
            string TelefonoTrabajo = txtTelefenoTrabajo.Text;
            string Beneficiario = txtBeneficiario.Text;
            int SalarioMensual = int.Parse(txtSalarioMensual.Text.ToString());
            creacionClienteSql pro = new creacionClienteSql(Nombre, FechaNacimiento, Dui, Direccion, LugarNacimiento, LugarTrabajo, NombrePadre,
                NombreMadre, NumeroCelular, NumeroCasa, TelefonoTrabajo, Beneficiario, SalarioMensual);

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDui.Text) || string.IsNullOrEmpty(txtDireccion.Text)
                || string.IsNullOrEmpty(txtLugarNacimiento.Text) || string.IsNullOrEmpty(txtLugarTrabajo.Text) || string.IsNullOrEmpty(txtNombrePadre.Text)
                || string.IsNullOrEmpty(txtNombreMadre.Text) || string.IsNullOrEmpty(txtnumeroCelular.Text) || string.IsNullOrEmpty(txtNumeroCasa.Text)
                || string.IsNullOrEmpty(txtTelefenoTrabajo.Text) || string.IsNullOrEmpty(txtBeneficiario.Text) || string.IsNullOrEmpty(txtSalarioMensual.Text)
                )
            {
                MessageBox.Show("Error no se aceptan campos vacios", "Porfavor ingrese texto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (pro.Agregar() == true)
                {
                    MessageBox.Show("Producto agregado exitosamente",
                        "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hubo un error",
                       "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
