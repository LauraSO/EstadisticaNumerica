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
    public partial class Mysql
    {
   

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


    
}
}
