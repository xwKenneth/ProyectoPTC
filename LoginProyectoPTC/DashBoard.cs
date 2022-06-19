using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBPA
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void btnAhorro_Click(object sender, EventArgs e)
        {
            cuentaAhorro f3 = new cuentaAhorro();  
            f3.Show();  
            this.Close();  
        }

        private void btnHipotecarios_Click(object sender, EventArgs e)
        {
            PrestamosHipotecarios f4 = new PrestamosHipotecarios();
            f4.Show();
            this.Close();
        }

        private void btnCertificados_Click(object sender, EventArgs e)
        {
            certificadosLargoplazo f5 = new certificadosLargoplazo();
            f5.Show();
            this.Close();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            PrestamosPersonales f6 = new PrestamosPersonales();
            f6.Show();
            this.Close();
        }
    }
}
