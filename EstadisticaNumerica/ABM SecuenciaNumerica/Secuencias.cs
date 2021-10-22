using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace EstadisticaNumerica.ABM_SecuenciaNumerica
{
    public  class Secuencias
    {

        private Mysql mysql;

   

    public Secuencias()
        {
            this.mysql = new Mysql();
        }

      

  

        public void ModificarDato(int id,  string secuencia)

        {
            MySqlConnection conexionBd = this.mysql.Conectar_Bd();
            string query = $"UPDATE secuencias SET SecuenciaNumerica='{secuencia}' WHERE id={id} ";
         
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
        string query = "SELECT * FROM secuencias";

        MySqlConnection conexionBd = this.mysql.Conectar_Bd();
        MySqlCommand cmd = new MySqlCommand(query, conexionBd);

        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        System.Data.DataTable dt = new System.Data.DataTable();
        da.Fill(dt);


        grid.DataSource = dt;


    }
 



}
}
