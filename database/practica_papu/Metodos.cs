using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace practica_papu
{
    public static class Metodos
    {
        public static void Cargar(string sql)
        {
            SqlConnection conection = new SqlConnection(); // creamos un objeto de tipo SqlConnection para vincular la base de datos
                                                           // .ConeectionString, establecemos el server name de la base de datos a traves de un string
            conection.ConnectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            conection.Open(); // abrimos el servidor
            SqlCommand cmb = new SqlCommand(); // creamos un objeto de tipo SqlCommand, que nos permite dar consultas a la base de datos
            cmb.Connection = conection; // .Connection, vinculamos el objeto command con  conection
            cmb.CommandType = CommandType.Text; // especifica el tipo de dato que va a ser la consulta
                                                // .CommandText, establecemos la consulta
            cmb.CommandText = sql;
            cmb.ExecuteNonQuery(); // devuelve el numero de filas afectadas 
            conection.Close();
        }

        public static DataTable Leer(string sql)
        {
            
            SqlConnection conection = new SqlConnection();
            conection.ConnectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            conection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conection;
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.ExecuteNonQuery();
            DataTable table = new DataTable();
            table.Load(command.ExecuteReader()); //carga los datos de la consulta realizada
            return table;
        }
    }
}
