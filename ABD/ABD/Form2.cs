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
            nombreDB = nombrebd.Text;
            
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

           

            public   void CrearSubDir(string nomdir,string nomsub)
            {
                string nomsubdir = @"c:\" + nomdir + "\\" + nomsub;
                if (!System.IO.File.Exists(nomsubdir))
                {
                    using (System.IO.FileStream fs = System.IO.File.Create(nomsubdir))
                    {
                        for (byte i = 0; i < 100; i++)
                        {
                            fs.WriteByte(i);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("File \"{0}\" already exists.", nomsubdir);
                    return;
                }

            }
         

        }
            
        }
}
