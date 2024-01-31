using SuperHeroTshirts.SuperHeroShirtsDBDataSetTableAdapters;
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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.superHeroShirtsDBDataSet);

        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.superHeroShirtsDBDataSet.Cliente);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int ultimoid = clienteTableAdapter.GetData().Max(c => c.ClienteID);
            txtIdCliente.Text = (ultimoid + 1).ToString();
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
