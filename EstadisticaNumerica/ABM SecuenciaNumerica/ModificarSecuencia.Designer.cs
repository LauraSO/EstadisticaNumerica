
namespace EstadisticaNumerica.ABM_SecuenciaNumerica
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
            this.btnCancelarSec = new System.Windows.Forms.Button();
            this.btnGuardarSec = new System.Windows.Forms.Button();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.tbSecNumModi = new System.Windows.Forms.TextBox();
            this.lblTituloNuevoNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarSec
            // 
            this.btnCancelarSec.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarSec.Image = global::EstadisticaNumerica.Properties.Resources.cancel;
            this.btnCancelarSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarSec.Location = new System.Drawing.Point(239, 100);
            this.btnCancelarSec.Name = "btnCancelarSec";
            this.btnCancelarSec.Size = new System.Drawing.Size(105, 27);
            this.btnCancelarSec.TabIndex = 23;
            this.btnCancelarSec.Text = "Cancelar";
            this.btnCancelarSec.UseVisualStyleBackColor = true;
            this.btnCancelarSec.Click += new System.EventHandler(this.btnCancelarSec_Click);
            // 
            // btnGuardarSec
            // 
            this.btnGuardarSec.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarSec.Image = global::EstadisticaNumerica.Properties.Resources.save2;
            this.btnGuardarSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarSec.Location = new System.Drawing.Point(126, 100);
            this.btnGuardarSec.Name = "btnGuardarSec";
            this.btnGuardarSec.Size = new System.Drawing.Size(107, 27);
            this.btnGuardarSec.TabIndex = 22;
            this.btnGuardarSec.Text = "Guardar";
            this.btnGuardarSec.UseVisualStyleBackColor = true;
            this.btnGuardarSec.Click += new System.EventHandler(this.btnGuardarSec_Click);
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaIngreso.Location = new System.Drawing.Point(12, 59);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(130, 19);
            this.lblFechaIngreso.TabIndex = 20;
            this.lblFechaIngreso.Text = "Secuencia Numerica";
            // 
            // tbSecNumModi
            // 
            this.tbSecNumModi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSecNumModi.Location = new System.Drawing.Point(147, 56);
            this.tbSecNumModi.Name = "tbSecNumModi";
            this.tbSecNumModi.PlaceholderText = "98-47";
            this.tbSecNumModi.Size = new System.Drawing.Size(86, 25);
            this.tbSecNumModi.TabIndex = 19;
            // 
            // lblTituloNuevoNum
            // 
            this.lblTituloNuevoNum.AutoSize = true;
            this.lblTituloNuevoNum.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloNuevoNum.Location = new System.Drawing.Point(87, 5);
            this.lblTituloNuevoNum.Name = "lblTituloNuevoNum";
            this.lblTituloNuevoNum.Size = new System.Drawing.Size(173, 25);
            this.lblTituloNuevoNum.TabIndex = 24;
            this.lblTituloNuevoNum.Text = "Modificar Secuencia:";
            // 
            // ModificarSecuencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 149);
            this.Controls.Add(this.lblTituloNuevoNum);
            this.Controls.Add(this.btnCancelarSec);
            this.Controls.Add(this.btnGuardarSec);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.tbSecNumModi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarSecuencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModificarSecuencia";
            this.Load += new System.EventHandler(this.ModificarSecuencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarSec;
        private System.Windows.Forms.Button btnGuardarSec;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.TextBox tbSecNumModi;
        private System.Windows.Forms.Label lblTituloNuevoNum;
    }
}