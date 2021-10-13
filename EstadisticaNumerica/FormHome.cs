using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EstadisticaNumerica
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();

        }

     


        private void FormHome_Load(object sender, EventArgs e)
        {

            MysqlForm mysqlForm = new MysqlForm();
            MySqlDataReader reader= mysqlForm.GetDatos();
            int n ;
            while (reader.Read())
            {
                n = dgvTablaNumeros.Rows.Add();
                dgvTablaNumeros.Rows[n].Cells[0].Value = reader.GetString(0);
                dgvTablaNumeros.Rows[n].Cells[1].Value = reader.GetString(1);
                dgvTablaNumeros.Rows[n].Cells[2].Value = reader.GetString(2);

            }
            reader.Close();
       

        
        }

        private void DgvTablaNumeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void DgvSecuenciaNum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbNum_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {

            MysqlForm mysqlForm = new MysqlForm();
            mysqlForm.AddDato(dtpkFechaNum.Value, Convert.ToInt32(tbNum.Text));
          
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {

     /*
           
            foreach (DataGridViewRow fila in this.dgvTablaNumeros.Rows)
            {
                
                DataGridViewCell columna1 = fila.Cells[0];


            }

            lblresultado.Text = dgvTablaNumeros.Rows[0].Cells[0].Value.ToString();
     */

        }



        private void dtpkFechaNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpkFechaInicial_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpkFechaFinal_ValueChanged(object sender, EventArgs e)
        {

        }


        private void dgvTablaNumeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dgvSecuenciaNum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
