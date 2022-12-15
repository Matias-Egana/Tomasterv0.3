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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmacion));
            this.panelIma = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bConfirma = new System.Windows.Forms.Button();
            this.rSi = new System.Windows.Forms.RadioButton();
            this.rNo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // panelIma
            // 
            this.panelIma.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelIma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelIma.Location = new System.Drawing.Point(32, 66);
            this.panelIma.Name = "panelIma";
            this.panelIma.Size = new System.Drawing.Size(473, 240);
            this.panelIma.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "¿Es esta su plaga?";
            // 
            // bConfirma
            // 
            this.bConfirma.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bConfirma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bConfirma.Location = new System.Drawing.Point(374, 396);
            this.bConfirma.Name = "bConfirma";
            this.bConfirma.Size = new System.Drawing.Size(131, 40);
            this.bConfirma.TabIndex = 3;
            this.bConfirma.Text = "Confirmo";
            this.bConfirma.UseVisualStyleBackColor = false;
            this.bConfirma.Click += new System.EventHandler(this.clickConfirmo);
            // 
            // rSi
            // 
            this.rSi.BackColor = System.Drawing.Color.Transparent;
            this.rSi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rSi.Location = new System.Drawing.Point(32, 341);
            this.rSi.Name = "rSi";
            this.rSi.Size = new System.Drawing.Size(48, 28);
            this.rSi.TabIndex = 4;
            this.rSi.TabStop = true;
            this.rSi.Text = "Si";
            this.rSi.UseVisualStyleBackColor = false;
            this.rSi.CheckedChanged += new System.EventHandler(this.rSi_CheckedChanged);
            // 
            // rNo
            // 
            this.rNo.BackColor = System.Drawing.Color.Transparent;
            this.rNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rNo.Location = new System.Drawing.Point(374, 343);
            this.rNo.Name = "rNo";
            this.rNo.Size = new System.Drawing.Size(51, 26);
            this.rNo.TabIndex = 5;
            this.rNo.TabStop = true;
            this.rNo.Text = "No";
            this.rNo.UseVisualStyleBackColor = false;
            this.rNo.CheckedChanged += new System.EventHandler(this.rNo_CheckedChanged);
            // 
            // Confirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tomaster_v0._3.Properties.Resources.tomater;
            this.ClientSize = new System.Drawing.Size(548, 460);
            this.Controls.Add(this.rNo);
            this.Controls.Add(this.rSi);
            this.Controls.Add(this.bConfirma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelIma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Confirmacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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