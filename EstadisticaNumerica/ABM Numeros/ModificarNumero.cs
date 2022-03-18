using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EstadisticaNumerica.ABM_Numeros
{
    public partial class ModificarNumero : Form
    {
        private int Id;
        private string Fecha;
        private int Numero;
        private DataGridView TablaNumeros;

        public ModificarNumero()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(ModificarNumero_Closing);
        }

        public ModificarNumero(int id, string fecha, int numero, DataGridView tablaNumeros)
        {
            InitializeComponent();

            this.Id = id;
            this.Fecha = fecha;
            this.Numero = numero;
            this.TablaNumeros = tablaNumeros;
            this.Closing += new CancelEventHandler(ModificarNumero_Closing);
        }
       


        private void btnGuardar_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("¿Está seguro que desea modificar el número?",
                    "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:

                    Numeros numerosMysql = new Numeros();

                    if (numerosMysql.ValidarNumero(tbNumModi))
                    {
                    numerosMysql.ModificarNumero(this.Id, dtpkFechaNumModi.Value.Date, Convert.ToInt32(tbNumModi.Text));
                    numerosMysql.ActualizarDataGrid(this.TablaNumeros);
                    this.Hide();

                    MessageBox.Show("Número modificado con éxito");
                    }
                    break;
                case DialogResult.No:
                    break;
            }
          
        }

        private void ModificarNumero_Load(object sender, EventArgs e)
        {
           dtpkFechaNumModi.Value = Convert.ToDateTime(this.Fecha);
           tbNumModi.Text = Convert.ToString(this.Numero);


        }

        void ModificarNumero_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
