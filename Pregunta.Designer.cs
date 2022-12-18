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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pregunta));
            this.labelPregunta = new System.Windows.Forms.Label();
            this.rSi = new System.Windows.Forms.RadioButton();
            this.rNo = new System.Windows.Forms.RadioButton();
            this.bSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPregunta
            // 
            this.labelPregunta.BackColor = System.Drawing.Color.Transparent;
            this.labelPregunta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPregunta.Location = new System.Drawing.Point(38, 43);
            this.labelPregunta.Name = "labelPregunta";
            this.labelPregunta.Size = new System.Drawing.Size(697, 143);
            this.labelPregunta.TabIndex = 0;
            this.labelPregunta.Text = "\"Pregunta\"";
            // 
            // rSi
            // 
            this.rSi.BackColor = System.Drawing.Color.Transparent;
            this.rSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rSi.ForeColor = System.Drawing.Color.Black;
            this.rSi.Location = new System.Drawing.Point(55, 229);
            this.rSi.Name = "rSi";
            this.rSi.Size = new System.Drawing.Size(85, 36);
            this.rSi.TabIndex = 1;
            this.rSi.TabStop = true;
            this.rSi.Text = "Si";
            this.rSi.UseVisualStyleBackColor = false;
            this.rSi.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rNo
            // 
            this.rNo.BackColor = System.Drawing.Color.Transparent;
            this.rNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rNo.ForeColor = System.Drawing.Color.Black;
            this.rNo.Location = new System.Drawing.Point(55, 295);
            this.rNo.Name = "rNo";
            this.rNo.Size = new System.Drawing.Size(85, 32);
            this.rNo.TabIndex = 2;
            this.rNo.TabStop = true;
            this.rNo.Text = "No";
            this.rNo.UseVisualStyleBackColor = false;
            this.rNo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // bSiguiente
            // 
            this.bSiguiente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bSiguiente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bSiguiente.Location = new System.Drawing.Point(594, 447);
            this.bSiguiente.Name = "bSiguiente";
            this.bSiguiente.Size = new System.Drawing.Size(141, 34);
            this.bSiguiente.TabIndex = 3;
            this.bSiguiente.Text = "Siguiente";
            this.bSiguiente.UseVisualStyleBackColor = false;
            this.bSiguiente.Click += new System.EventHandler(this.bSiguiente_Click);
            // 
            // Pregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tomaster_v0._3.Properties.Resources.tomater;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.bSiguiente);
            this.Controls.Add(this.rNo);
            this.Controls.Add(this.rSi);
            this.Controls.Add(this.labelPregunta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pregunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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