using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SBPA
{
    internal class cuenataInfantilSql
    {
        private string nombrePadre;
        private string nombreMadre;
        private string numeroCuenta;
        private string nombreBeneficiario;
        private int saldoAhorrado;
        private int saldoAbonar;
        private int saldoRetirar;

        Conexion c = new Conexion();

        public cuenataInfantilSql(string NombrePadre,string NombreMadre,string NumeroCuenta,string NombreBeneficiario,
            int SaldoAhorrado,int SaldoAbonar,int SaldoRetirar)
        {
            nombrePadre = NombrePadre;
            nombreMadre = NombreMadre;
            numeroCuenta = NumeroCuenta;
            nombreBeneficiario = NombreBeneficiario;
            saldoAhorrado = SaldoAhorrado;
            saldoAbonar = SaldoAbonar;
            saldoRetirar = SaldoRetirar;
        }

        public DataTable MostrarDatos()
        {
            string comando = "select * from CuentaInfantil;";
            MySqlConnection con = c.Conectar();
            DataTable dt = new DataTable();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando, con);
            adaptador.Fill(dt);
            return dt;
        }

        public cuenataInfantilSql(string NumeroCuenta) //para delete
        {
            numeroCuenta = NumeroCuenta;
        }

        public cuenataInfantilSql()//para select
        {

        }


        public bool agregar()
        {
            string comando = "insert into CuentaInfantil (NombrePadre, NombreMadre, NombreCuenta, NombreBeneficiario, SaldoAhorrado, Saldo_Abonar, Saldo_Retirar)" +
                    "values('" + nombrePadre + "', '" + nombreMadre + "', '" + numeroCuenta + "', '" + nombreBeneficiario + "' , '" + saldoAhorrado + "', '" + saldoAbonar
                    + "' , '" + saldoRetirar + "'); ";

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
            string comando = "DELETE FROM CuentaInfantil WHERE nombreCuenta =' " + numeroCuenta + " ';";

            MySqlConnection con = c.Conectar();

            try
            {
                MySqlCommand cmd = new MySqlCommand(comando, con);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }

            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }

            finally
            {
                con.Close();
            }
        }

        public bool actualizar()
        {
            string comando = "update CuentaInfantil set NombrePadre=' " + nombrePadre + "',NombreMadre=' " + nombreMadre + "',NombreBeneficiario='" + nombreBeneficiario + "'," +
                "SaldoAhorrado='" + saldoAhorrado + "',Saldo_Abonar='" + saldoAbonar + "',Saldo_Retirar='" + saldoRetirar + "' where NombreCuenta=' " + numeroCuenta + "';";

            MySqlConnection con = c.Conectar();

            try
            {
                MySqlCommand cmd = new MySqlCommand(comando, con);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }

            catch(Exception ex)
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
