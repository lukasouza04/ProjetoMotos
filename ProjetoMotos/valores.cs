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
    public partial class valores: Form
    {
        private Simulacao _simulacao;

        public valores(Simulacao simulacao)
        {
            InitializeComponent();
            _simulacao = simulacao;
        }

        private void valores_Load(object sender, EventArgs e)
        {
            label1.Text = _simulacao.Nome.ToString();
        }
    }
}
