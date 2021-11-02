using System;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;
using EstadisticaNumerica.ABM_Numeros;
using EstadisticaNumerica.ABM_SecuenciaNumerica;
namespace EstadisticaNumerica
{
    public partial class FormHome : Form
    {


        private Numeros numeros;
        private Secuencias secuencias;

        public FormHome()
        {
            InitializeComponent();
            this.numeros= new Numeros();
            this.secuencias = new Secuencias();
              }
   

    private void FormHome_ClearDclick(object sender, EventArgs e)
        {

            tbNum.Clear();
            dgvSecuenciaNum.ClearSelection();
            dgvTablaNumeros.ClearSelection();
            dgvTablaResultado.DataSource = false;
            dtpkFechaNum.Value = DateTime.Now;
            dtpkFechaInicial.Value = DateTime.Now;
           dtpkFechaFinal.Value = DateTime.Now;
           
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

            this.LoadHome();

        
        }


        private void tbNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.ingresarNum();
            }
        }

       


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.ingresarNum();
         

        }

      

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var filaSeleccionada = dgvTablaNumeros.CurrentRow;

            if (filaSeleccionada != null)
            {
                int id = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                string fecha = Convert.ToString(filaSeleccionada.Cells[1].Value);
                int numero = Convert.ToInt32(filaSeleccionada.Cells[2].Value);
                ModificarNumero formModificarNUmero = new ModificarNumero(id, fecha, numero, dgvTablaNumeros);
                formModificarNUmero.ShowDialog(this);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            DateTime fechaInicial = dtpkFechaInicial.Value.Date;
            DateTime fechaFinal = dtpkFechaFinal.Value.Date;
           
            int resultado = DateTime.Compare(fechaInicial,fechaFinal);

            if (resultado > 0)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final");
            } else{
               
                
             dgvTablaResultado.DataSource = true;
            this.numeros.BuscarGrid(fechaInicial, fechaFinal, dgvTablaResultado);

        }
        }



        private void btnModificarSec_Click(object sender, EventArgs e)
        {
            var filaSeleccionada = dgvSecuenciaNum.CurrentRow;

            if (filaSeleccionada != null)
            {
                int id = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                string secuenciaNum = Convert.ToString(filaSeleccionada.Cells[1].Value);
             
                ModificarSecuencia formModificarSecuencia = new ModificarSecuencia(id, secuenciaNum, dgvSecuenciaNum);
             
               
                formModificarSecuencia.ShowDialog(this);
            }
        }

    
        private void ingresarNum()
        {
            
            this.numeros.AddDato(dtpkFechaNum.Value.Date, Convert.ToInt32(tbNum.Text));
            this.numeros.ActualizarDataGrid(dgvTablaNumeros);
            tbNum.Clear();
           //dtpkFechaNum.Value = DateTime.Now;


        }

        private void LoadHome()
        {

          this.numeros.ActualizarDataGrid(dgvTablaNumeros);
          this.secuencias.ActualizarDataGrid(dgvSecuenciaNum);


        }

      
    }
}
