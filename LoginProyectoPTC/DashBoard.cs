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
    public partial class dashboard : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public dashboard()
        {
            InitializeComponent();
        }

        private void btnAhorro_Click(object sender, EventArgs e)
        {
            cuentaAhorro f3 = new cuentaAhorro();  
            f3.Show();  
  
        }

        private void btnHipotecarios_Click(object sender, EventArgs e)
        {
            PrestamosHipotecarios f4 = new PrestamosHipotecarios();
            f4.Show();
        
        }

        private void btnCertificados_Click(object sender, EventArgs e)
        {
            certificadosLargoplazo f5 = new certificadosLargoplazo();
            f5.Show();
        
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            PrestamosPersonales f6 = new PrestamosPersonales();
            f6.Show();
           
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            this.Draggable(true);
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnCeuntaInfantil_Click(object sender, EventArgs e)
        {
            cuentaInfantil f7 = new cuentaInfantil();
            f7.Show();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            creacionCliente f8 = new creacionCliente();
            f8.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
