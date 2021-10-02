
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
            this.dgvTablaSecuenciasNum = new System.Windows.Forms.DataGridView();
            this.dtPickerInicial = new System.Windows.Forms.DateTimePicker();
            this.dtPickerFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colreset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaSecuenciasNum)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablaSecuenciasNum
            // 
            this.dgvTablaSecuenciasNum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaSecuenciasNum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colFecha,
            this.colNumeros,
            this.colreset,
            this.Reset});
            this.dgvTablaSecuenciasNum.Location = new System.Drawing.Point(25, 130);
            this.dgvTablaSecuenciasNum.Name = "dgvTablaSecuenciasNum";
            this.dgvTablaSecuenciasNum.RowTemplate.Height = 25;
            this.dgvTablaSecuenciasNum.Size = new System.Drawing.Size(659, 152);
            this.dgvTablaSecuenciasNum.TabIndex = 0;
            this.dgvTablaSecuenciasNum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dtPickerInicial
            // 
            this.dtPickerInicial.Location = new System.Drawing.Point(268, 74);
            this.dtPickerInicial.Name = "dtPickerInicial";
            this.dtPickerInicial.Size = new System.Drawing.Size(164, 23);
            this.dtPickerInicial.TabIndex = 1;
            // 
            // dtPickerFinal
            // 
            this.dtPickerFinal.Location = new System.Drawing.Point(523, 72);
            this.dtPickerFinal.Name = "dtPickerFinal";
            this.dtPickerFinal.Size = new System.Drawing.Size(161, 23);
            this.dtPickerFinal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicial:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Final:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(713, 72);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estadistica Numerica";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblresultado.Location = new System.Drawing.Point(327, 331);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 28);
            this.lblresultado.TabIndex = 7;
            this.lblresultado.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(136, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resultado Acierto";
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
            // Reset
            // 
            this.Reset.HeaderText = "Reset";
            this.Reset.Name = "Reset";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "ID ";
            this.textBox1.Size = new System.Drawing.Size(145, 23);
            this.textBox1.TabIndex = 9;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPickerFinal);
            this.Controls.Add(this.dtPickerInicial);
            this.Controls.Add(this.dgvTablaSecuenciasNum);
            this.Name = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaSecuenciasNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablaSecuenciasNum;
        private System.Windows.Forms.DateTimePicker dtPickerInicial;
        private System.Windows.Forms.DateTimePicker dtPickerFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colreset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reset;
        private System.Windows.Forms.TextBox textBox1;
    }
}

