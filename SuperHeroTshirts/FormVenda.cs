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
    public partial class FormVenda : Form
    {
        public FormVenda()
        {
            InitializeComponent();
        }

        private void FormVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.superHeroShirtsDBDataSet.Produto);
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.ItensVenda' table. You can move, or remove it, as needed.
            this.itensVendaTableAdapter.Fill(this.superHeroShirtsDBDataSet.ItensVenda);
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.superHeroShirtsDBDataSet.Cliente);
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.Funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.superHeroShirtsDBDataSet.Funcionarios);
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.Venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter.Fill(this.superHeroShirtsDBDataSet.Venda);

            //Colocando nosso form em modo de adição, ou seja,
            //Limpando os campos e deixando para inserir um novo.
            this.vendaBindingSource.AddNew();
            //Coloca o Id no campo Id
            int id = vendaTableAdapter.GetData().Max(v => v.VendaID) + 1;
            txtId.Text = id.ToString();
            //Coloca a data de hoje no campo data
            dtpDataVenda.Value = DateTime.Now;
            //Coloque o valor total da compra como zero
            txtValorVenda.Text = "0";

        }

        private void dgvItensVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCriarVenda_Click(object sender, EventArgs e)
        {
            //Codoigo para salvar uma venda
            this.Validate();
            this.vendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.superHeroShirtsDBDataSet);

            MessageBox.Show("Venda criada com sucesso, insira os itens da venda");
            //Coloque o panel que tem os itens da venda como visível
            panelItensVenda.Visible = true;

            ItensVendaModoInsercao();
        }

        private void ItensVendaModoInsercao()
        {
            itensVendaBindingSource.Filter = "VendaId = " + txtId.Text;
            //Colocar seu Databiding em modo de INSEÇÃO
            itensVendaBindingSource.AddNew();
            //Usar o Id da venda de cima
            txtIdItensVenda.Text = txtId.Text;

        }

        private void btnInserirItem_Click(object sender, EventArgs e)
        {
            //Salvar o item de venda
            this.Validate();
            this.itensVendaBindingSource.EndEdit();
            this.itensVendaTableAdapter.Update(this.superHeroShirtsDBDataSet);

            MessageBox.Show("Item adicionado com sucesso!");

            //Colocar seu formulário novamente em modo de inserção
            ItensVendaModoInsercao();

            //Calcular o valor total da venda
            int VendaId = Convert.ToInt32(txtId.Text);
            decimal totalVenda = 0;

            var dados = itensVendaTableAdapter.GetData();
            var dadosFiltrados = dados.Where(iv => iv.VendaId == VendaId);

            foreach (var item in dadosFiltrados) 
            { 
                var produtosDados = produtoTableAdapter.GetData();
                var produtosDadosFiltrados = produtosDados.Where(p => p.ProdutoID == item.ProdutoId);
                decimal valorProduto = produtosDadosFiltrados.First().Valor;

                int quantidade = 0;

                if(item.Quantidade != null) 
                {
                    quantidade = item.Quantidade;
                }
                else
                {
                    quantidade = Convert.ToInt32(nudQuantidade.Value);
                }

                totalVenda += quantidade + valorProduto;
            }

            txtValorVenda.Text = totalVenda.ToString();
        }
    }
}
