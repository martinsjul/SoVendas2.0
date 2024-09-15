namespace WfaVendas
{
    partial class FrmCadClientes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codcliLabel1;
            System.Windows.Forms.Label nomeLabel1;
            System.Windows.Forms.Label enderecoLabel1;
            System.Windows.Forms.Label cidadeLabel1;
            System.Windows.Forms.Label bairroLabel1;
            System.Windows.Forms.Label uFLabel1;
            System.Windows.Forms.Label cEPLabel1;
            System.Windows.Forms.Label telefoneLabel1;
            System.Windows.Forms.Label datanascLabel1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadClientes));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pc_clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lP2DataSet = new WfaVendas.LP2DataSet();
            this.txtCodcli = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.mskUF = new System.Windows.Forms.MaskedTextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dtpDatanasc = new System.Windows.Forms.DateTimePicker();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pc_clientesTableAdapter = new WfaVendas.LP2DataSetTableAdapters.pc_clientesTableAdapter();
            this.tableAdapterManager = new WfaVendas.LP2DataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            codcliLabel1 = new System.Windows.Forms.Label();
            nomeLabel1 = new System.Windows.Forms.Label();
            enderecoLabel1 = new System.Windows.Forms.Label();
            cidadeLabel1 = new System.Windows.Forms.Label();
            bairroLabel1 = new System.Windows.Forms.Label();
            uFLabel1 = new System.Windows.Forms.Label();
            cEPLabel1 = new System.Windows.Forms.Label();
            telefoneLabel1 = new System.Windows.Forms.Label();
            datanascLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // codcliLabel1
            // 
            codcliLabel1.AutoSize = true;
            codcliLabel1.Location = new System.Drawing.Point(7, 28);
            codcliLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codcliLabel1.Name = "codcliLabel1";
            codcliLabel1.Size = new System.Drawing.Size(68, 20);
            codcliLabel1.TabIndex = 20;
            codcliLabel1.Text = "Código:";
            // 
            // nomeLabel1
            // 
            nomeLabel1.AutoSize = true;
            nomeLabel1.Location = new System.Drawing.Point(330, 29);
            nomeLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel1.Name = "nomeLabel1";
            nomeLabel1.Size = new System.Drawing.Size(58, 20);
            nomeLabel1.TabIndex = 22;
            nomeLabel1.Text = "Nome:";
            // 
            // enderecoLabel1
            // 
            enderecoLabel1.AutoSize = true;
            enderecoLabel1.Location = new System.Drawing.Point(2, 101);
            enderecoLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            enderecoLabel1.Name = "enderecoLabel1";
            enderecoLabel1.Size = new System.Drawing.Size(83, 20);
            enderecoLabel1.TabIndex = 24;
            enderecoLabel1.Text = "Endereço:";
            // 
            // cidadeLabel1
            // 
            cidadeLabel1.AutoSize = true;
            cidadeLabel1.Location = new System.Drawing.Point(509, 97);
            cidadeLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cidadeLabel1.Name = "cidadeLabel1";
            cidadeLabel1.Size = new System.Drawing.Size(66, 20);
            cidadeLabel1.TabIndex = 26;
            cidadeLabel1.Text = "Cidade:";
            // 
            // bairroLabel1
            // 
            bairroLabel1.AutoSize = true;
            bairroLabel1.Location = new System.Drawing.Point(2, 172);
            bairroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bairroLabel1.Name = "bairroLabel1";
            bairroLabel1.Size = new System.Drawing.Size(59, 20);
            bairroLabel1.TabIndex = 28;
            bairroLabel1.Text = "Bairro:";
            // 
            // uFLabel1
            // 
            uFLabel1.AutoSize = true;
            uFLabel1.Location = new System.Drawing.Point(447, 175);
            uFLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            uFLabel1.Name = "uFLabel1";
            uFLabel1.Size = new System.Drawing.Size(32, 20);
            uFLabel1.TabIndex = 30;
            uFLabel1.Text = "UF:";
            // 
            // cEPLabel1
            // 
            cEPLabel1.AutoSize = true;
            cEPLabel1.Location = new System.Drawing.Point(639, 173);
            cEPLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cEPLabel1.Name = "cEPLabel1";
            cEPLabel1.Size = new System.Drawing.Size(41, 20);
            cEPLabel1.TabIndex = 32;
            cEPLabel1.Text = "CEP:";
            // 
            // telefoneLabel1
            // 
            telefoneLabel1.AutoSize = true;
            telefoneLabel1.Location = new System.Drawing.Point(2, 245);
            telefoneLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefoneLabel1.Name = "telefoneLabel1";
            telefoneLabel1.Size = new System.Drawing.Size(79, 20);
            telefoneLabel1.TabIndex = 34;
            telefoneLabel1.Text = "Telefone:";
            // 
            // datanascLabel1
            // 
            datanascLabel1.AutoSize = true;
            datanascLabel1.Location = new System.Drawing.Point(287, 244);
            datanascLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            datanascLabel1.Name = "datanascLabel1";
            datanascLabel1.Size = new System.Drawing.Size(163, 20);
            datanascLabel1.TabIndex = 36;
            datanascLabel1.Text = "Data de Nascimento";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvClientes.DataSource = this.pc_clientesBindingSource;
            this.dgvClientes.Location = new System.Drawing.Point(185, 361);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(1051, 222);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            this.dgvClientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvClientes_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codcli";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn3.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "bairro";
            this.dataGridViewTextBoxColumn5.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UF";
            this.dataGridViewTextBoxColumn6.HeaderText = "UF";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 65;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CEP";
            this.dataGridViewTextBoxColumn7.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "telefone";
            this.dataGridViewTextBoxColumn8.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "datanasc";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn9.HeaderText = "Data Nasc.";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 120;
            // 
            // pc_clientesBindingSource
            // 
            this.pc_clientesBindingSource.DataMember = "pc_clientes";
            this.pc_clientesBindingSource.DataSource = this.lP2DataSet;
            // 
            // lP2DataSet
            // 
            this.lP2DataSet.DataSetName = "LP2DataSet";
            this.lP2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCodcli
            // 
            this.txtCodcli.Enabled = false;
            this.txtCodcli.Location = new System.Drawing.Point(101, 22);
            this.txtCodcli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodcli.Name = "txtCodcli";
            this.txtCodcli.ReadOnly = true;
            this.txtCodcli.Size = new System.Drawing.Size(89, 27);
            this.txtCodcli.TabIndex = 21;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(423, 24);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(386, 27);
            this.txtNome.TabIndex = 23;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(96, 93);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(386, 27);
            this.txtEndereco.TabIndex = 25;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(602, 96);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(297, 27);
            this.txtCidade.TabIndex = 27;
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(96, 166);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(297, 27);
            this.txtBairro.TabIndex = 29;
            // 
            // mskUF
            // 
            this.mskUF.Enabled = false;
            this.mskUF.Location = new System.Drawing.Point(540, 166);
            this.mskUF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskUF.Mask = ">LL";
            this.mskUF.Name = "mskUF";
            this.mskUF.Size = new System.Drawing.Size(45, 27);
            this.mskUF.TabIndex = 31;
            this.mskUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskCEP
            // 
            this.mskCEP.Enabled = false;
            this.mskCEP.Location = new System.Drawing.Point(705, 169);
            this.mskCEP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(90, 27);
            this.mskCEP.TabIndex = 33;
            this.mskCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Enabled = false;
            this.mskTelefone.Location = new System.Drawing.Point(96, 241);
            this.mskTelefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskTelefone.Mask = "(00) 90000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(126, 27);
            this.mskTelefone.TabIndex = 35;
            this.mskTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.telefoneMaskedTextBox_MaskInputRejected);
            // 
            // dtpDatanasc
            // 
            this.dtpDatanasc.CustomFormat = "dd/MM/yyyy";
            this.dtpDatanasc.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pc_clientesBindingSource, "datanasc", true));
            this.dtpDatanasc.Enabled = false;
            this.dtpDatanasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatanasc.Location = new System.Drawing.Point(483, 241);
            this.dtpDatanasc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDatanasc.Name = "dtpDatanasc";
            this.dtpDatanasc.Size = new System.Drawing.Size(143, 27);
            this.dtpDatanasc.TabIndex = 37;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.Location = new System.Drawing.Point(46, 33);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(7, 6, 4, 5);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(67, 58);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(46, 106);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(7, 6, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(67, 58);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Image = ((System.Drawing.Image)(resources.GetObject("btnApagar.Image")));
            this.btnApagar.Location = new System.Drawing.Point(46, 179);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(7, 6, 4, 5);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(67, 58);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(46, 252);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(7, 6, 4, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(67, 58);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(46, 398);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(7, 6, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(67, 58);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.Location = new System.Drawing.Point(46, 325);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(7, 6, 4, 5);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(67, 58);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Image")));
            this.btnListar.Location = new System.Drawing.Point(46, 471);
            this.btnListar.Margin = new System.Windows.Forms.Padding(7, 6, 4, 5);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(67, 58);
            this.btnListar.TabIndex = 7;
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(46, 544);
            this.btnSair.Margin = new System.Windows.Forms.Padding(7, 6, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(67, 58);
            this.btnSair.TabIndex = 8;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button8_Click);
            // 
            // pc_clientesTableAdapter
            // 
            this.pc_clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pc_clientesTableAdapter = this.pc_clientesTableAdapter;
            this.tableAdapterManager.pc_itemvendaTableAdapter = null;
            this.tableAdapterManager.pc_ProdutoTableAdapter = null;
            this.tableAdapterManager.pc_vendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WfaVendas.LP2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox1.Controls.Add(this.btnIncluir);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.btnApagar);
            this.groupBox1.Controls.Add(this.btnGravar);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Location = new System.Drawing.Point(-9, -12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(154, 729);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(codcliLabel1);
            this.groupBox2.Controls.Add(this.dtpDatanasc);
            this.groupBox2.Controls.Add(this.txtCodcli);
            this.groupBox2.Controls.Add(datanascLabel1);
            this.groupBox2.Controls.Add(nomeLabel1);
            this.groupBox2.Controls.Add(this.mskTelefone);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(telefoneLabel1);
            this.groupBox2.Controls.Add(enderecoLabel1);
            this.groupBox2.Controls.Add(this.mskCEP);
            this.groupBox2.Controls.Add(this.txtEndereco);
            this.groupBox2.Controls.Add(cEPLabel1);
            this.groupBox2.Controls.Add(cidadeLabel1);
            this.groupBox2.Controls.Add(this.mskUF);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(uFLabel1);
            this.groupBox2.Controls.Add(bairroLabel1);
            this.groupBox2.Controls.Add(this.txtBairro);
            this.groupBox2.Location = new System.Drawing.Point(185, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1051, 290);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // FrmCadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 608);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvClientes);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadClientes";
            this.Text = "Cadastro de Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadClientes_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LP2DataSet lP2DataSet;
        private System.Windows.Forms.BindingSource pc_clientesBindingSource;
        private LP2DataSetTableAdapters.pc_clientesTableAdapter pc_clientesTableAdapter;
        private LP2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtCodcli;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.MaskedTextBox mskUF;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.DateTimePicker dtpDatanasc;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

