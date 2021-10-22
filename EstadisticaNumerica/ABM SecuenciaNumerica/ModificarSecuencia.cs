
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EstadisticaNumerica.ABM_SecuenciaNumerica
{
    public partial class ModificarSecuencia : Form
    {
        private int Id;
        private string Secuencia;
        private DataGridView TablaSecuencias;

        public ModificarSecuencia()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(ModificarSecuencia_Closing);
        }

        public ModificarSecuencia(int id, string secuencia, DataGridView tablaSecuencias)
        {
            InitializeComponent();

            this.Id = id;
            this.Secuencia = secuencia;
            this.TablaSecuencias = tablaSecuencias;
            this.Closing += new CancelEventHandler(ModificarSecuencia_Closing);
        }
        public void SetSecuencia(string secuencia)
        {

            this.Secuencia = secuencia;

        }

        public string GetSecuencia()
        {

            return (this.Secuencia);

        }



        private void ModificarSecuencia_Load(object sender, EventArgs e)
        {
            
            tbSecNumModi.Text = Convert.ToString(this.Secuencia);

           
            
        }

        void ModificarSecuencia_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardarSec_Click(object sender, EventArgs e)
        {
            
          Secuencias mysqlForm = new Secuencias();
            mysqlForm.ModificarDato(this.Id, Convert.ToString(tbSecNumModi.Text));
            mysqlForm.ActualizarDataGrid(this.TablaSecuencias);
            this.Hide();

        }
    }
}
