using System.ComponentModel;

namespace Tomaster_v0._3
{
    partial class MostrarTratamiento
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
            this.panelBio = new System.Windows.Forms.Panel();
            this.panelMeca = new System.Windows.Forms.Panel();
            this.panelQui = new System.Windows.Forms.Panel();
            this.panelIma = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bAgregardataset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelBio
            // 
            this.panelBio.Location = new System.Drawing.Point(20, 107);
            this.panelBio.Name = "panelBio";
            this.panelBio.Size = new System.Drawing.Size(407, 73);
            this.panelBio.TabIndex = 0;
            // 
            // panelMeca
            // 
            this.panelMeca.Location = new System.Drawing.Point(20, 344);
            this.panelMeca.Name = "panelMeca";
            this.panelMeca.Size = new System.Drawing.Size(407, 80);
            this.panelMeca.TabIndex = 1;
            // 
            // panelQui
            // 
            this.panelQui.Location = new System.Drawing.Point(20, 221);
            this.panelQui.Name = "panelQui";
            this.panelQui.Size = new System.Drawing.Size(407, 80);
            this.panelQui.TabIndex = 2;
            // 
            // panelIma
            // 
            this.panelIma.Location = new System.Drawing.Point(473, 107);
            this.panelIma.Name = "panelIma";
            this.panelIma.Size = new System.Drawing.Size(270, 261);
            this.panelIma.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tratamientos:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Control Biologico.\r\n";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Control Quimico.\r\n";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Control Mecanico.\r\n";
            // 
            // bAgregardataset
            // 
            this.bAgregardataset.Location = new System.Drawing.Point(486, 396);
            this.bAgregardataset.Name = "bAgregardataset";
            this.bAgregardataset.Size = new System.Drawing.Size(241, 37);
            this.bAgregardataset.TabIndex = 8;
            this.bAgregardataset.Text = "Siguiente";
            this.bAgregardataset.UseVisualStyleBackColor = true;
            this.bAgregardataset.Click += new System.EventHandler(this.bAgregaralDataset);
            // 
            // MostrarTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.bAgregardataset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelQui);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelIma);
            this.Controls.Add(this.panelMeca);
            this.Controls.Add(this.panelBio);
            this.Name = "MostrarTratamiento";
            this.Text = "MostrarTratamiento";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bAgregardataset;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panelIma;

        private System.Windows.Forms.Panel panelQui;

        private System.Windows.Forms.Panel panelBio;
        private System.Windows.Forms.Panel panelMeca;

        #endregion
    }
}