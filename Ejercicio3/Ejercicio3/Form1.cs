using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    
    public partial class Form1 : Form
    {
        public static Image imagen;
        public static string tituloImagen;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro?", "Ejercicio3", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;
               
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        tituloImagen = Path.GetFileName(openFileDialog.FileName);
                        imagen = Image.FromFile(openFileDialog.FileName);
                        Form f2 = new Form2();
                        if (checkBox1.Checked)
                        {
                            f2.ShowDialog();
                        }
                        else 
                        {
                            f2.Show();
                        }
                    }
                    catch (System.OutOfMemoryException) 
                    {
                        Console.WriteLine("Error");
                    }
                }
            }
        }
    }
}
