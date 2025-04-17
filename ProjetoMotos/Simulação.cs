using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMotos
{
    public partial class Simulação: Form
    {
        string _urlImagem;
        public Simulação(string urlImagem)
        {
            InitializeComponent();
            _urlImagem = urlImagem;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Simulação_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = _urlImagem;
        }
    }
}
