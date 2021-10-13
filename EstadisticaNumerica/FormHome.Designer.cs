
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
            this.dgvTablaNumeros = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colreset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpkFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpkFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTituloHome = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.dgvSecuenciaNum = new System.Windows.Forms.DataGridView();
            this.IDsn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.dtpkFechaNum = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblTituloNuevoNum = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblTituloBuscarNum = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaNumeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecuenciaNum)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablaNumeros
            // 
            this.dgvTablaNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colFecha,
            this.colNumeros,
            this.colreset});
            this.dgvTablaNumeros.Location = new System.Drawing.Point(323, 164);
            this.dgvTablaNumeros.Name = "dgvTablaNumeros";
            this.dgvTablaNumeros.RowTemplate.Height = 25;
            this.dgvTablaNumeros.Size = new System.Drawing.Size(495, 188);
            this.dgvTablaNumeros.TabIndex = 0;
            this.dgvTablaNumeros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablaNumeros_CellContentClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            // 
            // colNumeros
            // 
            this.colNumeros.HeaderText = "Numeros";
            this.colNumeros.Name = "colNumeros";
            // 
            // colreset
            // 
            this.colreset.HeaderText = "Cantidad Repeticiones";
            this.colreset.Name = "colreset";
            this.colreset.Width = 150;
            // 
            // dtpkFechaInicial
            // 
            this.dtpkFechaInicial.Location = new System.Drawing.Point(414, 407);
            this.dtpkFechaInicial.Name = "dtpkFechaInicial";
            this.dtpkFechaInicial.Size = new System.Drawing.Size(164, 23);
            this.dtpkFechaInicial.TabIndex = 1;
            this.dtpkFechaInicial.Value = new System.DateTime(2021, 10, 7, 13, 45, 49, 0);
            this.dtpkFechaInicial.ValueChanged += new System.EventHandler(this.dtpkFechaInicial_ValueChanged);
            // 
            // dtpkFechaFinal
            // 
            this.dtpkFechaFinal.Location = new System.Drawing.Point(669, 407);
            this.dtpkFechaFinal.Name = "dtpkFechaFinal";
            this.dtpkFechaFinal.Size = new System.Drawing.Size(161, 23);
            this.dtpkFechaFinal.TabIndex = 2;
            this.dtpkFechaFinal.ValueChanged += new System.EventHandler(this.dtpkFechaFinal_ValueChanged);
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaInicial.Location = new System.Drawing.Point(323, 407);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(85, 19);
            this.lblFechaInicial.TabIndex = 3;
            this.lblFechaInicial.Text = "Fecha Inicial:";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaFinal.Location = new System.Drawing.Point(584, 407);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(79, 19);
            this.lblFechaFinal.TabIndex = 4;
            this.lblFechaFinal.Text = "Fecha Final:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(839, 406);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 26);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTituloHome
            // 
            this.lblTituloHome.AutoSize = true;
            this.lblTituloHome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloHome.Location = new System.Drawing.Point(35, 9);
            this.lblTituloHome.Name = "lblTituloHome";
            this.lblTituloHome.Size = new System.Drawing.Size(262, 37);
            this.lblTituloHome.TabIndex = 6;
            this.lblTituloHome.Text = "Estadistica Numerica";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblresultado.Location = new System.Drawing.Point(337, 355);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 28);
            this.lblresultado.TabIndex = 7;
            // 
            // dgvSecuenciaNum
            // 
            this.dgvSecuenciaNum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecuenciaNum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDsn,
            this.secNum});
            this.dgvSecuenciaNum.Location = new System.Drawing.Point(35, 76);
            this.dgvSecuenciaNum.Name = "dgvSecuenciaNum";
            this.dgvSecuenciaNum.RowTemplate.Height = 25;
            this.dgvSecuenciaNum.Size = new System.Drawing.Size(237, 437);
            this.dgvSecuenciaNum.TabIndex = 10;
            this.dgvSecuenciaNum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSecuenciaNum_CellContentClick);
            // 
            // IDsn
            // 
            this.IDsn.HeaderText = "ID";
            this.IDsn.Name = "IDsn";
            this.IDsn.Width = 50;
            // 
            // secNum
            // 
            this.secNum.HeaderText = "Secuencia Numerica";
            this.secNum.Name = "secNum";
            this.secNum.Width = 140;
            // 
            // tbNum
            // 
            this.tbNum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNum.Location = new System.Drawing.Point(544, 123);
            this.tbNum.Name = "tbNum";
            this.tbNum.PlaceholderText = "Numero ";
            this.tbNum.Size = new System.Drawing.Size(86, 25);
            this.tbNum.TabIndex = 9;
            this.tbNum.TextChanged += new System.EventHandler(this.tbNum_TextChanged);
            // 
            // dtpkFechaNum
            // 
            this.dtpkFechaNum.Location = new System.Drawing.Point(373, 123);
            this.dtpkFechaNum.Name = "dtpkFechaNum";
            this.dtpkFechaNum.Size = new System.Drawing.Size(165, 23);
            this.dtpkFechaNum.TabIndex = 11;
            this.dtpkFechaNum.TabStop = false;
            this.dtpkFechaNum.ValueChanged += new System.EventHandler(this.dtpkFechaNum_ValueChanged);
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaIngreso.Location = new System.Drawing.Point(326, 126);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(47, 19);
            this.lblFechaIngreso.TabIndex = 12;
            this.lblFechaIngreso.Text = "Fecha:";
            // 
            // lblTituloNuevoNum
            // 
            this.lblTituloNuevoNum.AutoSize = true;
            this.lblTituloNuevoNum.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloNuevoNum.Location = new System.Drawing.Point(323, 76);
            this.lblTituloNuevoNum.Name = "lblTituloNuevoNum";
            this.lblTituloNuevoNum.Size = new System.Drawing.Size(207, 25);
            this.lblTituloNuevoNum.TabIndex = 13;
            this.lblTituloNuevoNum.Text = "Ingresar Nuevo Numero:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.Location = new System.Drawing.Point(636, 121);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(72, 27);
            this.btnIngresar.TabIndex = 14;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblTituloBuscarNum
            // 
            this.lblTituloBuscarNum.AutoSize = true;
            this.lblTituloBuscarNum.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloBuscarNum.Location = new System.Drawing.Point(323, 371);
            this.lblTituloBuscarNum.Name = "lblTituloBuscarNum";
            this.lblTituloBuscarNum.Size = new System.Drawing.Size(234, 25);
            this.lblTituloBuscarNum.TabIndex = 15;
            this.lblTituloBuscarNum.Text = "Buscar Numeros Repetidos: ";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(839, 282);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 25);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(839, 250);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 26);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(839, 216);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 28);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 566);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaNumeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecuenciaNum)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colreset;
        private System.Windows.Forms.DataGridView dgvSecuenciaNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDsn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secNum;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.DateTimePicker dtpkFechaNum;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblTituloNuevoNum;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblTituloBuscarNum;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

