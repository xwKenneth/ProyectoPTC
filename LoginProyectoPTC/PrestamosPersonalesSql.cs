using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBPA
{
    internal class PrestamosPersonalesSql
    {
        private string Usuario;
        private string DUI;
        private string Contrasena;
        private int NumeroOperacion;
        private string FechaRegistro;
        private string Nombre_cliente;
        private string TipoDocumento;
        private string NumeroDocumento;
        private string Direccion_cliente;
        private string Numero_telefono;
        private string Correo_Electronico;
        private int MontoPrestamo;
        private int Interes;
        private int Numero_Cuotas;
        private int Fondo_Pago;
        private string Tipo_Moneda;
        private string Fecha_Inicio;
        private int Montos_Cuota;
        private int Total_Interes;
        private int Monto_Total;

        Conexion c = new Conexion();
        public PrestamosPersonalesSql(string iUsuario, string iDUI, string iContrasena, int iNumeroOperacion, string iFechaRegistro, string iNombre_cliente,
         string iTipoDocumento, string iNumeroDocumento, string iDireccion_cliente, string iNumero_telefono, string iCorreo_Electronico, int iMontoPrestamo,
         int iInteres, int iNumero_Cuotas, int iFondo_Pago, string iTipo_Moneda, string iFecha_Inicio, int iMontos_Cuota, int iTotal_Interes, int iMonto_Total
        )
        {
            Usuario = iUsuario;
            DUI = iDUI;
            Contrasena = iContrasena;
            NumeroOperacion = iNumeroOperacion;
            FechaRegistro = iFechaRegistro;
            Nombre_cliente = iNombre_cliente;
            TipoDocumento = iTipoDocumento;
            NumeroDocumento = iNumeroDocumento;
            Direccion_cliente = iDireccion_cliente;
            Numero_telefono = iNumero_telefono;
            Correo_Electronico = iCorreo_Electronico;
            MontoPrestamo = iMontoPrestamo;
            Interes = iInteres;
            Numero_Cuotas = iNumero_Cuotas;
            Fondo_Pago = iFondo_Pago;
            Tipo_Moneda = iTipo_Moneda;
            Fecha_Inicio = iFecha_Inicio;
            Montos_Cuota = iMontos_Cuota;
            Total_Interes = iTotal_Interes;
            Monto_Total = iMonto_Total;
        }

        public DataTable MostrarDatos()
        {
            string comando = "SELECT * FROM prestamos_personales;";
            MySqlConnection con = c.Conectar();

            DataTable dt = new DataTable();

            MySqlDataAdapter adapter =
                new MySqlDataAdapter(comando, con);
            adapter.Fill(dt);
            return dt;
        }

        public PrestamosPersonalesSql(string iUsuario) //para delete
        {
            Usuario = iUsuario;
        }

        public PrestamosPersonalesSql()
        {

        }

        public bool Agregar()
        {
            string comando = "insert into prestamos_personales (Usuario, DUI, Contrasena, NumeroOperacion, FechaRegistro, Nombre_cliente, TipoDocumento, " +
                "NumeroDocumento, Direccion_cliente, Numero_telefono, Correo_Electronico, MontoPrestamo, Interes, Numero_Cuotas, Fondo_Pago, Tipo_Moneda, " +
                "Fecha_Inicio, Montos_Cuota, Total_Interes, Monto_Total)" +
               "values('" + Usuario + "', '" + DUI + "', '" + Contrasena + "', '" + NumeroOperacion + "' , '" + FechaRegistro + "', '" + Nombre_cliente
               + "' , '" + TipoDocumento + "' , '" + NumeroDocumento + "' , '" + Direccion_cliente + "' , '" + Numero_telefono + "' , '" + Correo_Electronico + "' , '" + MontoPrestamo + "' , '" + Interes + "' , '" +
               Numero_Cuotas + "' , '" + Fondo_Pago + "' , '" + Tipo_Moneda + "' , '" + Fecha_Inicio + "' , '" + Montos_Cuota + "' , '" + Total_Interes + "' , '" + Monto_Total + "'  ); ";

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
            string comando = "DELETE FROM prestamos_personales WHERE " +
                "Usuario = '" + Usuario + "';";

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

            string comando = "update prestamos_personales set Usuario= '" +
     Usuario + "', DUI ='" + DUI + "', Contrasena ='" + Contrasena + "', NumeroOperacion ='" + NumeroOperacion +
     "', FechaRegistro ='" + FechaRegistro + "', Nombre_cliente ='" + Nombre_cliente + "', TipoDocumento ='" + TipoDocumento + "', NumeroDocumento ='" + NumeroDocumento +
    "', Direccion_cliente ='" + Direccion_cliente + "', Numero_telefono ='" + Numero_telefono + "', Correo_Electronico ='" + Correo_Electronico +
    "', MontoPrestamo ='" + MontoPrestamo + "', Interes ='" + Interes + "', Numero_Cuotas ='" + Numero_Cuotas + "', Fondo_Pago ='" + Fondo_Pago +
    "', Tipo_Moneda ='" + Tipo_Moneda + "', Fecha_Inicio ='" + Fecha_Inicio + "', Montos_Cuota ='" + Montos_Cuota + "', Total_Interes ='" + Total_Interes +
     "', Monto_Total ='" + Monto_Total +
     "'where Usuario ='" + Usuario + "';";


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
