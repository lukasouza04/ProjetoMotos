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
using ProjetoMotos.Model;
using ProjetoMotos.Properties;

namespace ProjetoMotos
{
    public partial class Form1 : Form
    {
        public Moto _motoSelecionada;
        public Form1()
        {
            InitializeComponent();
            _motoSelecionada = new Moto();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _motoSelecionada = comboBox2.SelectedItem as Moto;
            pictureBox2.Image = _motoSelecionada.URLImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                     

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "HONDA ")
            {
                ClearComboBox2();


                var motosHonda = new List<Moto>
                {

                    new Moto("HONDA", "AFRICA TWIN", 91000, Resources.AFRICA_TWIN),
                    new Moto("HONDA", "BIZ", 14000, Resources.BIZ),
                    new Moto("HONDA", "CB TWISTER", 18000, Resources.CB_TWISTER),
                    new Moto("HONDA", "CBR", 32000, Resources.CBR),
                    new Moto("HONDA", "TITAN", 15000, Resources.TITAN)
                };

                comboBox2.DisplayMember = "Modelo"; // O que será mostrado na lista
                comboBox2.ValueMember = "Self";     // "Self" não é padrão, veja abaixo como contornar

                foreach (var moto in motosHonda)
                {
                    comboBox2.Items.Add(moto);
                }


            }

            if (comboBox1.Text == "YAMAHA")
            {
                ClearComboBox2();

                var motosYAMAHA = new List<Moto> {

                    new Moto("YAMAHA", "FAZER 250", 25000, Resources.FAZER_250),
                    new Moto("YAMAHA", "MT 03", 34000, Resources.MT_03),
                    new Moto("YAMAHA", "MT 09", 60000, Resources.MT_09),
                    new Moto("YAMAHA", "XT 660", 40000, Resources.XT_660),
                    new Moto("YAMAHA", "R15", 22000, Resources.R15) };


                comboBox2.DisplayMember = "Modelo";
                comboBox2.ValueMember = "Self";

                foreach (var moto in motosYAMAHA)
                {
                    comboBox2.Items.Add(moto);
                }
            }


            if (comboBox1.Text == "KAWASAKI")
            {
                ClearComboBox2();


                var motosKAWASAKI = new List<Moto>
        {
            new Moto("KAWASAKI", "H2R", 350000, Resources.H2R),
            new Moto("KAWASAKI", "NINJA 400", 32000, Resources.NINJA_400),
            new Moto("KAWASAKI", "NINJA 650", 47000, Resources.NINJA_650),
            new Moto("KAWASAKI", "Z800", 35000, Resources.Z800),
            new Moto("KAWASAKI", "R15", 22000, Resources.R15)
        };

                comboBox2.DisplayMember = "Modelo"; // O que será mostrado na lista
                comboBox2.ValueMember = "Self";     // "Self" não é padrão, veja abaixo como contornar

                foreach (var moto in motosKAWASAKI)
                {
                    comboBox2.Items.Add(moto);
                }
            }



            if (comboBox1.Text == "BMW") {

                ClearComboBox2();


                var motosBMW = new List<Moto>
        {
            new Moto("BMW", "F800", 33000, Resources.F800),
            new Moto("BMW", "GS 310",35000, Resources.GS_310),
            new Moto("BMW", "GS 1250", 100000, Resources.GS_1250),
            new Moto("BMW", "S1000RR", 121000, Resources.S1000RR),
            new Moto("BMW", "F800R", 33000 , Resources.F800R)
        };

                comboBox2.DisplayMember = "Modelo"; // O que será mostrado na lista
                comboBox2.ValueMember = "Self";     // "Self" não é padrão, veja abaixo como contornar

                foreach (var moto in motosBMW)
                {
                    comboBox2.Items.Add(moto);
                }

            }
               

        }

        private void ClearComboBox2() {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
         
        {


            //_motoSelecionada = comboBox2.SelectedItem as Moto;


            Simulação telaNova = new Simulação(_motoSelecionada);
            telaNova.ShowDialog(); // abre como janela modal
        }
            

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
