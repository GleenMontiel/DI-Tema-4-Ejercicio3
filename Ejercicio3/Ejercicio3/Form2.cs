using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            pictureBox1.Image = Form1.imagen;
            this.Size = pictureBox1.Size;
            this.Text = Form1.tituloImagen;
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            pictureBox1.Size = this.Size;
        }
    }
}
