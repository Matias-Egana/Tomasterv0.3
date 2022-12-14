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
            Ingreso i = new Ingreso();
            i.ShowDialog();
        }

        private void clickHistorial(object sender, EventArgs e)
        {
        }
    }
}