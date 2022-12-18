using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace Tomaster_v0._3
{
    public partial class Confirmacion : Form
    {
        public Confirmacion()
        {
            
            InitializeComponent();
            //tamaño 200x200
            string ruta = "Oidio.jpg";
             Image imagen = Image.FromFile("C:/Users/mati_/Desktop/Proyecto 2022/c#/Tomaster v0.3/ImagenesConfirmacion/"+ruta);
             Bitmap objBitmap = new Bitmap(imagen, new Size(300, 300));
             pictureBox1.Image = objBitmap;
        }

        private void clickConfirmo(object sender, EventArgs e)
        {
            if (rSi.Checked)
            {
                this.Hide();
                MostrarTratamiento mt = new MostrarTratamiento();
                mt.Show();
            }

            if (rNo.Checked)
            {
                this.Hide();
                Ingreso i = new Ingreso();
                i.Show();
            }
         
        }
    }
}