
namespace EstadisticaNumerica
{
    partial class FormHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.dgvTablaNumeros = new System.Windows.Forms.DataGridView();
            this.dtpkFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpkFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTituloHome = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.dgvSecuenciaNum = new System.Windows.Forms.DataGridView();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.dtpkFechaNum = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblTituloNuevoNum = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblTituloBuscarNum = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvTablaResultado = new System.Windows.Forms.DataGridView();
            this.btnModificarSec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaNumeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecuenciaNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablaNumeros
            // 
            this.dgvTablaNumeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablaNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaNumeros.Location = new System.Drawing.Point(329, 143);
            this.dgvTablaNumeros.Name = "dgvTablaNumeros";
            this.dgvTablaNumeros.ReadOnly = true;
            this.dgvTablaNumeros.RowTemplate.Height = 25;
            this.dgvTablaNumeros.Size = new System.Drawing.Size(398, 188);
            this.dgvTablaNumeros.TabIndex = 0;
            // 
            // dtpkFechaInicial
            // 
            this.dtpkFechaInicial.CalendarFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpkFechaInicial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpkFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkFechaInicial.Location = new System.Drawing.Point(420, 384);
            this.dtpkFechaInicial.Name = "dtpkFechaInicial";
            this.dtpkFechaInicial.Size = new System.Drawing.Size(103, 25);
            this.dtpkFechaInicial.TabIndex = 1;
            this.dtpkFechaInicial.Value = new System.DateTime(2021, 10, 27, 0, 0, 0, 0);
            // 
            // dtpkFechaFinal
            // 
            this.dtpkFechaFinal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpkFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkFechaFinal.Location = new System.Drawing.Point(614, 386);
            this.dtpkFechaFinal.Name = "dtpkFechaFinal";
            this.dtpkFechaFinal.Size = new System.Drawing.Size(113, 25);
            this.dtpkFechaFinal.TabIndex = 2;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaInicial.Location = new System.Drawing.Point(329, 386);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(85, 19);
            this.lblFechaInicial.TabIndex = 3;
            this.lblFechaInicial.Text = "Fecha Inicial:";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaFinal.Location = new System.Drawing.Point(529, 388);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(79, 19);
            this.lblFechaFinal.TabIndex = 4;
            this.lblFechaFinal.Text = "Fecha Final:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(746, 382);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 29);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "  Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTituloHome
            // 
            this.lblTituloHome.AutoSize = true;
            this.lblTituloHome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloHome.Location = new System.Drawing.Point(24, 9);
            this.lblTituloHome.Name = "lblTituloHome";
            this.lblTituloHome.Size = new System.Drawing.Size(262, 37);
            this.lblTituloHome.TabIndex = 6;
            this.lblTituloHome.Text = "Estadistica Numerica";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblresultado.Location = new System.Drawing.Point(329, 334);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 28);
            this.lblresultado.TabIndex = 7;
            // 
            // dgvSecuenciaNum
            // 
            this.dgvSecuenciaNum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSecuenciaNum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecuenciaNum.Location = new System.Drawing.Point(24, 98);
            this.dgvSecuenciaNum.Name = "dgvSecuenciaNum";
            this.dgvSecuenciaNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSecuenciaNum.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSecuenciaNum.RowTemplate.Height = 25;
            this.dgvSecuenciaNum.Size = new System.Drawing.Size(272, 499);
            this.dgvSecuenciaNum.TabIndex = 10;
            // 
            // tbNum
            // 
            this.tbNum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNum.Location = new System.Drawing.Point(504, 101);
            this.tbNum.Name = "tbNum";
            this.tbNum.PlaceholderText = "Numero ";
            this.tbNum.Size = new System.Drawing.Size(86, 25);
            this.tbNum.TabIndex = 9;
            this.tbNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNum_KeyPress);
            // 
            // dtpkFechaNum
            // 
            this.dtpkFechaNum.CalendarFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpkFechaNum.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpkFechaNum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpkFechaNum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkFechaNum.Location = new System.Drawing.Point(379, 101);
            this.dtpkFechaNum.Name = "dtpkFechaNum";
            this.dtpkFechaNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpkFechaNum.Size = new System.Drawing.Size(119, 25);
            this.dtpkFechaNum.TabIndex = 11;
            this.dtpkFechaNum.TabStop = false;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaIngreso.Location = new System.Drawing.Point(329, 101);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(47, 19);
            this.lblFechaIngreso.TabIndex = 12;
            this.lblFechaIngreso.Text = "Fecha:";
            // 
            // lblTituloNuevoNum
            // 
            this.lblTituloNuevoNum.AutoSize = true;
            this.lblTituloNuevoNum.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloNuevoNum.Location = new System.Drawing.Point(329, 60);
            this.lblTituloNuevoNum.Name = "lblTituloNuevoNum";
            this.lblTituloNuevoNum.Size = new System.Drawing.Size(207, 25);
            this.lblTituloNuevoNum.TabIndex = 13;
            this.lblTituloNuevoNum.Text = "Ingresar Nuevo Numero:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.Image = global::EstadisticaNumerica.Properties.Resources.add;
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(596, 98);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(100, 29);
            this.btnIngresar.TabIndex = 14;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblTituloBuscarNum
            // 
            this.lblTituloBuscarNum.AutoSize = true;
            this.lblTituloBuscarNum.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloBuscarNum.Location = new System.Drawing.Point(329, 350);
            this.lblTituloBuscarNum.Name = "lblTituloBuscarNum";
            this.lblTituloBuscarNum.Size = new System.Drawing.Size(234, 25);
            this.lblTituloBuscarNum.TabIndex = 15;
            this.lblTituloBuscarNum.Text = "Buscar Numeros Repetidos: ";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(746, 255);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 33);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Image = global::EstadisticaNumerica.Properties.Resources.delete;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(746, 211);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 38);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Image = global::EstadisticaNumerica.Properties.Resources.modify;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(746, 169);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 36);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvTablaResultado
            // 
            this.dgvTablaResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablaResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaResultado.Location = new System.Drawing.Point(329, 426);
            this.dgvTablaResultado.Name = "dgvTablaResultado";
            this.dgvTablaResultado.ReadOnly = true;
            this.dgvTablaResultado.RowTemplate.Height = 25;
            this.dgvTablaResultado.Size = new System.Drawing.Size(413, 171);
            this.dgvTablaResultado.TabIndex = 19;
            // 
            // btnModificarSec
            // 
            this.btnModificarSec.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificarSec.Image = global::EstadisticaNumerica.Properties.Resources.modify;
            this.btnModificarSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarSec.Location = new System.Drawing.Point(117, 608);
            this.btnModificarSec.Name = "btnModificarSec";
            this.btnModificarSec.Size = new System.Drawing.Size(103, 34);
            this.btnModificarSec.TabIndex = 20;
            this.btnModificarSec.Text = "Modificar";
            this.btnModificarSec.UseVisualStyleBackColor = true;
            this.btnModificarSec.Click += new System.EventHandler(this.btnModificarSec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Secuencias Numericas:";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(875, 654);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificarSec);
            this.Controls.Add(this.dgvTablaResultado);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTituloBuscarNum);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblTituloNuevoNum);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.dtpkFechaNum);
            this.Controls.Add(this.dgvSecuenciaNum);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblTituloHome);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.dtpkFechaFinal);
            this.Controls.Add(this.dtpkFechaInicial);
            this.Controls.Add(this.dgvTablaNumeros);
            this.Name = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.DoubleClick += new System.EventHandler(this.FormHome_ClearDclick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaNumeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecuenciaNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablaNumeros;
        private System.Windows.Forms.DateTimePicker dtpkFechaInicial;
        private System.Windows.Forms.DateTimePicker dtpkFechaFinal;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTituloHome;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.DataGridView dgvSecuenciaNum;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.DateTimePicker dtpkFechaNum;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblTituloNuevoNum;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblTituloBuscarNum;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
       private System.Windows.Forms.DataGridView dgvTablaResultado;
        private System.Windows.Forms.Button btnModificarSec;
        private System.Windows.Forms.Label label1;
    }
}

