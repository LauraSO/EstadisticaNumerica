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

       

    public void InsertarNumero(DateTime fecha, int numero)
    {

        
        String fechaShort = fecha.ToString("yyyy-MM-dd");

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

        public void ModificarNumero(int id, DateTime fecha, int numero)
        {


            String fechaShort = fecha.ToString("yyyy-MM-dd");

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

        public void EliminarNumero(int id)
        {

            MySqlConnection conexionBd = this.mysql.Conectar_Bd();
            string query = $"DELETE FROM numeros WHERE id = '{id}'";

            MySqlCommand comandoBd = new MySqlCommand(query, conexionBd);
            comandoBd.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {

                reader = comandoBd.ExecuteReader();
                Console.WriteLine("Dato Eliminado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        public void ActualizarDataGrid(DataGridView grid)
    {
        string query = "SELECT * FROM numeros ORDER BY Fecha DESC";

        MySqlConnection conexionBd = this.mysql.Conectar_Bd();
        MySqlCommand cmd = new MySqlCommand(query, conexionBd);

        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        System.Data.DataTable dt = new System.Data.DataTable();
        da.Fill(dt);


        grid.DataSource = dt;
            


        }
    public void BuscarGrid(DateTime FechaInicial, DateTime FechaFinal, DataGridView grid)
    {
          
            string fecha1 = FechaInicial.ToString("yyyy-MM-dd");
            string fecha2 = FechaFinal.ToString("yyyy-MM-dd");
            

        string query = $"SELECT ID, Fecha, Numero, COUNT(Numero) as Cantidad FROM numeros WHERE Fecha BETWEEN '{fecha1}' and '{fecha2}' " +
                $"GROUP BY Numero HAVING COUNT(Numero)>1";

        MySqlConnection conexionBd = this.mysql.Conectar_Bd();
        MySqlCommand cmd = new MySqlCommand(query, conexionBd);

        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
         DataTable dt = new DataTable();
        da.Fill(dt);


        grid.DataSource = dt;


    }

        public bool ValidarNumero(TextBox tbNum)
        {
            bool no_error = true;
            if (tbNum.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Número");
                no_error = false;
            }
            else
            {

                try
                {
                    int i = Convert.ToInt32(tbNum.Text);

                }
                catch
                {
                    MessageBox.Show("El numero ingresado no es válido");
                    return false;
                }

            }
            return no_error;

        }



    }
}
