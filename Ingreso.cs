using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tomaster_v0._3
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pregunta p = new Pregunta();
            p.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Dispose();
        }
        
    }
}