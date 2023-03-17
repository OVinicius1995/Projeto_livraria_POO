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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tooldica = new System.Windows.Forms.ToolTip(this.components);
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnAtualiza = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblVenda = new System.Windows.Forms.Label();
            this.txtVenda = new System.Windows.Forms.TextBox();
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
            this.txtMat = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            this.lblNow = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.pnlBotao = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnlFundo.SuspendLayout();
            this.gpbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenda)).BeginInit();
            this.pnlPerfil.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.pnlBotao.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(527, 113);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.AutoToolTip = true;
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clientesToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(156, 109);
            this.clientesToolStripMenuItem.Text = "Clientes           ";
            this.clientesToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.clientesToolStripMenuItem.ToolTipText = "Cadastra cliente";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.Enabled = false;
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
            this.funcionariosToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionariosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.funcionariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionariosToolStripMenuItem.Image")));
            this.funcionariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(174, 109);
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
            this.livrosToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livrosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.livrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("livrosToolStripMenuItem.Image")));
            this.livrosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(131, 109);
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
            this.btnPesquisa.Location = new System.Drawing.Point(154, 9);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(89, 41);
            this.btnPesquisa.TabIndex = 8;
            this.btnPesquisa.Text = "Pesquisa";
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooldica.SetToolTip(this.btnPesquisa, "Realizar pesquisa de livros.");
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSair.Location = new System.Drawing.Point(0, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(83, 46);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooldica.SetToolTip(this.btnSair, "Sair da aplicação");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVenda.BackgroundImage")));
            this.btnVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVenda.Location = new System.Drawing.Point(3, 7);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(73, 37);
            this.btnVenda.TabIndex = 11;
            this.btnVenda.Text = "Venda";
            this.btnVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooldica.SetToolTip(this.btnVenda, "Realiza venda");
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualiza.BackgroundImage")));
            this.btnAtualiza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtualiza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAtualiza.Location = new System.Drawing.Point(285, 8);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(73, 37);
            this.btnAtualiza.TabIndex = 13;
            this.btnAtualiza.Text = "Atualiza";
            this.btnAtualiza.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooldica.SetToolTip(this.btnAtualiza, "Os dados sao atualizados a cada 20 segundos");
            this.btnAtualiza.UseVisualStyleBackColor = true;
            this.btnAtualiza.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNovo.Location = new System.Drawing.Point(144, 7);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(73, 37);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooldica.SetToolTip(this.btnNovo, "Limpa os dados para um novo registro");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.button1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Size = new System.Drawing.Size(1117, 434);
            this.shapeContainer1.TabIndex = 13;
            this.shapeContainer1.TabStop = false;
            // 
            // pnlFundo
            // 
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
            this.pnlFundo.Location = new System.Drawing.Point(3, 116);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(1114, 264);
            this.pnlFundo.TabIndex = 15;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(64, 88);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.ReadOnly = true;
            this.txtMatricula.ShortcutsEnabled = false;
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 1;
            this.txtMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblMatricula.Location = new System.Drawing.Point(4, 91);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(53, 13);
            this.lblMatricula.TabIndex = 104;
            this.lblMatricula.Text = "Matricula:";
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblVenda.Location = new System.Drawing.Point(174, 193);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(41, 13);
            this.lblVenda.TabIndex = 100;
            this.lblVenda.Text = "Venda:";
            // 
            // txtVenda
            // 
            this.txtVenda.Location = new System.Drawing.Point(252, 186);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(100, 20);
            this.txtVenda.TabIndex = 9;
            this.txtVenda.TextChanged += new System.EventHandler(this.txtVenda_TextChanged);
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.lblEscolha);
            this.gpbPesquisa.Controls.Add(this.btnPesquisa);
            this.gpbPesquisa.Controls.Add(this.cmbPesquisa);
            this.gpbPesquisa.Location = new System.Drawing.Point(63, 3);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(252, 54);
            this.gpbPesquisa.TabIndex = 94;
            this.gpbPesquisa.TabStop = false;
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Location = new System.Drawing.Point(-3, 9);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(129, 13);
            this.lblEscolha.TabIndex = 9;
            this.lblEscolha.Text = "Escolha um tipo de busca";
            // 
            // cmbPesquisa
            // 
            this.cmbPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPesquisa.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cmbPesquisa.FormattingEnabled = true;
            this.cmbPesquisa.Items.AddRange(new object[] {
            "Nome",
            "Autor",
            "Editora",
            "Nacionalidade",
            "Classificacoes"});
            this.cmbPesquisa.Location = new System.Drawing.Point(2, 25);
            this.cmbPesquisa.Name = "cmbPesquisa";
            this.cmbPesquisa.Size = new System.Drawing.Size(129, 21);
            this.cmbPesquisa.TabIndex = 7;
            this.cmbPesquisa.SelectedIndexChanged += new System.EventHandler(this.cmbPesquisa_SelectedIndexChanged);
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblEditora.Location = new System.Drawing.Point(1, 236);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(43, 13);
            this.lblEditora.TabIndex = 98;
            this.lblEditora.Text = "Editora:";
            // 
            // lblValo
            // 
            this.lblValo.AutoSize = true;
            this.lblValo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblValo.Location = new System.Drawing.Point(181, 219);
            this.lblValo.Name = "lblValo";
            this.lblValo.Size = new System.Drawing.Size(34, 13);
            this.lblValo.TabIndex = 97;
            this.lblValo.Text = "Valor:";
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblQtde.Location = new System.Drawing.Point(174, 161);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(42, 13);
            this.lblQtde.TabIndex = 96;
            this.lblQtde.Text = "Q.t.d.e:";
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblClassificacao.Location = new System.Drawing.Point(174, 124);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(72, 13);
            this.lblClassificacao.TabIndex = 95;
            this.lblClassificacao.Text = "Classificação:";
            // 
            // lblNacionalidade
            // 
            this.lblNacionalidade.AutoSize = true;
            this.lblNacionalidade.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblNacionalidade.Location = new System.Drawing.Point(174, 88);
            this.lblNacionalidade.Name = "lblNacionalidade";
            this.lblNacionalidade.Size = new System.Drawing.Size(72, 13);
            this.lblNacionalidade.TabIndex = 94;
            this.lblNacionalidade.Text = "Ncionalidade:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblAutor.Location = new System.Drawing.Point(1, 201);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 93;
            this.lblAutor.Text = "Autor:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblNome.Location = new System.Drawing.Point(1, 164);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 92;
            this.lblNome.Text = "Nome:";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblIsbn.Location = new System.Drawing.Point(4, 128);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(35, 13);
            this.lblIsbn.TabIndex = 91;
            this.lblIsbn.Text = "ISBN:";
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Enabled = false;
            this.txtNacionalidade.Location = new System.Drawing.Point(252, 81);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(100, 20);
            this.txtNacionalidade.TabIndex = 6;
            // 
            // txtAutor
            // 
            this.txtAutor.Enabled = false;
            this.txtAutor.Location = new System.Drawing.Point(63, 194);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 20);
            this.txtAutor.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(63, 157);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.Enabled = false;
            this.txtClassificacao.Location = new System.Drawing.Point(252, 117);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(100, 20);
            this.txtClassificacao.TabIndex = 7;
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(252, 212);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 10;
            // 
            // txtEditora
            // 
            this.txtEditora.Enabled = false;
            this.txtEditora.Location = new System.Drawing.Point(63, 229);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(100, 20);
            this.txtEditora.TabIndex = 5;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Enabled = false;
            this.txtIsbn.Location = new System.Drawing.Point(63, 121);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(100, 20);
            this.txtIsbn.TabIndex = 2;
            // 
            // txtQtde
            // 
            this.txtQtde.Enabled = false;
            this.txtQtde.Location = new System.Drawing.Point(252, 154);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(100, 20);
            this.txtQtde.TabIndex = 8;
            // 
            // dtgVenda
            // 
            this.dtgVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVenda.Location = new System.Drawing.Point(358, 12);
            this.dtgVenda.Name = "dtgVenda";
            this.dtgVenda.Size = new System.Drawing.Size(742, 249);
            this.dtgVenda.TabIndex = 0;
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
            this.pnlPerfil.Controls.Add(this.txtMat);
            this.pnlPerfil.Controls.Add(this.label11);
            this.pnlPerfil.Controls.Add(this.txtPerfil);
            this.pnlPerfil.Location = new System.Drawing.Point(530, 3);
            this.pnlPerfil.Name = "pnlPerfil";
            this.pnlPerfil.Size = new System.Drawing.Size(584, 110);
            this.pnlPerfil.TabIndex = 16;
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMat.Location = new System.Drawing.Point(377, 12);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(82, 20);
            this.lblMat.TabIndex = 4;
            this.lblMat.Text = "Matricula";
            // 
            // txtMat
            // 
            this.txtMat.BackColor = System.Drawing.SystemColors.Control;
            this.txtMat.Enabled = false;
            this.txtMat.Font = new System.Drawing.Font("Monoid", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMat.Location = new System.Drawing.Point(464, 11);
            this.txtMat.Multiline = true;
            this.txtMat.Name = "txtMat";
            this.txtMat.ReadOnly = true;
            this.txtMat.Size = new System.Drawing.Size(80, 28);
            this.txtMat.TabIndex = 3;
            this.txtMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(6, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Nome:";
            // 
            // txtPerfil
            // 
            this.txtPerfil.BackColor = System.Drawing.SystemColors.Control;
            this.txtPerfil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPerfil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPerfil.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPerfil.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerfil.ForeColor = System.Drawing.Color.PaleGreen;
            this.txtPerfil.Location = new System.Drawing.Point(75, 9);
            this.txtPerfil.Multiline = true;
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.ReadOnly = true;
            this.txtPerfil.ShortcutsEnabled = false;
            this.txtPerfil.Size = new System.Drawing.Size(296, 28);
            this.txtPerfil.TabIndex = 0;
            this.txtPerfil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNow
            // 
            this.lblNow.AutoSize = true;
            this.lblNow.BackColor = System.Drawing.SystemColors.Control;
            this.lblNow.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblNow.Location = new System.Drawing.Point(820, 10);
            this.lblNow.Name = "lblNow";
            this.lblNow.Size = new System.Drawing.Size(0, 34);
            this.lblNow.TabIndex = 1;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnNovo);
            this.pnlBotoes.Controls.Add(this.btnAtualiza);
            this.pnlBotoes.Controls.Add(this.btnVenda);
            this.pnlBotoes.Location = new System.Drawing.Point(361, 4);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(362, 45);
            this.pnlBotoes.TabIndex = 107;
            // 
            // pnlBotao
            // 
            this.pnlBotao.Controls.Add(this.pnlBotoes);
            this.pnlBotao.Controls.Add(this.lblNow);
            this.pnlBotao.Controls.Add(this.btnSair);
            this.pnlBotao.Location = new System.Drawing.Point(0, 382);
            this.pnlBotao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBotao.Name = "pnlBotao";
            this.pnlBotao.Size = new System.Drawing.Size(1114, 51);
            this.pnlBotao.TabIndex = 12;
            // 
            // frmPai
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1117, 434);
            this.Controls.Add(this.pnlPerfil);
            this.Controls.Add(this.pnlFundo);
            this.Controls.Add(this.pnlBotao);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.shapeContainer1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmPai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "On The Book";
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
            this.pnlBotao.ResumeLayout(false);
            this.pnlBotao.PerformLayout();
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
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblNow;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAtualiza;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Panel pnlBotao;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.TextBox txtMat;
    }
}

