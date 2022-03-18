
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
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

        
        private void btnGuardarSec_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("¿Está seguro que desea modificar la secuencia?",
                    "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:

                    Secuencias secuenciaMysql = new Secuencias();

                    if (secuenciaMysql.ValidarSecuencia(tbSecNumModi))
                    {

                    secuenciaMysql.ModificarDato(this.Id, Convert.ToString(tbSecNumModi.Text));
                    secuenciaMysql.ActualizarDataGrid(this.TablaSecuencias);
                    this.Hide();
                    MessageBox.Show("Secuencia modificada con éxito");
                    }
                    break;
                case DialogResult.No:
                    break;
            }

           

        }

        private void btnCancelarSec_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



       

    }
}
