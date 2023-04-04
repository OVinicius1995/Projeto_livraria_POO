namespace livraria
{
    partial class frmPai
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPai));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tooldica = new System.Windows.Forms.ToolTip(this.components);
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnAtualiza = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.txtClienteVenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mTBValor = new System.Windows.Forms.MaskedTextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblVenda = new System.Windows.Forms.Label();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.cmbPesquisa = new System.Windows.Forms.ComboBox();
            this.lblEditora = new System.Windows.Forms.Label();
            this.lblValo = new System.Windows.Forms.Label();
            this.lblQtde = new System.Windows.Forms.Label();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.lblNacionalidade = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.dtgVenda = new System.Windows.Forms.DataGridView();
            this.atualiza = new System.Windows.Forms.Timer(this.components);
            this.timAtualiza = new System.Windows.Forms.Timer(this.components);
            this.Timhoras = new System.Windows.Forms.Timer(this.components);
            this.pnlPerfil = new System.Windows.Forms.Panel();
            this.lblMat = new System.Windows.Forms.Label();
            this.lblNow = new System.Windows.Forms.Label();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnBuscarClientes = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlFundo.SuspendLayout();
            this.gpbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenda)).BeginInit();
            this.pnlPerfil.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.funcionariosToolStripMenuItem,
            this.toolStripMenuItem2,
            this.livrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 113);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.AutoToolTip = true;
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clientesToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(181, 109);
            this.clientesToolStripMenuItem.Text = "Clientes           ";
            this.clientesToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.clientesToolStripMenuItem.ToolTipText = "Cadastra cliente";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Showcard Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(27, 109);
            this.toolStripMenuItem1.Text = "______________";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripMenuItem1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionariosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.funcionariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionariosToolStripMenuItem.Image")));
            this.funcionariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(178, 109);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoToolTip = true;
            this.toolStripMenuItem2.Checked = true;
            this.toolStripMenuItem2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Showcard Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(27, 109);
            this.toolStripMenuItem2.Text = "______________";
            this.toolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripMenuItem2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livrosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.livrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("livrosToolStripMenuItem.Image")));
            this.livrosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(134, 109);
            this.livrosToolStripMenuItem.Text = "Livros";
            this.livrosToolStripMenuItem.Click += new System.EventHandler(this.livrosToolStripMenuItem_Click_1);
            // 
            // tooldica
            // 
            this.tooldica.AutoPopDelay = 5000;
            this.tooldica.BackColor = System.Drawing.Color.Red;
            this.tooldica.ForeColor = System.Drawing.Color.Red;
            this.tooldica.InitialDelay = 300;
            this.tooldica.IsBalloon = true;
            this.tooldica.ReshowDelay = 100;
            this.tooldica.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.tooldica.ToolTipTitle = "Info";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.BackgroundImage")));
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisa.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(225, 15);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(126, 41);
            this.btnPesquisa.TabIndex = 8;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooldica.SetToolTip(this.btnPesquisa, "Realizar pesquisa de livros.");
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtVenda
            // 
            this.txtVenda.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenda.Location = new System.Drawing.Point(293, 209);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(100, 23);
            this.txtVenda.TabIndex = 10;
            this.txtVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tooldica.SetToolTip(this.txtVenda, "Somente números");
            this.txtVenda.TextChanged += new System.EventHandler(this.txtVenda_TextChanged);
            this.txtVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVenda_KeyPress);
            // 
            // btnVenda
            // 
            this.btnVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVenda.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnVenda.Image")));
            this.btnVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenda.Location = new System.Drawing.Point(405, 3);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(111, 47);
            this.btnVenda.TabIndex = 15;
            this.btnVenda.Text = "Venda";
            this.btnVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooldica.SetToolTip(this.btnVenda, "Realiza venda");
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtualiza.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualiza.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAtualiza.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualiza.Image")));
            this.btnAtualiza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualiza.Location = new System.Drawing.Point(911, 3);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(121, 47);
            this.btnAtualiza.TabIndex = 17;
            this.btnAtualiza.Text = "Atualiza";
            this.btnAtualiza.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooldica.SetToolTip(this.btnAtualiza, "Os dados sao atualizados a cada 20 segundos");
            this.btnAtualiza.UseVisualStyleBackColor = true;
            this.btnAtualiza.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(7, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(96, 47);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooldica.SetToolTip(this.btnSair, "Sair da aplicação");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNovo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNovo.Location = new System.Drawing.Point(653, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(81, 47);
            this.btnNovo.TabIndex = 16;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tooldica.SetToolTip(this.btnNovo, "Cadastrar um novo livro");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Size = new System.Drawing.Size(1037, 434);
            this.shapeContainer1.TabIndex = 13;
            this.shapeContainer1.TabStop = false;
            // 
            // pnlFundo
            // 
            this.pnlFundo.Controls.Add(this.btnBuscarClientes);
            this.pnlFundo.Controls.Add(this.txtClienteVenda);
            this.pnlFundo.Controls.Add(this.label1);
            this.pnlFundo.Controls.Add(this.mTBValor);
            this.pnlFundo.Controls.Add(this.txtMatricula);
            this.pnlFundo.Controls.Add(this.lblMatricula);
            this.pnlFundo.Controls.Add(this.lblVenda);
            this.pnlFundo.Controls.Add(this.txtVenda);
            this.pnlFundo.Controls.Add(this.gpbPesquisa);
            this.pnlFundo.Controls.Add(this.lblEditora);
            this.pnlFundo.Controls.Add(this.lblValo);
            this.pnlFundo.Controls.Add(this.lblQtde);
            this.pnlFundo.Controls.Add(this.lblClassificacao);
            this.pnlFundo.Controls.Add(this.lblNacionalidade);
            this.pnlFundo.Controls.Add(this.lblAutor);
            this.pnlFundo.Controls.Add(this.lblNome);
            this.pnlFundo.Controls.Add(this.lblIsbn);
            this.pnlFundo.Controls.Add(this.txtNacionalidade);
            this.pnlFundo.Controls.Add(this.txtAutor);
            this.pnlFundo.Controls.Add(this.txtNome);
            this.pnlFundo.Controls.Add(this.txtClassificacao);
            this.pnlFundo.Controls.Add(this.txtValor);
            this.pnlFundo.Controls.Add(this.txtEditora);
            this.pnlFundo.Controls.Add(this.txtIsbn);
            this.pnlFundo.Controls.Add(this.txtQtde);
            this.pnlFundo.Controls.Add(this.dtgVenda);
            this.pnlFundo.Location = new System.Drawing.Point(4, 116);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(1028, 262);
            this.pnlFundo.TabIndex = 15;
            // 
            // txtClienteVenda
            // 
            this.txtClienteVenda.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteVenda.Location = new System.Drawing.Point(150, 83);
            this.txtClienteVenda.Name = "txtClienteVenda";
            this.txtClienteVenda.Size = new System.Drawing.Size(152, 23);
            this.txtClienteVenda.TabIndex = 1;
            this.txtClienteVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tooldica.SetToolTip(this.txtClienteVenda, "Tecle F2 para abrir a lista de clientes.");
            this.txtClienteVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClienteVenda_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(8, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 107;
            this.label1.Text = "Selecione o cliente:";
            // 
            // mTBValor
            // 
            this.mTBValor.Enabled = false;
            this.mTBValor.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTBValor.Location = new System.Drawing.Point(291, 237);
            this.mTBValor.Mask = "$0000,00";
            this.mTBValor.Name = "mTBValor";
            this.mTBValor.ReadOnly = true;
            this.mTBValor.Size = new System.Drawing.Size(100, 23);
            this.mTBValor.TabIndex = 13;
            this.mTBValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(84, 126);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.ReadOnly = true;
            this.txtMatricula.ShortcutsEnabled = false;
            this.txtMatricula.Size = new System.Drawing.Size(100, 23);
            this.txtMatricula.TabIndex = 3;
            this.txtMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.BackColor = System.Drawing.SystemColors.Control;
            this.lblMatricula.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMatricula.Location = new System.Drawing.Point(4, 129);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(81, 19);
            this.lblMatricula.TabIndex = 104;
            this.lblMatricula.Text = "Matricula:";
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.BackColor = System.Drawing.SystemColors.Control;
            this.lblVenda.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenda.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVenda.Location = new System.Drawing.Point(226, 211);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(58, 19);
            this.lblVenda.TabIndex = 100;
            this.lblVenda.Text = "Venda:";
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.lblEscolha);
            this.gpbPesquisa.Controls.Add(this.btnPesquisa);
            this.gpbPesquisa.Controls.Add(this.cmbPesquisa);
            this.gpbPesquisa.Location = new System.Drawing.Point(8, -3);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(385, 69);
            this.gpbPesquisa.TabIndex = 94;
            this.gpbPesquisa.TabStop = false;
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.BackColor = System.Drawing.SystemColors.Control;
            this.lblEscolha.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEscolha.Location = new System.Drawing.Point(7, 9);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(191, 19);
            this.lblEscolha.TabIndex = 9;
            this.lblEscolha.Text = "Escolha um tipo de busca";
            // 
            // cmbPesquisa
            // 
            this.cmbPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPesquisa.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPesquisa.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cmbPesquisa.FormattingEnabled = true;
            this.cmbPesquisa.Items.AddRange(new object[] {
            "Nome",
            "Autor",
            "Editora",
            "Nacionalidade",
            "Classificacoes"});
            this.cmbPesquisa.Location = new System.Drawing.Point(12, 34);
            this.cmbPesquisa.Name = "cmbPesquisa";
            this.cmbPesquisa.Size = new System.Drawing.Size(186, 23);
            this.cmbPesquisa.TabIndex = 18;
            this.cmbPesquisa.SelectedIndexChanged += new System.EventHandler(this.cmbPesquisa_SelectedIndexChanged);
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.BackColor = System.Drawing.SystemColors.Control;
            this.lblEditora.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditora.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEditora.Location = new System.Drawing.Point(19, 239);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(64, 19);
            this.lblEditora.TabIndex = 98;
            this.lblEditora.Text = "Editora:";
            // 
            // lblValo
            // 
            this.lblValo.AutoSize = true;
            this.lblValo.BackColor = System.Drawing.SystemColors.Control;
            this.lblValo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblValo.Location = new System.Drawing.Point(231, 239);
            this.lblValo.Name = "lblValo";
            this.lblValo.Size = new System.Drawing.Size(51, 19);
            this.lblValo.TabIndex = 97;
            this.lblValo.Text = "Valor:";
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.BackColor = System.Drawing.SystemColors.Control;
            this.lblQtde.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblQtde.Location = new System.Drawing.Point(226, 184);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(58, 19);
            this.lblQtde.TabIndex = 96;
            this.lblQtde.Text = "Q.t.d.e:";
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.BackColor = System.Drawing.SystemColors.Control;
            this.lblClassificacao.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassificacao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblClassificacao.Location = new System.Drawing.Point(185, 157);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(108, 19);
            this.lblClassificacao.TabIndex = 95;
            this.lblClassificacao.Text = "Classificação:";
            // 
            // lblNacionalidade
            // 
            this.lblNacionalidade.AutoSize = true;
            this.lblNacionalidade.BackColor = System.Drawing.SystemColors.Control;
            this.lblNacionalidade.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidade.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNacionalidade.Location = new System.Drawing.Point(183, 126);
            this.lblNacionalidade.Name = "lblNacionalidade";
            this.lblNacionalidade.Size = new System.Drawing.Size(115, 19);
            this.lblNacionalidade.TabIndex = 94;
            this.lblNacionalidade.Text = "Nacionalidade:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.SystemColors.Control;
            this.lblAutor.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAutor.Location = new System.Drawing.Point(19, 213);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(52, 19);
            this.lblAutor.TabIndex = 93;
            this.lblAutor.Text = "Autor:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.Control;
            this.lblNome.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNome.Location = new System.Drawing.Point(19, 186);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 19);
            this.lblNome.TabIndex = 92;
            this.lblNome.Text = "Nome:";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.BackColor = System.Drawing.SystemColors.Control;
            this.lblIsbn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsbn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblIsbn.Location = new System.Drawing.Point(22, 159);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(49, 19);
            this.lblIsbn.TabIndex = 91;
            this.lblIsbn.Text = "ISBN:";
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Enabled = false;
            this.txtNacionalidade.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacionalidade.Location = new System.Drawing.Point(296, 125);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(100, 23);
            this.txtNacionalidade.TabIndex = 4;
            this.txtNacionalidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAutor
            // 
            this.txtAutor.Enabled = false;
            this.txtAutor.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(83, 212);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 23);
            this.txtAutor.TabIndex = 9;
            this.txtAutor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(83, 185);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 7;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.Enabled = false;
            this.txtClassificacao.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassificacao.Location = new System.Drawing.Point(293, 153);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(100, 23);
            this.txtClassificacao.TabIndex = 6;
            this.txtClassificacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Font = new System.Drawing.Font("Roboto", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(301, 246);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(82, 10);
            this.txtValor.TabIndex = 10;
            this.txtValor.Visible = false;
            // 
            // txtEditora
            // 
            this.txtEditora.Enabled = false;
            this.txtEditora.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora.Location = new System.Drawing.Point(83, 238);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(100, 23);
            this.txtEditora.TabIndex = 11;
            this.txtEditora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Enabled = false;
            this.txtIsbn.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsbn.Location = new System.Drawing.Point(83, 158);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(100, 23);
            this.txtIsbn.TabIndex = 5;
            this.txtIsbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQtde
            // 
            this.txtQtde.Enabled = false;
            this.txtQtde.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(293, 181);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(100, 23);
            this.txtQtde.TabIndex = 8;
            this.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtgVenda
            // 
            this.dtgVenda.AllowUserToAddRows = false;
            this.dtgVenda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgVenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgVenda.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVenda.Location = new System.Drawing.Point(398, 12);
            this.dtgVenda.MultiSelect = false;
            this.dtgVenda.Name = "dtgVenda";
            this.dtgVenda.ReadOnly = true;
            this.dtgVenda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgVenda.Size = new System.Drawing.Size(630, 247);
            this.dtgVenda.TabIndex = 0;
            this.dtgVenda.TabStop = false;
            this.dtgVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVenda_CellContentClick);
            // 
            // timAtualiza
            // 
            this.timAtualiza.Tick += new System.EventHandler(this.timAtualiza_Tick);
            // 
            // Timhoras
            // 
            this.Timhoras.Tick += new System.EventHandler(this.Timhoras_Tick);
            // 
            // pnlPerfil
            // 
            this.pnlPerfil.Controls.Add(this.lblMat);
            this.pnlPerfil.Controls.Add(this.lblNow);
            this.pnlPerfil.Controls.Add(this.txtMat);
            this.pnlPerfil.Controls.Add(this.label11);
            this.pnlPerfil.Controls.Add(this.txtPerfil);
            this.pnlPerfil.Location = new System.Drawing.Point(562, 3);
            this.pnlPerfil.Name = "pnlPerfil";
            this.pnlPerfil.Size = new System.Drawing.Size(470, 110);
            this.pnlPerfil.TabIndex = 16;
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMat.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMat.Location = new System.Drawing.Point(305, 19);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(81, 19);
            this.lblMat.TabIndex = 4;
            this.lblMat.Text = "Matricula:";
            // 
            // lblNow
            // 
            this.lblNow.AutoSize = true;
            this.lblNow.BackColor = System.Drawing.SystemColors.Control;
            this.lblNow.Font = new System.Drawing.Font("Roboto Cn", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNow.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNow.Location = new System.Drawing.Point(70, 60);
            this.lblNow.Name = "lblNow";
            this.lblNow.Size = new System.Drawing.Size(0, 33);
            this.lblNow.TabIndex = 1;
            // 
            // txtMat
            // 
            this.txtMat.BackColor = System.Drawing.SystemColors.Control;
            this.txtMat.Enabled = false;
            this.txtMat.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMat.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtMat.Location = new System.Drawing.Point(384, 14);
            this.txtMat.Multiline = true;
            this.txtMat.Name = "txtMat";
            this.txtMat.ReadOnly = true;
            this.txtMat.Size = new System.Drawing.Size(80, 28);
            this.txtMat.TabIndex = 3;
            this.txtMat.TabStop = false;
            this.txtMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(6, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Nome:";
            // 
            // txtPerfil
            // 
            this.txtPerfil.BackColor = System.Drawing.SystemColors.Control;
            this.txtPerfil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPerfil.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPerfil.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerfil.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPerfil.Location = new System.Drawing.Point(64, 13);
            this.txtPerfil.Multiline = true;
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.ReadOnly = true;
            this.txtPerfil.ShortcutsEnabled = false;
            this.txtPerfil.Size = new System.Drawing.Size(229, 28);
            this.txtPerfil.TabIndex = 0;
            this.txtPerfil.TabStop = false;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnNovo);
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnAtualiza);
            this.pnlBotoes.Controls.Add(this.btnVenda);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 381);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(1037, 53);
            this.pnlBotoes.TabIndex = 107;
            // 
            // btnBuscarClientes
            // 
            this.btnBuscarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarClientes.Image")));
            this.btnBuscarClientes.Location = new System.Drawing.Point(308, 65);
            this.btnBuscarClientes.Name = "btnBuscarClientes";
            this.btnBuscarClientes.Size = new System.Drawing.Size(83, 54);
            this.btnBuscarClientes.TabIndex = 2;
            this.tooldica.SetToolTip(this.btnBuscarClientes, "Buscar clientes.");
            this.btnBuscarClientes.UseVisualStyleBackColor = true;
            this.btnBuscarClientes.Click += new System.EventHandler(this.btnBuscarClientes_Click);
            // 
            // frmPai
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1037, 434);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlPerfil);
            this.Controls.Add(this.pnlFundo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmPai";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "On The Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPai_FormClosing);
            this.Load += new System.EventHandler(this.frmPai_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlFundo.ResumeLayout(false);
            this.pnlFundo.PerformLayout();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenda)).EndInit();
            this.pnlPerfil.ResumeLayout(false);
            this.pnlPerfil.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolTip tooldica;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.DataGridView dtgVenda;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.ComboBox cmbPesquisa;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Label lblValo;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.Label lblClassificacao;
        private System.Windows.Forms.Label lblNacionalidade;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Timer atualiza;
        private System.Windows.Forms.Timer timAtualiza;
        private System.Windows.Forms.Timer Timhoras;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Panel pnlPerfil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPerfil;
        private System.Windows.Forms.Label lblNow;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.MaskedTextBox mTBValor;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAtualiza;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.TextBox txtClienteVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarClientes;
    }
}

