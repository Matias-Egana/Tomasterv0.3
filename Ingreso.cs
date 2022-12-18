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
            this.Hide();
            Pregunta p = new Pregunta();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal principal = new Principal();
            principal.Show();
        }
        
    }
}