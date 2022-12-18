using System;
using System.Windows.Forms;

namespace Tomaster_v0._3
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void clickIngresar(object sender, EventArgs e)
        {    
            this.Hide();
            Ingreso i = new Ingreso();
            i.Show();

        }

        private void clickHistorial(object sender, EventArgs e)
        {
       
        }
        
    }
}