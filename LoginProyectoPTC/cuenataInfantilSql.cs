using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SBPA
{
    internal class cuenataInfantilSql
    {
        private string nombrePadre;
        private string nombreMadre;
        private string nombreCuenta;
        private string nombreBeneficiario;
        private int saldoAhorrado;
        private int saldoAbonar;
        private int saldoRetirar;

        Conexion c = new Conexion();

        public cuenataInfantilSql(string NombrePadre,string NombreMadre,string NombreCuenta,string NombreBeneficiario,
            int SaldoAhorrado,int SaldoAbonar,int SaldoRetirar)
        {
            nombrePadre = NombrePadre;
            nombreMadre = NombreMadre;
            nombreCuenta = NombreCuenta;
            nombreBeneficiario = NombreBeneficiario;
            saldoAhorrado = SaldoAhorrado;
            saldoAbonar = SaldoAbonar;
            saldoRetirar = SaldoRetirar;
        }

        public cuenataInfantilSql()
        {

        }

        public bool agregar()
        {
            string comando = "insert into CuentaInfantil (NombrePadre, NombreMadre, NombreCuenta, NombreBeneficiario, SaldoAhorrado, Saldo_Abonar, Saldo_Retirar)" +
                    "values('" + nombrePadre + "', '" + nombreMadre + "', '" + nombreCuenta + "', '" + nombreBeneficiario + "' , '" + saldoAhorrado + "', '" + saldoAbonar
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
    }
}
