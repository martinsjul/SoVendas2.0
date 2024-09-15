namespace WfaVendas
{
    partial class FrmCadVendaClientes
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
            System.Windows.Forms.Label codproLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label precounitLabel;
            System.Windows.Forms.Label numvendaLabel1;
            System.Windows.Forms.Label datavendaLabel;
            System.Windows.Forms.Label dataentregaLabel;
            System.Windows.Forms.Label obsLabel;
            System.Windows.Forms.Label codcliLabel;
            System.Windows.Forms.Label txtSubtotal;
            System.Windows.Forms.Label label1;
            this.btnSair = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.lP2DataSet = new WfaVendas.LP2DataSet();
            this.pc_itemvendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_itemvendaTableAdapter = new WfaVendas.LP2DataSetTableAdapters.pc_itemvendaTableAdapter();
            this.tableAdapterManager = new WfaVendas.LP2DataSetTableAdapters.TableAdapterManager();
            this.pc_vendaTableAdapter = new WfaVendas.LP2DataSetTableAdapters.pc_vendaTableAdapter();
            this.codproTextBox = new System.Windows.Forms.TextBox();
            this.precounitTextBox = new System.Windows.Forms.TextBox();
            this.pc_itemvendaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxSubtotal = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pc_vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numvendaTextBox1 = new System.Windows.Forms.TextBox();
            this.datavendaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataentregaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.codcliTextBox = new System.Windows.Forms.TextBox();
            this.obsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pc_vendaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            codproLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            precounitLabel = new System.Windows.Forms.Label();
            numvendaLabel1 = new System.Windows.Forms.Label();
            datavendaLabel = new System.Windows.Forms.Label();
            dataentregaLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            codcliLabel = new System.Windows.Forms.Label();
            txtSubtotal = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_itemvendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_itemvendaDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_vendaBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_vendaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codproLabel
            // 
            codproLabel.AutoSize = true;
            codproLabel.Location = new System.Drawing.Point(33, 65);
            codproLabel.Name = "codproLabel";
            codproLabel.Size = new System.Drawing.Size(43, 13);
            codproLabel.TabIndex = 19;
            codproLabel.Text = "codpro:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(189, 65);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(63, 13);
            quantidadeLabel.TabIndex = 21;
            quantidadeLabel.Text = "quantidade:";
            // 
            // precounitLabel
            // 
            precounitLabel.AutoSize = true;
            precounitLabel.Location = new System.Drawing.Point(339, 65);
            precounitLabel.Name = "precounitLabel";
            precounitLabel.Size = new System.Drawing.Size(54, 13);
            precounitLabel.TabIndex = 23;
            precounitLabel.Text = "precounit:";
            // 
            // numvendaLabel1
            // 
            numvendaLabel1.AutoSize = true;
            numvendaLabel1.Location = new System.Drawing.Point(12, 34);
            numvendaLabel1.Name = "numvendaLabel1";
            numvendaLabel1.Size = new System.Drawing.Size(60, 13);
            numvendaLabel1.TabIndex = 25;
            numvendaLabel1.Text = "numvenda:";
            // 
            // datavendaLabel
            // 
            datavendaLabel.AutoSize = true;
            datavendaLabel.Location = new System.Drawing.Point(12, 60);
            datavendaLabel.Name = "datavendaLabel";
            datavendaLabel.Size = new System.Drawing.Size(61, 13);
            datavendaLabel.TabIndex = 27;
            datavendaLabel.Text = "datavenda:";
            // 
            // dataentregaLabel
            // 
            dataentregaLabel.AutoSize = true;
            dataentregaLabel.Location = new System.Drawing.Point(383, 63);
            dataentregaLabel.Name = "dataentregaLabel";
            dataentregaLabel.Size = new System.Drawing.Size(67, 13);
            dataentregaLabel.TabIndex = 29;
            dataentregaLabel.Text = "dataentrega:";
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.Location = new System.Drawing.Point(13, 100);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(27, 13);
            obsLabel.TabIndex = 33;
            obsLabel.Text = "obs:";
            // 
            // codcliLabel
            // 
            codcliLabel.AutoSize = true;
            codcliLabel.Location = new System.Drawing.Point(383, 26);
            codcliLabel.Name = "codcliLabel";
            codcliLabel.Size = new System.Drawing.Size(38, 13);
            codcliLabel.TabIndex = 31;
            codcliLabel.Text = "codcli:";
            // 
            // txtSubtotal
            // 
            txtSubtotal.AutoSize = true;
            txtSubtotal.Location = new System.Drawing.Point(487, 65);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new System.Drawing.Size(46, 13);
            txtSubtotal.TabIndex = 26;
            txtSubtotal.Text = "Subtotal";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Info;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSair.Location = new System.Drawing.Point(774, 26);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.SystemColors.Info;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnListar.Location = new System.Drawing.Point(668, 27);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 15;
            this.btnListar.Text = "&Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.SystemColors.Info;
            this.btnGravar.Enabled = false;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGravar.Location = new System.Drawing.Point(456, 27);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 13;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Info;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Location = new System.Drawing.Point(562, 27);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Info;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesquisar.Location = new System.Drawing.Point(350, 27);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.SystemColors.Info;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnApagar.Location = new System.Drawing.Point(244, 27);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 11;
            this.btnApagar.Text = "&Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Info;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditar.Location = new System.Drawing.Point(138, 27);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.SystemColors.Info;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIncluir.Location = new System.Drawing.Point(32, 26);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 9;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            // 
            // lP2DataSet
            // 
            this.lP2DataSet.DataSetName = "LP2DataSet";
            this.lP2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pc_itemvendaBindingSource
            // 
            this.pc_itemvendaBindingSource.DataMember = "pc_itemvenda";
            this.pc_itemvendaBindingSource.DataSource = this.lP2DataSet;
            // 
            // pc_itemvendaTableAdapter
            // 
            this.pc_itemvendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pc_clientesTableAdapter = null;
            this.tableAdapterManager.pc_itemvendaTableAdapter = this.pc_itemvendaTableAdapter;
            this.tableAdapterManager.pc_ProdutoTableAdapter = null;
            this.tableAdapterManager.pc_vendaTableAdapter = this.pc_vendaTableAdapter;
            this.tableAdapterManager.UpdateOrder = WfaVendas.LP2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pc_vendaTableAdapter
            // 
            this.pc_vendaTableAdapter.ClearBeforeFill = true;
            // 
            // codproTextBox
            // 
            this.codproTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_itemvendaBindingSource, "codpro", true));
            this.codproTextBox.Location = new System.Drawing.Point(35, 87);
            this.codproTextBox.Name = "codproTextBox";
            this.codproTextBox.Size = new System.Drawing.Size(100, 20);
            this.codproTextBox.TabIndex = 20;
            // 
            // precounitTextBox
            // 
            this.precounitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_itemvendaBindingSource, "precounit", true));
            this.precounitTextBox.Location = new System.Drawing.Point(342, 87);
            this.precounitTextBox.Name = "precounitTextBox";
            this.precounitTextBox.ReadOnly = true;
            this.precounitTextBox.Size = new System.Drawing.Size(100, 20);
            this.precounitTextBox.TabIndex = 24;
            // 
            // pc_itemvendaDataGridView
            // 
            this.pc_itemvendaDataGridView.AllowUserToAddRows = false;
            this.pc_itemvendaDataGridView.AllowUserToDeleteRows = false;
            this.pc_itemvendaDataGridView.AllowUserToResizeRows = false;
            this.pc_itemvendaDataGridView.AutoGenerateColumns = false;
            this.pc_itemvendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pc_itemvendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.pc_itemvendaDataGridView.DataSource = this.pc_itemvendaBindingSource;
            this.pc_itemvendaDataGridView.Location = new System.Drawing.Point(42, 457);
            this.pc_itemvendaDataGridView.MultiSelect = false;
            this.pc_itemvendaDataGridView.Name = "pc_itemvendaDataGridView";
            this.pc_itemvendaDataGridView.ReadOnly = true;
            this.pc_itemvendaDataGridView.Size = new System.Drawing.Size(896, 104);
            this.pc_itemvendaDataGridView.TabIndex = 24;
            this.pc_itemvendaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pc_itemvendaDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "numvenda";
            this.dataGridViewTextBoxColumn1.HeaderText = "numvenda";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codpro";
            this.dataGridViewTextBoxColumn2.HeaderText = "codpro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "quantidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "precounit";
            this.dataGridViewTextBoxColumn4.HeaderText = "precounit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.txtBoxSubtotal);
            this.groupBox1.Controls.Add(txtSubtotal);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.precounitTextBox);
            this.groupBox1.Controls.Add(precounitLabel);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.btnGravar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(quantidadeLabel);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(codproLabel);
            this.groupBox1.Controls.Add(this.btnApagar);
            this.groupBox1.Controls.Add(this.codproTextBox);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnIncluir);
            this.groupBox1.Location = new System.Drawing.Point(42, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 124);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtBoxSubtotal
            // 
            this.txtBoxSubtotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_itemvendaBindingSource, "precounit", true));
            this.txtBoxSubtotal.Location = new System.Drawing.Point(490, 87);
            this.txtBoxSubtotal.Name = "txtBoxSubtotal";
            this.txtBoxSubtotal.ReadOnly = true;
            this.txtBoxSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSubtotal.TabIndex = 27;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(192, 88);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 25;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pc_vendaBindingSource
            // 
            this.pc_vendaBindingSource.DataMember = "pc_venda";
            this.pc_vendaBindingSource.DataSource = this.lP2DataSet;
            // 
            // numvendaTextBox1
            // 
            this.numvendaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_vendaBindingSource, "numvenda", true));
            this.numvendaTextBox1.Location = new System.Drawing.Point(81, 27);
            this.numvendaTextBox1.Name = "numvendaTextBox1";
            this.numvendaTextBox1.Size = new System.Drawing.Size(118, 20);
            this.numvendaTextBox1.TabIndex = 26;
            // 
            // datavendaDateTimePicker
            // 
            this.datavendaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.datavendaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pc_vendaBindingSource, "datavenda", true));
            this.datavendaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datavendaDateTimePicker.Location = new System.Drawing.Point(81, 60);
            this.datavendaDateTimePicker.Name = "datavendaDateTimePicker";
            this.datavendaDateTimePicker.Size = new System.Drawing.Size(118, 20);
            this.datavendaDateTimePicker.TabIndex = 28;
            // 
            // dataentregaDateTimePicker
            // 
            this.dataentregaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dataentregaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pc_vendaBindingSource, "dataentrega", true));
            this.dataentregaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataentregaDateTimePicker.Location = new System.Drawing.Point(456, 57);
            this.dataentregaDateTimePicker.Name = "dataentregaDateTimePicker";
            this.dataentregaDateTimePicker.Size = new System.Drawing.Size(118, 20);
            this.dataentregaDateTimePicker.TabIndex = 30;
            // 
            // codcliTextBox
            // 
            this.codcliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_vendaBindingSource, "codcli", true));
            this.codcliTextBox.Location = new System.Drawing.Point(452, 23);
            this.codcliTextBox.Name = "codcliTextBox";
            this.codcliTextBox.Size = new System.Drawing.Size(296, 20);
            this.codcliTextBox.TabIndex = 32;
            // 
            // obsTextBox
            // 
            this.obsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_vendaBindingSource, "obs", true));
            this.obsTextBox.Location = new System.Drawing.Point(46, 100);
            this.obsTextBox.Multiline = true;
            this.obsTextBox.Name = "obsTextBox";
            this.obsTextBox.Size = new System.Drawing.Size(821, 69);
            this.obsTextBox.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(numvendaLabel1);
            this.groupBox2.Controls.Add(this.obsTextBox);
            this.groupBox2.Controls.Add(this.numvendaTextBox1);
            this.groupBox2.Controls.Add(obsLabel);
            this.groupBox2.Controls.Add(datavendaLabel);
            this.groupBox2.Controls.Add(this.codcliTextBox);
            this.groupBox2.Controls.Add(this.datavendaDateTimePicker);
            this.groupBox2.Controls.Add(codcliLabel);
            this.groupBox2.Controls.Add(dataentregaLabel);
            this.groupBox2.Controls.Add(this.dataentregaDateTimePicker);
            this.groupBox2.Location = new System.Drawing.Point(42, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(896, 175);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // pc_vendaDataGridView
            // 
            this.pc_vendaDataGridView.AllowUserToAddRows = false;
            this.pc_vendaDataGridView.AllowUserToDeleteRows = false;
            this.pc_vendaDataGridView.AutoGenerateColumns = false;
            this.pc_vendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pc_vendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.pc_vendaDataGridView.DataSource = this.pc_vendaBindingSource;
            this.pc_vendaDataGridView.Location = new System.Drawing.Point(42, 197);
            this.pc_vendaDataGridView.Name = "pc_vendaDataGridView";
            this.pc_vendaDataGridView.ReadOnly = true;
            this.pc_vendaDataGridView.Size = new System.Drawing.Size(896, 78);
            this.pc_vendaDataGridView.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "numvenda";
            this.dataGridViewTextBoxColumn5.HeaderText = "numvenda";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "datavenda";
            this.dataGridViewTextBoxColumn6.HeaderText = "datavenda";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "dataentrega";
            this.dataGridViewTextBoxColumn7.HeaderText = "dataentrega";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "codcli";
            this.dataGridViewTextBoxColumn8.HeaderText = "codcli";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "obs";
            this.dataGridViewTextBoxColumn9.HeaderText = "obs";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // txtTotal
            // 
            this.txtTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_itemvendaBindingSource, "precounit", true));
            this.txtTotal.Location = new System.Drawing.Point(626, 87);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(623, 65);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(31, 13);
            label1.TabIndex = 28;
            label1.Text = "Total";
            // 
            // FrmCadVendaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.pc_vendaDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pc_itemvendaDataGridView);
            this.Name = "FrmCadVendaClientes";
            this.Text = "FrmCadVendaClientes";
            this.Load += new System.EventHandler(this.FrmCadVendaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_itemvendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_itemvendaDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_vendaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_vendaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnIncluir;
        private LP2DataSet lP2DataSet;
        private System.Windows.Forms.BindingSource pc_itemvendaBindingSource;
        private LP2DataSetTableAdapters.pc_itemvendaTableAdapter pc_itemvendaTableAdapter;
        private LP2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox codproTextBox;
        private System.Windows.Forms.TextBox precounitTextBox;
        private System.Windows.Forms.DataGridView pc_itemvendaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox groupBox1;
        private LP2DataSetTableAdapters.pc_vendaTableAdapter pc_vendaTableAdapter;
        private System.Windows.Forms.BindingSource pc_vendaBindingSource;
        private System.Windows.Forms.TextBox numvendaTextBox1;
        private System.Windows.Forms.DateTimePicker datavendaDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataentregaDateTimePicker;
        private System.Windows.Forms.TextBox codcliTextBox;
        private System.Windows.Forms.TextBox obsTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView pc_vendaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtBoxSubtotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}