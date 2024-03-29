﻿using SuperHeroTshirts.SuperHeroShirtsDBDataSetTableAdapters;
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
    public partial class FormEstoque : Form
    {
        public FormEstoque()
        {
            InitializeComponent();
        }

      

        private void estoqueBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estoqueBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.superHeroShirtsDBDataSet);

        }

        private void FormEstoque_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.superHeroShirtsDBDataSet.Produto);
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.Estoque' table. You can move, or remove it, as needed.
            this.estoqueTableAdapter.Fill(this.superHeroShirtsDBDataSet.Estoque);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int ultimoid = estoqueTableAdapter.GetData().Max(es => es.Id);
            txtId.Text = (ultimoid + 1).ToString();
        }

        private void estoqueDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
