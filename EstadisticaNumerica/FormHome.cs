using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using EstadisticaNumerica.ABM_Numeros;

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

            Numeros mysqlForm = new Numeros();
            mysqlForm.ActualizarDataGrid(dgvTablaNumeros);

            Secuencias tablaSecuencias = new Secuencias();
            tablaSecuencias.ActualizarDataGrid(dgvSecuenciaNum);

        
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

            Numeros mysqlForm = new Numeros();
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
            var filaSeleccionada = dgvTablaNumeros.CurrentRow;

            if (filaSeleccionada != null)
            {
                int id = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                string fecha = Convert.ToString(filaSeleccionada.Cells[1].Value);
                int numero = Convert.ToInt32(filaSeleccionada.Cells[2].Value);
                ModificarSecuencia formModificarNUmero = new ModificarNumero(id, fecha, numero, dgvTablaNumeros);
                formModificarNUmero.Show();
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            Numeros mysqlForm = new Numeros();
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

        private void btnModificarSec_Click(object sender, EventArgs e)
        {
            var filaSeleccionada = dgvSecuenciaNum.CurrentRow;

            if (filaSeleccionada != null)
            {
                int id = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                string secuenciaNum = Convert.ToString(filaSeleccionada.Cells[1].Value);
             
                ModificarSecuencia formModificarNUmero = new ModificarNumero(id, fecha, numero, dgvTablaNumeros);
                formModificarNUmero.Show();
            }
        }
    }
}
