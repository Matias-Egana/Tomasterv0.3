using System.ComponentModel;

namespace Tomaster_v0._3
{
    partial class Confirmacion
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
            this.panelIma = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bConfirma = new System.Windows.Forms.Button();
            this.rSi = new System.Windows.Forms.RadioButton();
            this.rNo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // panelIma
            // 
            this.panelIma.Location = new System.Drawing.Point(32, 66);
            this.panelIma.Name = "panelIma";
            this.panelIma.Size = new System.Drawing.Size(473, 240);
            this.panelIma.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "¿Es esta su plaga?";
            // 
            // bConfirma
            // 
            this.bConfirma.Location = new System.Drawing.Point(362, 397);
            this.bConfirma.Name = "bConfirma";
            this.bConfirma.Size = new System.Drawing.Size(143, 40);
            this.bConfirma.TabIndex = 3;
            this.bConfirma.Text = "Confirmo";
            this.bConfirma.UseVisualStyleBackColor = true;
            this.bConfirma.Click += new System.EventHandler(this.clickConfirmo);
            // 
            // rSi
            // 
            this.rSi.Location = new System.Drawing.Point(32, 341);
            this.rSi.Name = "rSi";
            this.rSi.Size = new System.Drawing.Size(129, 28);
            this.rSi.TabIndex = 4;
            this.rSi.TabStop = true;
            this.rSi.Text = "Si";
            this.rSi.UseVisualStyleBackColor = true;
            this.rSi.CheckedChanged += new System.EventHandler(this.rSi_CheckedChanged);
            // 
            // rNo
            // 
            this.rNo.Location = new System.Drawing.Point(374, 341);
            this.rNo.Name = "rNo";
            this.rNo.Size = new System.Drawing.Size(131, 26);
            this.rNo.TabIndex = 5;
            this.rNo.TabStop = true;
            this.rNo.Text = "No";
            this.rNo.UseVisualStyleBackColor = true;
            this.rNo.CheckedChanged += new System.EventHandler(this.rNo_CheckedChanged);
            // 
            // Confirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 460);
            this.Controls.Add(this.rNo);
            this.Controls.Add(this.rSi);
            this.Controls.Add(this.bConfirma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelIma);
            this.Name = "Confirmacion";
            this.Text = "Confirmacion";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RadioButton rSi;
        private System.Windows.Forms.RadioButton rNo;

        private System.Windows.Forms.Button bConfirma;

        private System.Windows.Forms.Panel panelIma;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}