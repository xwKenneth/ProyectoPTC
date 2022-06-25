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
        private string NombreCuenta;
        private string nombreBeneficiario;
        private int saldoAhorrado;
        private int saldoAbonar;
        private int saldoRetirar;

        Conexion c = new Conexion();

        public cuenataInfantilSql(string NombrePadre,string NombreMadre,string iNombreCuenta, string NombreBeneficiario,
            int SaldoAhorrado,int SaldoAbonar,int SaldoRetirar)
        {
            nombrePadre = NombrePadre;
            nombreMadre = NombreMadre;
            NombreCuenta = iNombreCuenta;
            nombreBeneficiario = NombreBeneficiario;
            saldoAhorrado = SaldoAhorrado;
            saldoAbonar = SaldoAbonar;
            saldoRetirar = SaldoRetirar;
        }

        public DataTable MostrarDatos()
        {
            string comando = "SELECT * FROM CuentaInfantil;";
            MySqlConnection con = c.Conectar();

            DataTable dt = new DataTable();

            MySqlDataAdapter adapter =
                new MySqlDataAdapter(comando, con);
            adapter.Fill(dt);
            return dt;
        }

        public cuenataInfantilSql(string iNombreCuenta) //para delete
        {
            NombreCuenta = iNombreCuenta;
        }

        public cuenataInfantilSql() 
        {

        }


        public bool Agregar()
        {
            string comando = "insert into CuentaInfantil (NombrePadre, NombreMadre, NombreCuenta, NombreBeneficiario, SaldoAhorrado, Saldo_Abonar, Saldo_Retirar)" +
                    "values('" + nombrePadre + "', '" + nombreMadre + "', '" + NombreCuenta + "', '" + nombreBeneficiario + "' , '" + saldoAhorrado + "', '" + saldoAbonar
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
            string comando = "DELETE FROM CuentaInfantil WHERE " +
                "NombreCuenta = '" + NombreCuenta + "';";

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



            string comando = "update CuentaInfantil set NombrePadre= '" +
     nombrePadre + "', NombreMadre ='" + nombreMadre + "', NombreCuenta ='" + NombreCuenta + "', NombreBeneficiario ='" + nombreBeneficiario +
     "', SaldoAhorrado ='" + saldoAhorrado + "', Saldo_Abonar ='" + saldoAbonar + "', Saldo_Retirar ='" + saldoRetirar + "'where NombreCuenta ='" + NombreCuenta + "';";

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
