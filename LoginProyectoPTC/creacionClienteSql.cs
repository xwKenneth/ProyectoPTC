using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBPA
{
    internal class creacionClienteSql
    {
        private string Nombre;
        private string FechaNacimiento;
        private string Dui;
        private string Direccion;
        private string LugarNacimiento;
        private string LugarTrabajo;
        private string NombrePadre;
        private string NombreMadre;
        private int NumeroCelular;
        private string NumeroCasa;
        private int TelefonoTrabajo;
        private string Beneficiario;
        private string SalarioMensual;
        Conexion c = new Conexion();


        public creacionClienteSql(string iNombre, string iFechaNacimiento, string iDui, string iDireccion,
         string  iLugarnacimiento, string iLugarTrabajo, string iNombrePadre, string iNombreMadre, int iNumeroCelular, string iNumeroCasa,
         int  iTelefonoTrabajo, string iBeneficiario, string iSalarioMensual
            )
        {
            iNombre = Nombre;
            iFechaNacimiento = FechaNacimiento;
            iDui = Dui;
            iDireccion = Direccion;
            iLugarnacimiento = LugarNacimiento;
            iLugarTrabajo = LugarTrabajo;
            iNombrePadre = NombrePadre;
            iNombreMadre = NombreMadre;
            iNumeroCelular = NumeroCelular;
            iNumeroCasa = NumeroCasa;
            iTelefonoTrabajo = TelefonoTrabajo;
            iBeneficiario = Beneficiario;
            iSalarioMensual = SalarioMensual;
            
        }

        public creacionClienteSql()
        {

        }




        public bool Agregar()
        {
            string comando = "insert into productos (Nombre_cliente, FechaNacimiento, DUI, Direccion_cliente, LugarNacimiento, Nombre_padre, Nombre_madre, " +
                "Numero_celular, Numero_Casa, LugarTrabajo, TelefonoTrabajo, Beneficiario, SalarioMensual  )" +
                    "values('" + Nombre + "', '" + FechaNacimiento + "', '" + Dui + "', '"+ Direccion+ "' , '"+ LugarNacimiento + ", '"+NombrePadre+"' , '"+NombreMadre + 
                    "', '"+ NumeroCelular+ "', '"+NumeroCasa+"', '"+LugarTrabajo+ "', '"+TelefonoTrabajo+ "', '"+Beneficiario+ ", '"+SalarioMensual+"); ";



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
