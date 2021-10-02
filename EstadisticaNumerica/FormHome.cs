using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadisticaNumerica
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         


            //Recorre las filas..
            foreach (DataGridViewRow fila in this.dgvTablaSecuenciasNum.Rows)
            {
                //Accede a la columna que quieras, o las recorres todas con otro foreach...
                DataGridViewCell columna1 = fila.Cells[0];
               
               
            }

            lblresultado.Text = dgvTablaSecuenciasNum.Rows[0].Cells[0].Value.ToString();


        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormHome_Load(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
