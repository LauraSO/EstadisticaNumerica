
namespace EstadisticaNumerica.ABM_Numeros
{
    partial class ModificarNumero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.tbNumModi = new System.Windows.Forms.TextBox();
            this.dtpkFechaNumModi = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTituloNuevoNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaIngreso.Location = new System.Drawing.Point(10, 62);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(47, 19);
            this.lblFechaIngreso.TabIndex = 14;
            this.lblFechaIngreso.Text = "Fecha:";
            // 
            // tbNumModi
            // 
            this.tbNumModi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNumModi.Location = new System.Drawing.Point(171, 62);
            this.tbNumModi.Name = "tbNumModi";
            this.tbNumModi.PlaceholderText = "Numero ";
            this.tbNumModi.Size = new System.Drawing.Size(105, 25);
            this.tbNumModi.TabIndex = 13;
            // 
            // dtpkFechaNumModi
            // 
            this.dtpkFechaNumModi.CalendarFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpkFechaNumModi.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpkFechaNumModi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpkFechaNumModi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkFechaNumModi.Location = new System.Drawing.Point(63, 62);
            this.dtpkFechaNumModi.Name = "dtpkFechaNumModi";
            this.dtpkFechaNumModi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpkFechaNumModi.Size = new System.Drawing.Size(102, 25);
            this.dtpkFechaNumModi.TabIndex = 16;
            this.dtpkFechaNumModi.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.Image = global::EstadisticaNumerica.Properties.Resources.save2;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(84, 116);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 27);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Image = global::EstadisticaNumerica.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(197, 116);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 27);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTituloNuevoNum
            // 
            this.lblTituloNuevoNum.AutoSize = true;
            this.lblTituloNuevoNum.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloNuevoNum.Location = new System.Drawing.Point(63, 9);
            this.lblTituloNuevoNum.Name = "lblTituloNuevoNum";
            this.lblTituloNuevoNum.Size = new System.Drawing.Size(161, 25);
            this.lblTituloNuevoNum.TabIndex = 19;
            this.lblTituloNuevoNum.Text = "Modificar Numero:";
            // 
            // ModificarNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 166);
            this.Controls.Add(this.lblTituloNuevoNum);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtpkFechaNumModi);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.tbNumModi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarNumero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Numero";
            this.Load += new System.EventHandler(this.ModificarNumero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.TextBox tbNumModi;
        private System.Windows.Forms.DateTimePicker dtpkFechaNumModi;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTituloNuevoNum;
    }
}