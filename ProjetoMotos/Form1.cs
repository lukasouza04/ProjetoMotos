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

namespace ProjetoMotos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] NomeFotosMotos = Directory.GetFiles(@"C:\Users\victoria.tbarros\OneDrive\PROJETO SENAC\Fotos");
            foreach (string img in NomeFotosMotos)
            {
                string[] separador = img.Split('\\');
                string[] nomeSelecionado = separador[6].Split('.');
                if (comboBox2.Text == nomeSelecionado[0])
                {
                    pictureBox2.ImageLocation = @"C:\Users\victoria.tbarros\OneDrive\PROJETO SENAC\Fotos\" + comboBox2.Text + ".jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "HONDA ")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("AFRICA TWIN");
                comboBox2.Items.Add("BIZ");
                comboBox2.Items.Add("CB TWISTER");
                comboBox2.Items.Add("CBR");
                comboBox2.Items.Add("TITAN");
            }

            else if (comboBox1.Text == "YAMAHA")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("FAZER 250");
                comboBox2.Items.Add("MT 03");
                comboBox2.Items.Add("MT 09");
                comboBox2.Items.Add("XT 660");
                comboBox2.Items.Add("R15");
            }

            else if (comboBox1.Text == "KAWASAKI")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("H2R");
                comboBox2.Items.Add("NINJA 400");
                comboBox2.Items.Add("NINJA 650");
                comboBox2.Items.Add("Z800");
                comboBox2.Items.Add("Z1000");
            }

            else if (comboBox1.Text == "BMW")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("F800");
                comboBox2.Items.Add("GS 310");
                comboBox2.Items.Add("GS 1250");
                comboBox2.Items.Add("S1000RR");
                comboBox2.Items.Add("F800R");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simulação telaNova = new Simulação(@"C:\Users\victoria.tbarros\OneDrive\PROJETO SENAC\Fotos\" + comboBox2.Text + ".jpg");
            telaNova.ShowDialog(); // abre como janela modal

            {
                String[] NomeFotosMotos = Directory.GetFiles(@"C:\Users\victoria.tbarros\OneDrive\PROJETO SENAC\Fotos");
                foreach (string img in NomeFotosMotos)
                {
                    string[] separador = img.Split('\\');
                    string[] nomeSelecionado = separador[6].Split('.');
                    if (comboBox1.Text == nomeSelecionado[0])
                    
                        pictureBox1.ImageLocation = @"C:\Users\victoria.tbarros\OneDrive\PROJETO SENAC\Fotos\" + comboBox1.Text + ".jpg";
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


                        if (comboBox1.Text == "HONDA ")
                        {
                            comboBox2.Items.Clear();
                            comboBox2.Items.Add("AFRICA TWIN");
                            comboBox2.Items.Add("BIZ");
                            comboBox2.Items.Add("CB TWISTER");
                            comboBox2.Items.Add("CBR");
                            comboBox2.Items.Add("TITAN");
                        }

                        else if (comboBox1.Text == "YAMAHA")
                        {
                            comboBox2.Items.Clear();
                            comboBox2.Items.Add("FAZER 250");
                            comboBox2.Items.Add("MT 03");
                            comboBox2.Items.Add("MT 09");
                            comboBox2.Items.Add("XT 660");
                            comboBox2.Items.Add("R15");
                        }

                        else if (comboBox1.Text == "KAWASAKI")
                        {
                            comboBox2.Items.Clear();
                            comboBox2.Items.Add("H2R");
                            comboBox2.Items.Add("NINJA 400");
                            comboBox2.Items.Add("NINJA 650");
                            comboBox2.Items.Add("Z800");
                            comboBox2.Items.Add("Z1000");
                        }

                        else if (comboBox1.Text == "BMW")
                        {
                            comboBox2.Items.Clear();
                            comboBox2.Items.Add("F800");
                            comboBox2.Items.Add("GS 310");
                            comboBox2.Items.Add("GS 1250");
                            comboBox2.Items.Add("S1000RR");
                            comboBox2.Items.Add("F800R");
                        }

                    }



                }
            }
        }
    }
