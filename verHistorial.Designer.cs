using System.ComponentModel;

namespace Tomaster_v0._3
{
    partial class ver_Historial
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
            this.panelHistorial = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.bVolver = new System.Windows.Forms.Button();
            this.panelHistorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHistorial
            // 
            this.panelHistorial.Controls.Add(this.vScrollBar1);
            this.panelHistorial.Controls.Add(this.hScrollBar1);
            this.panelHistorial.Location = new System.Drawing.Point(18, 31);
            this.panelHistorial.Name = "panelHistorial";
            this.panelHistorial.Size = new System.Drawing.Size(741, 338);
            this.panelHistorial.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(711, 1);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(29, 312);
            this.vScrollBar1.TabIndex = 1;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(2, 313);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(738, 24);
            this.hScrollBar1.TabIndex = 0;
            // 
            // bVolver
            // 
            this.bVolver.Location = new System.Drawing.Point(18, 385);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(131, 33);
            this.bVolver.TabIndex = 2;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.clickVolver);
            // 
            // ver_Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.panelHistorial);
            this.Name = "verHistorial";
            this.Text = "verHistorial";
            this.panelHistorial.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        
        private System.Windows.Forms.Button bVolver;

        private System.Windows.Forms.Panel panelHistorial;

        #endregion
    }
}