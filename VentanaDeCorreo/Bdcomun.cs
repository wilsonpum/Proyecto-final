using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace VentanaDeCorreo
{
    class Bdcomun
    {
        public static MySqlConnection conectando()
        {
            /* MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=social; Uid=root; pwd=;");

             conectar.Open();

             return conectar;*/

            string direccion = "server=127.0.0.1;database=social;Uid=root;port=3306;pwd=;";
            MySqlConnection conexion = new MySqlConnection(direccion);

            conexion.Open();

            string sql = "INSERT INTO contactos (nombre, apellido) VALUES ('Disneyland','Mickey Mouse')";
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            cmd.ExecuteNonQuery();

            return conexion;

        }


        public static void agregar(string nom, string ape, string num)
        {


            string direccion = "server=127.0.0.1;database=social;Uid=root;port=3306;pwd=;";
            MySqlConnection conexion = new MySqlConnection(direccion);

            conexion.Open();

            string sql = "INSERT INTO contactos (nombre, apellido, numero) VALUES ('" + nom + "','" + ape + "','" + num + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public static void borrar(int del)
        {
            string direccion = "server=127.0.0.1;database=social;Uid=root;port=3306;pwd=;";
            MySqlConnection conexion = new MySqlConnection(direccion);

            conexion.Open();

            string sql = "DELETE FROM contactos where ID = '" + del + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void consulta()
        {


        }
    }
}
