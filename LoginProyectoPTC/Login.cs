using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace SBPA
{
    public partial class Login : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Draggable(true);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


  



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
                Font myFont = new Font(label3.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                label3.Font = myFont;
             
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            Font myFont2 = new Font(label3.Font, FontStyle.Bold);
            label3.Font = myFont2;
    
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cs = "server=127.0.0.1;userid=root;database=Banco_Americano";
            MySqlConnection myConn = new MySqlConnection(cs);
            MySqlCommand SelectCommand = new MySqlCommand("select * from Banco_Americano.login where usuario='" + this.txtUsername.Text + "' and contrasena='"+this.txtPassword.Text + "' ;",myConn);

            MySqlDataReader myReader;


            try
            {
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("Inicio de sesión exitoso");
                    this.Hide();
                    dashboard f2 = new dashboard(); 
                    f2.ShowDialog();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Usuario y contraseña duplicados","\nAcceso denegado");
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecto!","\nAcceso denegado");
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
