﻿
namespace ejercicio1Guia4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIngresarDato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresarDato
            // 
            this.btnIngresarDato.BackColor = System.Drawing.Color.Thistle;
            this.btnIngresarDato.ForeColor = System.Drawing.Color.DeepPink;
            this.btnIngresarDato.Location = new System.Drawing.Point(113, 84);
            this.btnIngresarDato.Name = "btnIngresarDato";
            this.btnIngresarDato.Size = new System.Drawing.Size(109, 44);
            this.btnIngresarDato.TabIndex = 0;
            this.btnIngresarDato.Text = "Ingresar Datos";
            this.btnIngresarDato.UseVisualStyleBackColor = false;
            this.btnIngresarDato.Click += new System.EventHandler(this.btnIngresarDato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(356, 205);
            this.Controls.Add(this.btnIngresarDato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarDato;
    }
}

