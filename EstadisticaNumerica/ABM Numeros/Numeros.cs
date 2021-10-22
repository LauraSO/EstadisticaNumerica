using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EstadisticaNumerica.ABM_Numeros
{
    public class Numeros
    {

        private Mysql mysql;

   

    public Numeros()
        {
            this.mysql = new Mysql();
        }

        public MySqlDataReader GetDatos()
    {
            
        
        MySqlConnection conexionBd = this.mysql.Conectar_Bd();
        string query = "SELECT * FROM numeros";
        MySqlCommand comandoBd = new MySqlCommand(query, conexionBd);
        comandoBd.CommandTimeout = 60;
        MySqlDataReader reader;


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


        String fechaShort = fecha.ToShortDateString();

        MySqlConnection conexionBd = this.mysql.Conectar_Bd();
        string query = $"INSERT INTO numeros(`id`, `fecha`, `numero`) VALUES (NULL, '{fechaShort}', {numero})";
       
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

       


    }

        public void ModificarDato(int id, DateTime fecha, int numero)
        {


            String fechaShort = fecha.ToShortDateString();

            MySqlConnection conexionBd = this.mysql.Conectar_Bd();
            string query = $"UPDATE numeros SET fecha='{fechaShort}', numero={numero} WHERE id={id} ";
         
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

          



        }


        public void ActualizarDataGrid(DataGridView grid)
    {
        string query = "SELECT * FROM numeros";

        MySqlConnection conexionBd = this.mysql.Conectar_Bd();
        MySqlCommand cmd = new MySqlCommand(query, conexionBd);

        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        System.Data.DataTable dt = new System.Data.DataTable();
        da.Fill(dt);


        grid.DataSource = dt;


    }
    public void BuscarGrid(DateTime FechaInicial, DateTime FechaFinal, DataGridView grid)
    {

        string query = $"SELECT ID, Fecha, Numero, COUNT(Numero) as Repetidos FROM numeros WHERE Fecha BETWEEN '{FechaInicial.ToShortDateString()}' and '{FechaFinal.ToShortDateString()}' " +
                $"GROUP BY Numero HAVING COUNT(Numero)>1";

        MySqlConnection conexionBd = this.mysql.Conectar_Bd();
        MySqlCommand cmd = new MySqlCommand(query, conexionBd);

        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        System.Data.DataTable dt = new System.Data.DataTable();
        da.Fill(dt);


        grid.DataSource = dt;


    }



}
}
