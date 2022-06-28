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
            string cs = "server=127.0.0.1;userid=root;database=Datos_BancoAmericano";
            var con = new MySqlConnection(cs);    
            


            try
            {
                con.Open();
                string stm = "select usuario, contrasena, tipo_usuario from login WHERE usuario = @txtUsuario AND contrasena = @txtContra";

                var cmd = new MySqlCommand(stm, con);

                cmd.Parameters.AddWithValue("txtUsuario", txtUsername.Text);
                cmd.Parameters.AddWithValue("@txtContra", txtPassword.Text);

                MySqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    if (rd[2].ToString() == "0")
                    {
                        MessageBox.Show("Inicio de sesión exitoso \nBienvenido Admin!");
                        this.Hide();
                        dashboard f2 = new dashboard();
                        f2.ShowDialog();
                    }
                    else if (rd[2].ToString() == "1")
                    {
                        MessageBox.Show("Inicio de sesión exitoso \n Bienvenido Empleado");
                        this.Hide();
                        dashboard f2 = new dashboard();
                        f2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrecto!", "\nAcceso denegado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
