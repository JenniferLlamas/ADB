using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace ABD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Regex nombreBDValidacion =  new Regex("^([a-zA-Z]+)([a-zA-Z]|([0-9]))*$");
        public string nombreDB;
        
        


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventana1 v1 = new Ventana1();
            nombreDB = nombrebd.Text;
            if (v1.crear)
            {
                Directorios dir = new Directorios();
                if (nombreBDValidacion.IsMatch(nombreDB))
                {
                    dir.CrearDir(nombreDB);
                    nombrebd.Text = "";
                }
                else
                {
                    MessageBox.Show("Nombre de Base de Datos Invalido");
                }
                v1.crear = false;
            }
            
            if(v1.usar)
            {
                Form3 v3 = new Form3();
                v3.Show();

                v1.usar = false;
            }

            this.Hide();

        }

        public class Directorios
        {


            public void CrearDir(string nom)
            {
                string carpeta = Application.StartupPath + @"\" + nom;
                
                try
                {
                    if(Directory.Exists(carpeta))
                    {
                        MessageBox.Show("La base de datos que intentas crear, ya existe");
                    }
                    else
                    {
                        Directory.CreateDirectory(carpeta);
                        MessageBox.Show("Base de Datos Creada");
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }

              
            }          
            


        }
            
        }
}
