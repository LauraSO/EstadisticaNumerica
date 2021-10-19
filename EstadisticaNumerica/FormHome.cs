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
            mysqlForm.ActualizarDataGrid(dgvTablaNumeros);
       

        
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
            mysqlForm.AddDato(dtpkFechaNum.Value.Date, Convert.ToInt32(tbNum.Text));
            mysqlForm.ActualizarDataGrid(dgvTablaNumeros);
            

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

            MysqlForm mysqlForm = new MysqlForm();
            mysqlForm.BuscarGrid(dtpkFechaInicial.Value.Date, dtpkFechaFinal.Value.Date, dgvTablaResultado);

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
