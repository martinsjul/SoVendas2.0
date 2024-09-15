namespace WfaVendas
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeSeuTemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeSeuTemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarNaHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarNaVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarNaCascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.sstStatus = new System.Windows.Forms.StatusStrip();
            this.sslTexto = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.mnuMenu.SuspendLayout();
            this.sstStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatoriosToolStripMenuItem,
            this.relatoriosToolStripMenuItem1,
            this.janelasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.MdiWindowListItem = this.janelasToolStripMenuItem;
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.mnuMenu.Size = new System.Drawing.Size(1200, 28);
            this.mnuMenu.TabIndex = 1;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClientesToolStripMenuItem,
            this.cadastroDeVendasToolStripMenuItem,
            this.cadastroDeProdutosToolStripMenuItem,
            this.cadastroDeSeuTemasToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.relatoriosToolStripMenuItem.Text = "&Arquivo";
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            this.cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            this.cadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.cadastroDeClientesToolStripMenuItem.Text = "Cadastro de &Clientes";
            this.cadastroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeClientesToolStripMenuItem_Click);
            // 
            // cadastroDeVendasToolStripMenuItem
            // 
            this.cadastroDeVendasToolStripMenuItem.Name = "cadastroDeVendasToolStripMenuItem";
            this.cadastroDeVendasToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.cadastroDeVendasToolStripMenuItem.Text = "Cadastro de &Vendas";
            this.cadastroDeVendasToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeVendasToolStripMenuItem_Click);
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de &Produtos";
            // 
            // cadastroDeSeuTemasToolStripMenuItem
            // 
            this.cadastroDeSeuTemasToolStripMenuItem.Name = "cadastroDeSeuTemasToolStripMenuItem";
            this.cadastroDeSeuTemasToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.cadastroDeSeuTemasToolStripMenuItem.Text = "Cadastro de &Seu Tema";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(258, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // relatoriosToolStripMenuItem1
            // 
            this.relatoriosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatorioDeClientesToolStripMenuItem,
            this.relatorioDeVendasToolStripMenuItem,
            this.relatorioDeProdutosToolStripMenuItem,
            this.relatorioDeSeuTemaToolStripMenuItem,
            this.toolStripSeparator2});
            this.relatoriosToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.relatoriosToolStripMenuItem1.Name = "relatoriosToolStripMenuItem1";
            this.relatoriosToolStripMenuItem1.Size = new System.Drawing.Size(100, 24);
            this.relatoriosToolStripMenuItem1.Text = "&Relatorios";
            // 
            // relatorioDeClientesToolStripMenuItem
            // 
            this.relatorioDeClientesToolStripMenuItem.Name = "relatorioDeClientesToolStripMenuItem";
            this.relatorioDeClientesToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.relatorioDeClientesToolStripMenuItem.Text = "Relatório de &Clientes";
            // 
            // relatorioDeVendasToolStripMenuItem
            // 
            this.relatorioDeVendasToolStripMenuItem.Name = "relatorioDeVendasToolStripMenuItem";
            this.relatorioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.relatorioDeVendasToolStripMenuItem.Text = "Relatório de &Vendas";
            // 
            // relatorioDeProdutosToolStripMenuItem
            // 
            this.relatorioDeProdutosToolStripMenuItem.Name = "relatorioDeProdutosToolStripMenuItem";
            this.relatorioDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.relatorioDeProdutosToolStripMenuItem.Text = "Relatório de &Produtos";
            // 
            // relatorioDeSeuTemaToolStripMenuItem
            // 
            this.relatorioDeSeuTemaToolStripMenuItem.Name = "relatorioDeSeuTemaToolStripMenuItem";
            this.relatorioDeSeuTemaToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.relatorioDeSeuTemaToolStripMenuItem.Text = "Relatório de &Seu Tema";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(261, 6);
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.organizarNaHorizontalToolStripMenuItem,
            this.organizarNaVerticalToolStripMenuItem,
            this.organizarNaCascataToolStripMenuItem});
            this.janelasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.janelasToolStripMenuItem.Text = "&Janelas";
            // 
            // organizarNaHorizontalToolStripMenuItem
            // 
            this.organizarNaHorizontalToolStripMenuItem.Name = "organizarNaHorizontalToolStripMenuItem";
            this.organizarNaHorizontalToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.organizarNaHorizontalToolStripMenuItem.Text = "Organizar na &Horizontal";
            // 
            // organizarNaVerticalToolStripMenuItem
            // 
            this.organizarNaVerticalToolStripMenuItem.Name = "organizarNaVerticalToolStripMenuItem";
            this.organizarNaVerticalToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.organizarNaVerticalToolStripMenuItem.Text = "Organizar na &Vertical";
            // 
            // organizarNaCascataToolStripMenuItem
            // 
            this.organizarNaCascataToolStripMenuItem.Name = "organizarNaCascataToolStripMenuItem";
            this.organizarNaCascataToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.organizarNaCascataToolStripMenuItem.Text = "Organizar na &Cascata";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.ajudaToolStripMenuItem.Text = "Aj&uda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sobreToolStripMenuItem.Text = "&Sobre...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1200, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // sstStatus
            // 
            this.sstStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sstStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslTexto,
            this.sslHora});
            this.sstStatus.Location = new System.Drawing.Point(0, 664);
            this.sstStatus.Name = "sstStatus";
            this.sstStatus.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.sstStatus.Size = new System.Drawing.Size(1200, 28);
            this.sstStatus.TabIndex = 3;
            // 
            // sslTexto
            // 
            this.sslTexto.AutoSize = false;
            this.sslTexto.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslTexto.Name = "sslTexto";
            this.sslTexto.Size = new System.Drawing.Size(998, 22);
            this.sslTexto.Spring = true;
            this.sslTexto.Text = "toolStripStatusLabel1";
            // 
            // sslHora
            // 
            this.sslHora.AutoSize = false;
            this.sslHora.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslHora.Name = "sslHora";
            this.sslHora.Size = new System.Drawing.Size(180, 22);
            this.sslHora.Text = "toolStripStatusLabel2";
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Interval = 1000;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.sstStatus);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mnuMenu);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMenu";
            this.Text = "Controle de Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.sstStatus.ResumeLayout(false);
            this.sstStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip sstStatus;
        private System.Windows.Forms.ToolStripStatusLabel sslTexto;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.ToolStripStatusLabel sslHora;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeSeuTemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeSeuTemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem organizarNaHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarNaVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarNaCascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}