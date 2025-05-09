using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoMotos.Model;

namespace ProjetoMotos
{
    public partial class Simulação: Form
    {
        
        public Moto _moto;
        public Simulação(Moto moto)
        {
            InitializeComponent();
            
            _moto = moto;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simulacao simulacao = new Simulacao();
            simulacao.Nome = txtNome.Text;
            simulacao.DataNascimento = maskedTextBox1.Text;
            simulacao.CPF = maskedTextBox2.Text;
            simulacao.CNH = comboBox1.SelectedItem.ToString();


            valores valores = new valores(simulacao);
            valores.ShowDialog();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());

        }

        private void Simulação_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = _moto.URLImage;
            label5.Text = _moto.Preco.ToString();




            

        }
    }
}
