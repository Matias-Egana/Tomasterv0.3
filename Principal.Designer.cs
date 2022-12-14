using System.ComponentModel;

namespace Tomaster_v0._3
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bIngresar = new System.Windows.Forms.Button();
            this.bHistorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tomaster FM\r\n";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(736, 91);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistema experto para la identificación y entrega del tratamiento ante una plaga o" + " enfermedad, referente al cultivo del tomate.\r\n";
            // 
            // bIngresar
            // 
            this.bIngresar.Location = new System.Drawing.Point(434, 341);
            this.bIngresar.Name = "bIngresar";
            this.bIngresar.Size = new System.Drawing.Size(133, 46);
            this.bIngresar.TabIndex = 2;
            this.bIngresar.Text = "Ingresar\r\n";
            this.bIngresar.UseVisualStyleBackColor = true;
            this.bIngresar.Click += new System.EventHandler(this.clickIngresar);
            // 
            // bHistorial
            // 
            this.bHistorial.Location = new System.Drawing.Point(232, 341);
            this.bHistorial.Name = "bHistorial";
            this.bHistorial.Size = new System.Drawing.Size(138, 45);
            this.bHistorial.TabIndex = 3;
            this.bHistorial.Text = "Historial\r\n";
            this.bHistorial.UseVisualStyleBackColor = true;
            this.bHistorial.Click += new System.EventHandler(this.clickHistorial);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bHistorial);
            this.Controls.Add(this.bIngresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bIngresar;
        private System.Windows.Forms.Button bHistorial;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}