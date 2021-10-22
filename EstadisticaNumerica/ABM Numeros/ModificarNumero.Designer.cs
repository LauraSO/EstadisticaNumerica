
namespace EstadisticaNumerica.ABM_Numeros
{
    partial class ModificarSecuencia
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
            this.SuspendLayout();
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaIngreso.Location = new System.Drawing.Point(12, 50);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(47, 19);
            this.lblFechaIngreso.TabIndex = 14;
            this.lblFechaIngreso.Text = "Fecha:";
            // 
            // tbNumModi
            // 
            this.tbNumModi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNumModi.Location = new System.Drawing.Point(173, 50);
            this.tbNumModi.Name = "tbNumModi";
            this.tbNumModi.PlaceholderText = "Numero ";
            this.tbNumModi.Size = new System.Drawing.Size(86, 25);
            this.tbNumModi.TabIndex = 13;
            // 
            // dtpkFechaNumModi
            // 
            this.dtpkFechaNumModi.CalendarFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpkFechaNumModi.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpkFechaNumModi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpkFechaNumModi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkFechaNumModi.Location = new System.Drawing.Point(65, 50);
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
            this.btnAceptar.Location = new System.Drawing.Point(48, 95);
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
            this.btnCancelar.Location = new System.Drawing.Point(161, 95);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 27);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ModificarNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 166);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtpkFechaNumModi);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.tbNumModi);
            this.Name = "ModificarNumero";
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
    }
}