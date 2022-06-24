using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBPA
{
    internal class cuentaAhorroSql
    {
        private string Nombre;
        private string Dui;
        private string Numero_Cuenta;
        private int SaldoAhorrado;
        private int Saldo_Abonar;
        private int Saldo_Retirar;


        Conexion c = new Conexion();

        public DataTable MostrarDatos()
        {
            string comando = "SELECT * FROM CuentaAhorro;";
            MySqlConnection con = c.Conectar();

            DataTable dt = new DataTable();

            MySqlDataAdapter adapter =
                new MySqlDataAdapter(comando, con);
            adapter.Fill(dt);
            return dt;
        }
        public cuentaAhorroSql()
        {

        }
        public cuentaAhorroSql(string iNumero_Cuenta)
        {
            Numero_Cuenta = iNumero_Cuenta;
        }

        public cuentaAhorroSql(string iNombre, string iDui, string iNumero_Cuenta, int iSaldoAhorrado, int iSaldo_Abonar,
            int iSaldo_Retirar
    )
        {
            Nombre = iNombre;
            Dui = iDui;
            Numero_Cuenta = iNumero_Cuenta;
            SaldoAhorrado = iSaldoAhorrado;
            Saldo_Abonar = iSaldo_Abonar;
            Saldo_Retirar = iSaldo_Retirar;

        }
       
        public bool Actualizar()
        {
            string comando = "update CuentaAhorro set Nombre= '" +
                Nombre + "', DUI ='" + Dui + "', Numero_Cuenta ='" + Numero_Cuenta + "', SaldoAhorrado ='" + SaldoAhorrado +
                "', Saldo_Abonar ='" + Saldo_Abonar + "', Saldo_Retirar ='" + Saldo_Retirar + "'where Numero_Cuenta ='" + Numero_Cuenta + "';";

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

        public bool Agregar()
        {
            string comando = "insert into CuentaAhorro (Nombre, DUI, Numero_Cuenta, SaldoAhorrado, Saldo_Abonar, Saldo_Retirar)" +
                    "values('" + Nombre + "', '" + Dui + "', '" + Numero_Cuenta + "', '" + SaldoAhorrado + "' , '" + Saldo_Abonar + "', '" + Saldo_Retirar+ "'); ";



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
            string comando = "DELETE FROM CuentaAhorro WHERE " +
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

    }
}
