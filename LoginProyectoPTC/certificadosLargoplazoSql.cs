using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SBPA
{
    internal class certificadosLargoplazoSql
    {
        private string Usuario;
        private string DUI;
        private string Numero_Cuenta;
        private int DineroGuardar;
        private int Interes;
        private int Total;
        private string Fecha_Vencimiento;

        Conexion c = new Conexion();

        public certificadosLargoplazoSql(string iUsuario, string iDUI, string iNumero_Cuenta, int iDineroGuardar,
            int iInteres, int iTotal, string iFecha_Vencimiento)
        {
            Usuario = iUsuario;
            DUI = iDUI;
            Numero_Cuenta = iNumero_Cuenta;
            DineroGuardar = iDineroGuardar;
            Interes = iInteres;
            Total = iTotal;
            Fecha_Vencimiento = iFecha_Vencimiento;
        }

        public DataTable MostrarDatos()
        {
            string comando = "SELECT * FROM certificados_plazo;";
            MySqlConnection con = c.Conectar();

            DataTable dt = new DataTable();

            MySqlDataAdapter adapter =
                new MySqlDataAdapter(comando, con);
            adapter.Fill(dt);
            return dt;
        }

        public certificadosLargoplazoSql(string iNumero_Cuenta) //para delete
        {
            Numero_Cuenta = iNumero_Cuenta;
        }

        public certificadosLargoplazoSql()
        {

        }


        public bool Agregar()
        {
            string comando = "insert into certificados_plazo (Usuario, DUI, Numero_Cuenta, DineroGuardar, Interes, Total, Fecha_Vencimiento)" +
                    "values('" + Usuario + "' , '" + DUI + "', '" + Numero_Cuenta + "' , '" + DineroGuardar + "' , '" + Interes + "' , '" + Total + "' , '" + Fecha_Vencimiento + "'); ";

            MySqlConnection con = c.Conectar();

            try
            {
                MySqlCommand cmd = new MySqlCommand(comando, con);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool Eliminar()
        {
            string comando = "DELETE FROM certificados_plazo WHERE " +
                "Numero_Cuenta = '" + Numero_Cuenta + "';";

            MySqlConnection con = c.Conectar();

            try
            {
                MySqlCommand cmd = new MySqlCommand(comando, con);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool Actualizar()
        {



            string comando = "update certificados_plazo set Usuario= '" +
     Usuario + "', DUI ='" + DUI + "', Numero_Cuenta ='" + Numero_Cuenta + "', DineroGuardar ='" + DineroGuardar +
     "', Interes ='" + Interes + "', Total ='" + Total + "', Fecha_Vencimiento ='" + Fecha_Vencimiento + "'where Numero_Cuenta ='" + Numero_Cuenta + "';";

            MySqlConnection con = c.Conectar();

            try
            {
                MySqlCommand cmd = new MySqlCommand(comando, con);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }

            finally
            {
                con.Close();
            }
        }
    }
}
