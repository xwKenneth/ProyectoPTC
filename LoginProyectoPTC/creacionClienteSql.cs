using MySql.Data.MySqlClient;
using System;

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
        private string NumeroCelular;
        private string NumeroCasa;
        private string TelefonoTrabajo;
        private string Beneficiario;
        private int SalarioMensual;
        Conexion c = new Conexion();


        public creacionClienteSql(string iNombre, string iFechaNacimiento, string iDui, string iDireccion,
         string iLugarnacimiento, string iLugarTrabajo, string iNombrePadre, string iNombreMadre, string iNumeroCelular, string iNumeroCasa,
         string iTelefonoTrabajo, string iBeneficiario, int iSalarioMensual
            )
        {
            Nombre = iNombre;
            FechaNacimiento = iFechaNacimiento;
            Dui = iDui;
            Direccion = iDireccion;
            LugarNacimiento = iLugarnacimiento;
            LugarTrabajo = iLugarTrabajo;
            NombrePadre = iNombrePadre;
            NombreMadre = iNombreMadre;
            NumeroCelular = iNumeroCelular;
            NumeroCasa =  iNumeroCasa;
            TelefonoTrabajo =  iTelefonoTrabajo;
            Beneficiario = iBeneficiario;
            SalarioMensual = iSalarioMensual;

        }

        public creacionClienteSql()
        {

        }




        public bool Agregar()
        {
            string comando = "insert into crear_cliente (Nombre_cliente, FechaNacimiento, DUI, Direccion_cliente, LugarNacimiento, Nombre_padre, Nombre_madre, Numero_celular, Numero_Casa, LugarTrabajo, TelefonoTrabajo, Beneficiario, SalarioMensual)" +
                    "values('" + Nombre + "', '" + FechaNacimiento + "', '" + Dui + "', '" + Direccion + "' , '" + LugarNacimiento + "', '" + NombrePadre + "' , '" + NombreMadre +
                    "', '" + NumeroCelular + "', '" + NumeroCasa + "', '" + LugarTrabajo + "', '" + TelefonoTrabajo + "', '" + Beneficiario + "', '" + SalarioMensual + "'); ";



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
