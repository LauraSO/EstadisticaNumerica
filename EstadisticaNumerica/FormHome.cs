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

        /*
       private void button1_Click(object sender, EventArgs e)
       {

           /*

           //Recorre las filas..
           foreach (DataGridViewRow fila in this.dgvTablaNumeros.Rows)
           {
               //Accede a la columna que quieras, o las recorres todas con otro foreach...
               DataGridViewCell columna1 = fila.Cells[0];


           }

           lblresultado.Text = dgvTablaNumeros.Rows[0].Cells[0].Value.ToString();

          
    }
     */
        public FormHome(IContainer components, DataGridView dgvTablaNumeros, DateTimePicker dtpkPickerInicial, DateTimePicker dtpkFechaFinal, Label lblFechaInicial, Label lblFechaFinal, Button btnBuscar, Label lblTituloHome, Label lblresultado, DataGridViewTextBoxColumn colID, DataGridViewTextBoxColumn colFecha, DataGridViewTextBoxColumn colNumeros, DataGridViewTextBoxColumn colreset, DataGridView dgvSecuenciaNum, DataGridViewTextBoxColumn iDsn, DataGridViewTextBoxColumn secNum, TextBox tbNum, DateTimePicker dtpkFechaNum, Label lblFechaIngreso, Label lblTituloNuevoNum, Button btnIngresar, Label lblTituloBuscarNum, Button btnReset, Button btnEliminar, Button btnModificar)
        {
            this.components = components;
            this.dgvTablaNumeros = dgvTablaNumeros;
            this.dtpkPickerInicial = dtpkPickerInicial;
            this.dtpkFechaFinal = dtpkFechaFinal;
            this.lblFechaInicial = lblFechaInicial;
            this.lblFechaFinal = lblFechaFinal;
            this.btnBuscar = btnBuscar;
            this.lblTituloHome = lblTituloHome;
            this.lblresultado = lblresultado;
            this.colID = colID;
            this.colFecha = colFecha;
            this.colNumeros = colNumeros;
            this.colreset = colreset;
            this.dgvSecuenciaNum = dgvSecuenciaNum;
            IDsn = iDsn;
            this.secNum = secNum;
            this.tbNum = tbNum;
            this.dtpkFechaNum = dtpkFechaNum;
            this.lblFechaIngreso = lblFechaIngreso;
            this.lblTituloNuevoNum = lblTituloNuevoNum;
            this.btnIngresar = btnIngresar;
            this.lblTituloBuscarNum = lblTituloBuscarNum;
            this.btnReset = btnReset;
            this.btnEliminar = btnEliminar;
            this.btnModificar = btnModificar;
        }
    }
}
