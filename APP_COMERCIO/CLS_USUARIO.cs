using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace APP_COMERCIO
{
    public class CLS_USUARIO
    {
        private string str_mensaje;
        SqlCommand con; 
        SqlDataReader Lectura;


        private string str_nombre;
        private string str_contacto;
        private string str_correo;
        private string str_direccion;

        public void fnt_agregar(string id, string nombre, string contacto, string correo, string direccion)
        {
            try
            {
                CLS_CONEXION objConecta = new CLS_CONEXION();
                SqlCommand con = new SqlCommand("sp_agregarusuario", objConecta.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@codigo", id);
                con.Parameters.AddWithValue("@nombre", nombre);
                con.Parameters.AddWithValue("@contacto", contacto);
                con.Parameters.AddWithValue("@correo", correo);
                con.Parameters.AddWithValue("@direccion", direccion);
                objConecta.connection.Open();
                con.ExecuteNonQuery();
                objConecta.connection.Close();
                str_mensaje = "Registro exitoso";
            }
            catch (Exception) { str_mensaje = "Faltan campos / este registro ya existe"; }
        }


        public void fnt_consultar (string codigo)
        {
            try
            {
                CLS_CONEXION objConecta = new CLS_CONEXION();
                con = new SqlCommand("sp_consultarusuario", objConecta.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@codigo", codigo);
                objConecta.connection.Open();
                Lectura = con.ExecuteReader();
                if (Lectura.Read() == true)
                {
                    str_nombre = Convert.ToString(Lectura[0]);
                    str_contacto = Convert.ToString(Lectura[1]);
                    str_correo = Convert.ToString(Lectura[2]);
                    str_direccion = Convert.ToString(Lectura[3]);
                    str_mensaje = "";
                }
            }
            catch (Exception)
            {
                str_mensaje = "No se encontraron registros";
            }
        }


        public string getMensaje() { return str_mensaje; }
        public string getNombre() { return str_nombre; }
        public string getContacto() { return str_contacto; }
        public string getDireccion() { return str_direccion; }
        public string getCorreo() { return str_correo; }

    }
}