namespace SuperHeroTshirts
{
    partial class FormEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstoque));
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.superHeroShirtsDBDataSet = new SuperHeroTshirts.SuperHeroShirtsDBDataSet();
            this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueTableAdapter = new SuperHeroTshirts.SuperHeroShirtsDBDataSetTableAdapters.EstoqueTableAdapter();
            this.tableAdapterManager = new SuperHeroTshirts.SuperHeroShirtsDBDataSetTableAdapters.TableAdapterManager();
            this.estoqueBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.estoqueBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.estoqueDataGridView = new System.Windows.Forms.DataGridView();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.superHeroShirtsDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new SuperHeroTshirts.SuperHeroShirtsDBDataSetTableAdapters.ProdutoTableAdapter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.superHeroShirtsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingNavigator)).BeginInit();
            this.estoqueBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHeroShirtsDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProduto
            // 
            this.cmbProduto.BackColor = System.Drawing.SystemColors.Info;
            this.cmbProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.estoqueBindingSource, "ProdutoID", true));
            this.cmbProduto.DataSource = this.produtoBindingSource;
            this.cmbProduto.DisplayMember = "NomeProduto";
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(33, 106);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(121, 21);
            this.cmbProduto.TabIndex = 0;
            this.cmbProduto.ValueMember = "ProdutoID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(30, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Info;
            this.txtId.Location = new System.Drawing.Point(181, 106);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 4;
            // 
            // superHeroShirtsDBDataSet
            // 
            this.superHeroShirtsDBDataSet.DataSetName = "SuperHeroShirtsDBDataSet";
            this.superHeroShirtsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estoqueBindingSource
            // 
            this.estoqueBindingSource.DataMember = "Estoque";
            this.estoqueBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // estoqueTableAdapter
            // 
            this.estoqueTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.EstoqueTableAdapter = this.estoqueTableAdapter;
            this.tableAdapterManager.FuncionariosTableAdapter = null;
            this.tableAdapterManager.ItensVendaTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.UpdateOrder = SuperHeroTshirts.SuperHeroShirtsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaTableAdapter = null;
            // 
            // estoqueBindingNavigator
            // 
            this.estoqueBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.estoqueBindingNavigator.BindingSource = this.estoqueBindingSource;
            this.estoqueBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.estoqueBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.estoqueBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.estoqueBindingNavigatorSaveItem});
            this.estoqueBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.estoqueBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.estoqueBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.estoqueBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.estoqueBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.estoqueBindingNavigator.Name = "estoqueBindingNavigator";
            this.estoqueBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.estoqueBindingNavigator.Size = new System.Drawing.Size(314, 25);
            this.estoqueBindingNavigator.TabIndex = 5;
            this.estoqueBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // estoqueBindingNavigatorSaveItem
            // 
            this.estoqueBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.estoqueBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("estoqueBindingNavigatorSaveItem.Image")));
            this.estoqueBindingNavigatorSaveItem.Name = "estoqueBindingNavigatorSaveItem";
            this.estoqueBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.estoqueBindingNavigatorSaveItem.Text = "Save Data";
            this.estoqueBindingNavigatorSaveItem.Click += new System.EventHandler(this.estoqueBindingNavigatorSaveItem_Click);
            // 
            // estoqueDataGridView
            // 
            this.estoqueDataGridView.AutoGenerateColumns = false;
            this.estoqueDataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.estoqueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estoqueDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.estoqueDataGridView.DataSource = this.estoqueBindingSource;
            this.estoqueDataGridView.Location = new System.Drawing.Point(33, 254);
            this.estoqueDataGridView.Name = "estoqueDataGridView";
            this.estoqueDataGridView.Size = new System.Drawing.Size(248, 220);
            this.estoqueDataGridView.TabIndex = 6;
            this.estoqueDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.estoqueDataGridView_CellContentClick);
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.BackColor = System.Drawing.SystemColors.Info;
            this.nudQuantidade.Location = new System.Drawing.Point(33, 198);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(120, 20);
            this.nudQuantidade.TabIndex = 7;
            // 
            // superHeroShirtsDBDataSetBindingSource
            // 
            this.superHeroShirtsDBDataSetBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            this.superHeroShirtsDBDataSetBindingSource.Position = 0;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.superHeroShirtsDBDataSetBindingSource;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProdutoID";
            this.dataGridViewTextBoxColumn2.DataSource = this.produtoBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "NomeProduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ProdutoID";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(314, 499);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.estoqueDataGridView);
            this.Controls.Add(this.estoqueBindingNavigator);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProduto);
            this.Name = "FormEstoque";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.FormEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.superHeroShirtsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingNavigator)).EndInit();
            this.estoqueBindingNavigator.ResumeLayout(false);
            this.estoqueBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHeroShirtsDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private SuperHeroShirtsDBDataSet superHeroShirtsDBDataSet;
        private System.Windows.Forms.BindingSource estoqueBindingSource;
        private SuperHeroShirtsDBDataSetTableAdapters.EstoqueTableAdapter estoqueTableAdapter;
        private SuperHeroShirtsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator estoqueBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton estoqueBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView estoqueDataGridView;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.BindingSource superHeroShirtsDBDataSetBindingSource;
        private SuperHeroShirtsDBDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}