using System.ComponentModel;

namespace Tomaster_v0._3
{
    partial class Pregunta
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
            this.labelPregunta = new System.Windows.Forms.Label();
            this.rSi = new System.Windows.Forms.RadioButton();
            this.rNo = new System.Windows.Forms.RadioButton();
            this.bSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPregunta
            // 
            this.labelPregunta.Location = new System.Drawing.Point(24, 42);
            this.labelPregunta.Name = "labelPregunta";
            this.labelPregunta.Size = new System.Drawing.Size(689, 143);
            this.labelPregunta.TabIndex = 0;
            this.labelPregunta.Text = "\"Pregunta\"";
            // 
            // rSi
            // 
            this.rSi.Location = new System.Drawing.Point(55, 224);
            this.rSi.Name = "rSi";
            this.rSi.Size = new System.Drawing.Size(171, 41);
            this.rSi.TabIndex = 1;
            this.rSi.TabStop = true;
            this.rSi.Text = "Si";
            this.rSi.UseVisualStyleBackColor = true;
            this.rSi.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rNo
            // 
            this.rNo.Location = new System.Drawing.Point(55, 295);
            this.rNo.Name = "rNo";
            this.rNo.Size = new System.Drawing.Size(96, 32);
            this.rNo.TabIndex = 2;
            this.rNo.TabStop = true;
            this.rNo.Text = "No";
            this.rNo.UseVisualStyleBackColor = true;
            this.rNo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // bSiguiente
            // 
            this.bSiguiente.Location = new System.Drawing.Point(572, 375);
            this.bSiguiente.Name = "bSiguiente";
            this.bSiguiente.Size = new System.Drawing.Size(141, 34);
            this.bSiguiente.TabIndex = 3;
            this.bSiguiente.Text = "Siguiente";
            this.bSiguiente.UseVisualStyleBackColor = true;
            this.bSiguiente.Click += new System.EventHandler(this.bSiguiente_Click);
            // 
            // Pregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSiguiente);
            this.Controls.Add(this.rNo);
            this.Controls.Add(this.rSi);
            this.Controls.Add(this.labelPregunta);
            this.Name = "Pregunta";
            this.Text = "Pregunta";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bSiguiente;

        private System.Windows.Forms.Label labelPregunta;
        private System.Windows.Forms.RadioButton rSi;
        private System.Windows.Forms.RadioButton rNo;

        #endregion
    }
}