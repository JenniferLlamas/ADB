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
        public bool crear=false;
        public bool usar=false;
        public bool borrar=false;



        Form2 v2 = new Form2();
        string bd=null;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            v2.Show();
            crear = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            usar = true;
            v2.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            v2.Show();
        }

        private void Ventana1_Load(object sender, EventArgs e)
        {

        }
    }
}
