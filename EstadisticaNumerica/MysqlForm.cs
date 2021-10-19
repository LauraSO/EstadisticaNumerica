using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EstadisticaNumerica
{
    public partial class MysqlForm : Form
    {
        public MysqlForm()
        {
            InitializeComponent();
        }

        private void MysqlForm_Load(object sender, EventArgs e)
        {

        }

        public MySqlConnection Conectar_Bd()
        {
         
           string conexion = "datasource=127.0.0.1;port=3306;username=root;password=;SslMode=none;database=estadisticanumerica;";
           MySqlConnection conexionBd = new MySqlConnection(conexion);

          
                // Abre la base de datos
                conexionBd.Open();

          
            return conexionBd;

        }

        public void Cerrar_Bd(MySqlConnection conexion)
        {

            conexion.Close();

        }

/*
        public void Ver_Dato()
        {
            MySqlConnection conexionBd = this.Conectar_Bd();
            string query = "SELECT * FROM numeros";
            MySqlCommand comandoBd = new MySqlCommand(query, conexionBd);
            comandoBd.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
             
                // Ejecuta la consultas
                reader = comandoBd.ExecuteReader();

              

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                      
                        // Hacer algo con cada fila obtenida
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2) };
                        MessageBox.Show(row[0]);
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");
                }

            
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }

            
        }
*/

        public  MySqlDataReader GetDatos()
        {
            MySqlConnection conexionBd = this.Conectar_Bd();
            string query = "SELECT * FROM numeros";
            MySqlCommand comandoBd = new MySqlCommand(query, conexionBd);
            comandoBd.CommandTimeout = 60;
            MySqlDataReader reader ;
        
          
                // Ejecuta la consultas
                reader = comandoBd.ExecuteReader();
                 

                if (reader.HasRows)
                {
                    Console.WriteLine("Datos Encontrados");
                   
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");
                }


            return reader;


        }

        public void AddDato(DateTime fecha, int numero)
        {


            String fechaShort = fecha.ToShortDateString() ;
            
            MySqlConnection conexionBd = this.Conectar_Bd();
            string query=$"INSERT INTO numeros(`id`, `fecha`, `numero`) VALUES (NULL, '{fechaShort}', {numero})";
            //string query = "INSERT INTO numeros(`id`, `fecha`, `numero`) VALUES $(NULL, "+ fecha2[0].'/'. fecha2[1] + ","+ numero + ")";

            MySqlCommand comandoBd = new MySqlCommand(query, conexionBd);
            comandoBd.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {

                reader = comandoBd.ExecuteReader();
                Console.WriteLine("Dato insertado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            query = "SELECT * FROM numeros";
           


        }


        public void ActualizarDataGrid(DataGridView grid)
        {
            string query = "SELECT * FROM numeros";

            MySqlConnection conexionBd = this.Conectar_Bd();
            MySqlCommand cmd = new MySqlCommand(query, conexionBd);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);


            grid.DataSource = dt;


        }
        public void BuscarGrid(DateTime FechaInicial, DateTime FechaFinal, DataGridView grid)
        {
            
            string query = $"SELECT ID, Fecha, Numero FROM numeros WHERE Fecha BETWEEN '{FechaInicial.ToShortDateString()}' and '{FechaFinal.ToShortDateString()}'";

            MySqlConnection conexionBd = this.Conectar_Bd();
            MySqlCommand cmd = new MySqlCommand(query, conexionBd);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);


            grid.DataSource = dt;


        }

 

    }
}
