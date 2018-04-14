using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABD
{
    public partial class Ventana1 : Form
    {
        public Ventana1()
        {
            InitializeComponent();
            
        }
        Form2 ventana = new Form2();
        string bd=null;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventana.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventana.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ventana.Show();
        }
    }
}
