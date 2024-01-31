using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperHeroTshirts
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroProduto form = new FormCadastroProduto();
            form.ShowDialog();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroFuncionario form = new FormCadastroFuncionario();
            form.ShowDialog();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente form = new FormCliente();
            form.ShowDialog();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstoque form = new FormEstoque();
            form.ShowDialog();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVenda form = new FormVenda();
            form.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
