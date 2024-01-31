namespace SuperHeroTshirts
{
    partial class FormVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.superHeroShirtsDBDataSet = new SuperHeroTshirts.SuperHeroShirtsDBDataSet();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.btnCriarVenda = new System.Windows.Forms.Button();
            this.panelItensVenda = new System.Windows.Forms.Panel();
            this.txtIdItensVenda = new System.Windows.Forms.TextBox();
            this.itensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnInserirItem = new System.Windows.Forms.Button();
            this.dgvItensVenda = new System.Windows.Forms.DataGridView();
            this.produtoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.vendaTableAdapter = new SuperHeroTshirts.SuperHeroShirtsDBDataSetTableAdapters.VendaTableAdapter();
            this.funcionariosTableAdapter = new SuperHeroTshirts.SuperHeroShirtsDBDataSetTableAdapters.FuncionariosTableAdapter();
            this.clienteTableAdapter = new SuperHeroTshirts.SuperHeroShirtsDBDataSetTableAdapters.ClienteTableAdapter();
            this.itensVendaTableAdapter = new SuperHeroTshirts.SuperHeroShirtsDBDataSetTableAdapters.ItensVendaTableAdapter();
            this.produtoTableAdapter = new SuperHeroTshirts.SuperHeroShirtsDBDataSetTableAdapters.ProdutoTableAdapter();
            this.tableAdapterManager = new SuperHeroTshirts.SuperHeroShirtsDBDataSetTableAdapters.TableAdapterManager();
            this.tableAdapterManager1 = new SuperHeroTshirts.SuperHeroShirtsDBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHeroShirtsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            this.panelItensVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data da Venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vendedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(349, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor Total da Venda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(215, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Venda";
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "VendaID", true));
            this.txtId.Location = new System.Drawing.Point(379, 89);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(60, 20);
            this.txtId.TabIndex = 5;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "Venda";
            this.vendaBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // superHeroShirtsDBDataSet
            // 
            this.superHeroShirtsDBDataSet.DataSetName = "SuperHeroShirtsDBDataSet";
            this.superHeroShirtsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbCliente
            // 
            this.cmbCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "ClienteID", true));
            this.cmbCliente.DataSource = this.clienteBindingSource;
            this.cmbCliente.DisplayMember = "Nome";
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(11, 209);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(230, 21);
            this.cmbCliente.TabIndex = 8;
            this.cmbCliente.ValueMember = "ClienteID";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "FuncionarioID", true));
            this.cmbVendedor.DataSource = this.funcionariosBindingSource;
            this.cmbVendedor.DisplayMember = "Nome";
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(11, 153);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(230, 21);
            this.cmbVendedor.TabIndex = 10;
            this.cmbVendedor.ValueMember = "FuncionarioID";
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionarios";
            this.funcionariosBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vendaBindingSource, "DataVenda", true));
            this.dtpDataVenda.Location = new System.Drawing.Point(11, 89);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(230, 20);
            this.dtpDataVenda.TabIndex = 11;
            // 
            // btnCriarVenda
            // 
            this.btnCriarVenda.BackColor = System.Drawing.Color.Black;
            this.btnCriarVenda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCriarVenda.Location = new System.Drawing.Point(350, 189);
            this.btnCriarVenda.Name = "btnCriarVenda";
            this.btnCriarVenda.Size = new System.Drawing.Size(120, 41);
            this.btnCriarVenda.TabIndex = 12;
            this.btnCriarVenda.Text = "Criar Venda";
            this.btnCriarVenda.UseVisualStyleBackColor = false;
            this.btnCriarVenda.Click += new System.EventHandler(this.btnCriarVenda_Click);
            // 
            // panelItensVenda
            // 
            this.panelItensVenda.BackColor = System.Drawing.Color.Black;
            this.panelItensVenda.Controls.Add(this.txtIdItensVenda);
            this.panelItensVenda.Controls.Add(this.btnInserirItem);
            this.panelItensVenda.Controls.Add(this.dgvItensVenda);
            this.panelItensVenda.Controls.Add(this.nudQuantidade);
            this.panelItensVenda.Controls.Add(this.label8);
            this.panelItensVenda.Controls.Add(this.label7);
            this.panelItensVenda.Controls.Add(this.label6);
            this.panelItensVenda.Controls.Add(this.cmbProduto);
            this.panelItensVenda.Location = new System.Drawing.Point(11, 271);
            this.panelItensVenda.Name = "panelItensVenda";
            this.panelItensVenda.Size = new System.Drawing.Size(483, 324);
            this.panelItensVenda.TabIndex = 13;
            this.panelItensVenda.Visible = false;
            // 
            // txtIdItensVenda
            // 
            this.txtIdItensVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensVendaBindingSource, "VendaId", true));
            this.txtIdItensVenda.Location = new System.Drawing.Point(357, 14);
            this.txtIdItensVenda.Name = "txtIdItensVenda";
            this.txtIdItensVenda.Size = new System.Drawing.Size(100, 20);
            this.txtIdItensVenda.TabIndex = 23;
            // 
            // itensVendaBindingSource
            // 
            this.itensVendaBindingSource.DataMember = "ItensVenda";
            this.itensVendaBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // btnInserirItem
            // 
            this.btnInserirItem.BackColor = System.Drawing.Color.White;
            this.btnInserirItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInserirItem.Location = new System.Drawing.Point(337, 109);
            this.btnInserirItem.Name = "btnInserirItem";
            this.btnInserirItem.Size = new System.Drawing.Size(120, 39);
            this.btnInserirItem.TabIndex = 20;
            this.btnInserirItem.Text = "Inserir";
            this.btnInserirItem.UseVisualStyleBackColor = false;
            this.btnInserirItem.Click += new System.EventHandler(this.btnInserirItem_Click);
            // 
            // dgvItensVenda
            // 
            this.dgvItensVenda.AllowUserToAddRows = false;
            this.dgvItensVenda.AutoGenerateColumns = false;
            this.dgvItensVenda.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produtoIdDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn});
            this.dgvItensVenda.DataSource = this.itensVendaBindingSource;
            this.dgvItensVenda.Location = new System.Drawing.Point(16, 154);
            this.dgvItensVenda.Name = "dgvItensVenda";
            this.dgvItensVenda.Size = new System.Drawing.Size(445, 150);
            this.dgvItensVenda.TabIndex = 19;
            this.dgvItensVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItensVenda_CellContentClick);
            // 
            // produtoIdDataGridViewTextBoxColumn
            // 
            this.produtoIdDataGridViewTextBoxColumn.DataPropertyName = "ProdutoId";
            this.produtoIdDataGridViewTextBoxColumn.DataSource = this.produtoBindingSource;
            this.produtoIdDataGridViewTextBoxColumn.DisplayMember = "NomeProduto";
            this.produtoIdDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.produtoIdDataGridViewTextBoxColumn.Name = "produtoIdDataGridViewTextBoxColumn";
            this.produtoIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.produtoIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.produtoIdDataGridViewTextBoxColumn.ValueMember = "ProdutoID";
            this.produtoIdDataGridViewTextBoxColumn.Width = 300;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.itensVendaBindingSource, "Quantidade", true));
            this.nudQuantidade.Location = new System.Drawing.Point(337, 83);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(120, 20);
            this.nudQuantidade.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(336, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Quantidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(146, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Itens da Venda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(22, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Produto";
            // 
            // cmbProduto
            // 
            this.cmbProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itensVendaBindingSource, "ProdutoId", true));
            this.cmbProduto.DataSource = this.produtoBindingSource;
            this.cmbProduto.DisplayMember = "NomeProduto";
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(16, 82);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(300, 21);
            this.cmbProduto.TabIndex = 14;
            this.cmbProduto.ValueMember = "ProdutoID";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "TotalVenda", true));
            this.txtValorVenda.Location = new System.Drawing.Point(350, 154);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(122, 20);
            this.txtValorVenda.TabIndex = 22;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // itensVendaTableAdapter
            // 
            this.itensVendaTableAdapter.ClearBeforeFill = true;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.EstoqueTableAdapter = null;
            this.tableAdapterManager.FuncionariosTableAdapter = this.funcionariosTableAdapter;
            this.tableAdapterManager.ItensVendaTableAdapter = this.itensVendaTableAdapter;
            this.tableAdapterManager.ProdutoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.UpdateOrder = SuperHeroTshirts.SuperHeroShirtsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaTableAdapter = this.vendaTableAdapter;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClienteTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.EstoqueTableAdapter = null;
            this.tableAdapterManager1.FuncionariosTableAdapter = null;
            this.tableAdapterManager1.ItensVendaTableAdapter = null;
            this.tableAdapterManager1.ProdutoTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = SuperHeroTshirts.SuperHeroShirtsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VendaTableAdapter = null;
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(505, 600);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.panelItensVenda);
            this.Controls.Add(this.btnCriarVenda);
            this.Controls.Add(this.dtpDataVenda);
            this.Controls.Add(this.cmbVendedor);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVenda";
            this.Text = "FormVenda";
            this.Load += new System.EventHandler(this.FormVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHeroShirtsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            this.panelItensVenda.ResumeLayout(false);
            this.panelItensVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.Button btnCriarVenda;
        private System.Windows.Forms.Panel panelItensVenda;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.DataGridView dgvItensVenda;
        private System.Windows.Forms.Button btnInserirItem;
        private System.Windows.Forms.TextBox txtValorVenda;
        private SuperHeroShirtsDBDataSet superHeroShirtsDBDataSet;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private SuperHeroShirtsDBDataSetTableAdapters.VendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private SuperHeroShirtsDBDataSetTableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SuperHeroShirtsDBDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.TextBox txtIdItensVenda;
        private System.Windows.Forms.BindingSource itensVendaBindingSource;
        private SuperHeroShirtsDBDataSetTableAdapters.ItensVendaTableAdapter itensVendaTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private SuperHeroShirtsDBDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn produtoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private SuperHeroShirtsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private SuperHeroShirtsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}