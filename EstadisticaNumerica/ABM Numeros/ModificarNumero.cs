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
        public void SetFecha(string fecha)
        {
            
            this.Fecha = fecha;
          
        }

        public string GetFecha()
        {
           
           return(this.Fecha );

        }

        public void SetNumero(int numero)
        {
            
            this.Numero = numero;

        }

        public int GetNumero()
        {

            return (this.Numero);

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Numeros mysqlForm = new Numeros();
            mysqlForm.ModificarDato(this.Id, dtpkFechaNumModi.Value.Date, Convert.ToInt32(tbNumModi.Text));
            mysqlForm.ActualizarDataGrid(this.TablaNumeros);
            this.Hide();

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
