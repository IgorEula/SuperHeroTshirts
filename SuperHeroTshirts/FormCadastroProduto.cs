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
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.superHeroShirtsDBDataSet);

        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.superHeroShirtsDBDataSet.Produto);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int ultimoid = produtoTableAdapter.GetData().Max(p => p.ProdutoID);
            txtId.Text = (ultimoid + 1).ToString();
        }

        private void produtoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
