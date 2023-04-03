namespace livraria
{
    partial class frmLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLivros));
            this.dtgLivros = new System.Windows.Forms.DataGridView();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.cmbPesquisa = new System.Windows.Forms.ComboBox();
            this.tooldica = new System.Windows.Forms.ToolTip(this.components);
            this.mtbIsbn = new System.Windows.Forms.MaskedTextBox();
            this.mtbQtde = new System.Windows.Forms.MaskedTextBox();
            this.mskValor = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLivros)).BeginInit();
            this.pnlBotoes.SuspendLayout();
            this.gpbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgLivros
            // 
            this.dtgLivros.AllowUserToAddRows = false;
            this.dtgLivros.AllowUserToDeleteRows = false;
            this.dtgLivros.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLivros.Location = new System.Drawing.Point(17, 154);
            this.dtgLivros.Name = "dtgLivros";
            this.dtgLivros.ReadOnly = true;
            this.dtgLivros.Size = new System.Drawing.Size(1008, 222);
            this.dtgLivros.TabIndex = 0;
            this.dtgLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLivros_CellContentClick);
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnNovo);
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnexcluir);
            this.pnlBotoes.Controls.Add(this.btnAlterar);
            this.pnlBotoes.Controls.Add(this.btnSalva);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 389);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(1037, 45);
            this.pnlBotoes.TabIndex = 76;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.Location = new System.Drawing.Point(17, 0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 42);
            this.btnNovo.TabIndex = 11;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooldica.SetToolTip(this.btnNovo, "Limpa os campos para um novo registro");
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.Location = new System.Drawing.Point(927, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(94, 42);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "HOME";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooldica.SetToolTip(this.btnSair, "Retorna para a tela principal");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexcluir.BackgroundImage")));
            this.btnexcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnexcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexcluir.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnexcluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexcluir.Location = new System.Drawing.Point(584, 0);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(94, 42);
            this.btnexcluir.TabIndex = 14;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooldica.SetToolTip(this.btnexcluir, "Exclui um livro no banco de dados");
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.BackgroundImage")));
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.Location = new System.Drawing.Point(388, 0);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(94, 42);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Altera";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooldica.SetToolTip(this.btnAlterar, "Altera algum dado passado errado");
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalva.BackgroundImage")));
            this.btnSalva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalva.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSalva.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalva.Location = new System.Drawing.Point(194, 0);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(94, 42);
            this.btnSalva.TabIndex = 12;
            this.btnSalva.Text = "Salvar";
            this.btnSalva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooldica.SetToolTip(this.btnSalva, "Inclue os dados dos livros no banco de dados");
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassificacao.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtClassificacao.Location = new System.Drawing.Point(434, 9);
            this.txtClassificacao.MaxLength = 45;
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(166, 23);
            this.txtClassificacao.TabIndex = 6;
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacionalidade.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNacionalidade.Location = new System.Drawing.Point(127, 125);
            this.txtNacionalidade.MaxLength = 45;
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(166, 23);
            this.txtNacionalidade.TabIndex = 5;
            // 
            // txtEditora
            // 
            this.txtEditora.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtEditora.Location = new System.Drawing.Point(127, 99);
            this.txtEditora.MaxLength = 45;
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(166, 23);
            this.txtEditora.TabIndex = 4;
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtAutor.Location = new System.Drawing.Point(127, 67);
            this.txtAutor.MaxLength = 45;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(166, 23);
            this.txtAutor.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(325, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 86;
            this.label5.Text = "Classificação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(9, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 85;
            this.label4.Text = "Nacionalidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(57, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 84;
            this.label3.Text = "Editora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(69, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 83;
            this.label2.Text = "Autor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(72, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 82;
            this.label1.Text = "ISBN:";
            this.tooldica.SetToolTip(this.label1, "International Standard Book Number");
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLivro.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNomeLivro.Location = new System.Drawing.Point(127, 41);
            this.txtNomeLivro.MaxLength = 45;
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(166, 23);
            this.txtNomeLivro.TabIndex = 2;
            this.txtNomeLivro.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(13, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 88;
            this.label6.Text = "Nome do livro:";
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.lblEscolha);
            this.gpbPesquisa.Controls.Add(this.btnPesquisa);
            this.gpbPesquisa.Controls.Add(this.cmbPesquisa);
            this.gpbPesquisa.Location = new System.Drawing.Point(626, 19);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(399, 127);
            this.gpbPesquisa.TabIndex = 89;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa de Livros";
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolha.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblEscolha.Location = new System.Drawing.Point(6, 29);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(191, 19);
            this.lblEscolha.TabIndex = 9;
            this.lblEscolha.Text = "Escolha um tipo de busca";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.BackgroundImage")));
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisa.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(221, 39);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(126, 41);
            this.btnPesquisa.TabIndex = 9;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooldica.SetToolTip(this.btnPesquisa, "Realizar pesquisa de livros.");
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // cmbPesquisa
            // 
            this.cmbPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPesquisa.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPesquisa.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cmbPesquisa.FormattingEnabled = true;
            this.cmbPesquisa.Items.AddRange(new object[] {
            "Nome",
            "Autor",
            "Editora",
            "Nacionalidade",
            "Classificacoes"});
            this.cmbPesquisa.Location = new System.Drawing.Point(10, 56);
            this.cmbPesquisa.Name = "cmbPesquisa";
            this.cmbPesquisa.Size = new System.Drawing.Size(187, 23);
            this.cmbPesquisa.TabIndex = 8;
            this.cmbPesquisa.SelectedIndexChanged += new System.EventHandler(this.cmbPesquisa_SelectedIndexChanged);
            // 
            // tooldica
            // 
            this.tooldica.AutoPopDelay = 5000;
            this.tooldica.BackColor = System.Drawing.Color.Red;
            this.tooldica.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tooldica.InitialDelay = 300;
            this.tooldica.IsBalloon = true;
            this.tooldica.ReshowDelay = 100;
            this.tooldica.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooldica.ToolTipTitle = "Info";
            // 
            // mtbIsbn
            // 
            this.mtbIsbn.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbIsbn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.mtbIsbn.Location = new System.Drawing.Point(127, 13);
            this.mtbIsbn.Mask = "0000000000000";
            this.mtbIsbn.Name = "mtbIsbn";
            this.mtbIsbn.Size = new System.Drawing.Size(166, 23);
            this.mtbIsbn.TabIndex = 1;
            this.tooldica.SetToolTip(this.mtbIsbn, "Somente numeros !");
            // 
            // mtbQtde
            // 
            this.mtbQtde.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbQtde.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.mtbQtde.Location = new System.Drawing.Point(434, 41);
            this.mtbQtde.Mask = "000";
            this.mtbQtde.Name = "mtbQtde";
            this.mtbQtde.Size = new System.Drawing.Size(166, 23);
            this.mtbQtde.TabIndex = 7;
            this.tooldica.SetToolTip(this.mtbQtde, "Somente numeros !");
            // 
            // mskValor
            // 
            this.mskValor.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskValor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.mskValor.Location = new System.Drawing.Point(434, 73);
            this.mskValor.Mask = "000";
            this.mskValor.Name = "mskValor";
            this.mskValor.Size = new System.Drawing.Size(166, 23);
            this.mskValor.TabIndex = 10;
            this.tooldica.SetToolTip(this.mskValor, "Somente numeros !");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(339, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 91;
            this.label7.Text = "Quantidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(381, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 93;
            this.label8.Text = "Valor:";
            // 
            // frmLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1037, 434);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mskValor);
            this.Controls.Add(this.mtbQtde);
            this.Controls.Add(this.mtbIsbn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gpbPesquisa);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtClassificacao);
            this.Controls.Add(this.txtNacionalidade);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.dtgLivros);
            this.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Livros";
            this.tooldica.SetToolTip(this, "Apenas números.");
            this.Load += new System.EventHandler(this.frmLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLivros)).EndInit();
            this.pnlBotoes.ResumeLayout(false);
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgLivros;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.ComboBox cmbPesquisa;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.ToolTip tooldica;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtbIsbn;
        private System.Windows.Forms.MaskedTextBox mtbQtde;
        private System.Windows.Forms.MaskedTextBox mskValor;
        private System.Windows.Forms.Label label8;
    }
}