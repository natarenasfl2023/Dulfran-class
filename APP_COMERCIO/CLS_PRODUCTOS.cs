using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APP_COMERCIO
{
    public class CLS_PRODUCTOS
    {
        private string str_mensaje;
        SqlCommand con;
        SqlDataReader Lectura;


        private string str_codigo;
        private string str_nombre;
        private string str_existencia;
        private float flt_valor_compra;
        private string str_especificaciones;
        private float flt_ganancia;
        private string str_usuario;

        public void fnt_agregar(string codigo, string nombre, string existencia, float valor_compra , string ganancia, string especificaciones, string categoria, string estado)
         {
             try
             {
                 CLS_CONEXION objConecta = new CLS_CONEXION();
                 SqlCommand con = new SqlCommand("sp_agregarproducto", objConecta.connection);
                 con.CommandType = CommandType.StoredProcedure;
                 con.Parameters.AddWithValue("@codigo", codigo);
                 con.Parameters.AddWithValue("@nombre", nombre);
                 con.Parameters.AddWithValue("@existencia", existencia);
                 con.Parameters.AddWithValue("@valor_compra", valor_compra);
                 con.Parameters.AddWithValue("@ganancia", ganancia);
                con.Parameters.AddWithValue("@especificaciones", especificaciones);
                con.Parameters.AddWithValue("@categoria", categoria);
                con.Parameters.AddWithValue("@estado", estado);
                objConecta.connection.Open();
                 con.ExecuteNonQuery();
                 objConecta.connection.Close();
                 str_mensaje = "Registro exitoso";
             }
             catch (Exception) { str_mensaje = "Faltan campos / este registro ya existe"; }
         }

     }
    
}