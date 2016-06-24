using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace VentanaDeCorreo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

                respuesta.Text = "CONECTANDO...";
                try
                {
                    Bdcomun.conectando();
                    MessageBox.Show("Se conecto");
                    respuesta.Text = "Conectado";
                try
                {
                   /* Bdcomun.agregar();*/

                }catch(Exception en)
                {
                    MessageBox.Show("No se pudo insertar");

                }
                }
                catch (Exception err)
                {
                    MessageBox.Show("No se pudo conectar");
                    respuesta.Text = "Sin conexion";

                }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string n = txtnom.Text;
            string ap = txtapell.Text;
            string nu = txtnum.Text;
            try
            {
                Bdcomun.agregar(n, ap, nu);
                MessageBox.Show("Guardado");
                n = null;
                ap = null;
                nu = null;
            }
            catch (Exception ert)
            {
                n = null;
                ap = null;
                nu = null;
                MessageBox.Show("No se pudo guardar xb");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            txtnom.Text = "";
            txtapell.Text = "";
            txtnum.Text = "";
            txtdel.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dell = int.Parse(txtdel.Text);
            try
            {   Bdcomun.borrar(dell);
                MessageBox.Show("Contacto borrado");
                dell = 0;
            }
            catch (Exception efr) {
                MessageBox.Show("No se pudo borrar");
                dell = 0;            }
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
        public static void dame(string a)
        {
            MessageBox.Show(a);

        }

        public void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
                respuesta.Text = "Cargando..";
            tabla.Rows.Clear();
            try {
               
                
                string direccion = "server=127.0.0.1;database=social;Uid=root;port=3306;pwd=;";
                MySqlConnection conexion = new MySqlConnection(direccion);

                conexion.Open();

                string sql = "SELECT * FROM contactos";
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {


                    while (reader.Read())
                    {

                        tabla.Rows.Add(Convert.ToString(reader["ID"]),
                       Convert.ToString(reader["nombre"]),
                       Convert.ToString(reader["apellido"]),
                       Convert.ToString(reader["numero"]));
                        


                    }


                }

                conexion.Close();
                respuesta.Text = "Consulta exitosa";
            }catch(Exception er){
                MessageBox.Show("NO se pudo consultar");
            } }
    }
    }

