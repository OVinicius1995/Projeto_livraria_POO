namespace livraria
{
    partial class frmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            this.btnNovo = new System.Windows.Forms.Button();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.dtgFuncionario = new System.Windows.Forms.DataGridView();
            this.txtLogradouroFuncionario = new System.Windows.Forms.TextBox();
            this.txtBairroFuncionario = new System.Windows.Forms.TextBox();
            this.txtNumeroFuncionario = new System.Windows.Forms.TextBox();
            this.txtUfFuncionario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComplementoFuncionario = new System.Windows.Forms.TextBox();
            this.txtEnderecoFuncionario = new System.Windows.Forms.TextBox();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCidadeFuncionario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tooldica = new System.Windows.Forms.ToolTip(this.components);
            this.mtbRgFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.mtbCpfFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefoneFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.mtbCepFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.Location = new System.Drawing.Point(17, 0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 42);
            this.btnNovo.TabIndex = 18;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooldica.SetToolTip(this.btnNovo, "Limpa os campos para um novo registro");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnPesquisa);
            this.pnlBotoes.Controls.Add(this.btnNovo);
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnexcluir);
            this.pnlBotoes.Controls.Add(this.btnAlterar);
            this.pnlBotoes.Controls.Add(this.btnSalva);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 389);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(1037, 45);
            this.pnlBotoes.TabIndex = 104;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.BackgroundImage")));
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisa.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPesquisa.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisa.Location = new System.Drawing.Point(752, 0);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(126, 41);
            this.btnPesquisa.TabIndex = 23;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
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
            this.btnSair.TabIndex = 22;
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
            this.btnexcluir.TabIndex = 21;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooldica.SetToolTip(this.btnexcluir, "Exclui um funcionário no banco de dados");
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
            this.btnAlterar.TabIndex = 20;
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
            this.btnSalva.TabIndex = 19;
            this.btnSalva.Text = "Salvar";
            this.btnSalva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooldica.SetToolTip(this.btnSalva, "Inclue os dados do profissional no banco de dados");
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // dtgFuncionario
            // 
            this.dtgFuncionario.AllowUserToAddRows = false;
            this.dtgFuncionario.AllowUserToDeleteRows = false;
            this.dtgFuncionario.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFuncionario.Location = new System.Drawing.Point(17, 154);
            this.dtgFuncionario.Name = "dtgFuncionario";
            this.dtgFuncionario.ReadOnly = true;
            this.dtgFuncionario.Size = new System.Drawing.Size(1008, 222);
            this.dtgFuncionario.TabIndex = 91;
            this.dtgFuncionario.TabStop = false;
            this.dtgFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFuncionario_CellContentClick);
            // 
            // txtLogradouroFuncionario
            // 
            this.txtLogradouroFuncionario.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouroFuncionario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtLogradouroFuncionario.Location = new System.Drawing.Point(716, 127);
            this.txtLogradouroFuncionario.MaxLength = 45;
            this.txtLogradouroFuncionario.Name = "txtLogradouroFuncionario";
            this.txtLogradouroFuncionario.Size = new System.Drawing.Size(166, 23);
            this.txtLogradouroFuncionario.TabIndex = 15;
            // 
            // txtBairroFuncionario
            // 
            this.txtBairroFuncionario.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroFuncionario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtBairroFuncionario.Location = new System.Drawing.Point(416, 122);
            this.txtBairroFuncionario.MaxLength = 45;
            this.txtBairroFuncionario.Name = "txtBairroFuncionario";
            this.txtBairroFuncionario.Size = new System.Drawing.Size(166, 23);
            this.txtBairroFuncionario.TabIndex = 10;
            // 
            // txtNumeroFuncionario
            // 
            this.txtNumeroFuncionario.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroFuncionario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNumeroFuncionario.Location = new System.Drawing.Point(715, 97);
            this.txtNumeroFuncionario.MaxLength = 5;
            this.txtNumeroFuncionario.Name = "txtNumeroFuncionario";
            this.txtNumeroFuncionario.Size = new System.Drawing.Size(166, 23);
            this.txtNumeroFuncionario.TabIndex = 14;
            // 
            // txtUfFuncionario
            // 
            this.txtUfFuncionario.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUfFuncionario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtUfFuncionario.Location = new System.Drawing.Point(713, 68);
            this.txtUfFuncionario.MaxLength = 2;
            this.txtUfFuncionario.Name = "txtUfFuncionario";
            this.txtUfFuncionario.Size = new System.Drawing.Size(165, 23);
            this.txtUfFuncionario.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(673, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 19);
            this.label6.TabIndex = 103;
            this.label6.Text = "UF:";
            this.tooldica.SetToolTip(this.label6, "Unidade Federativa");
            // 
            // txtComplementoFuncionario
            // 
            this.txtComplementoFuncionario.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplementoFuncionario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtComplementoFuncionario.Location = new System.Drawing.Point(712, 39);
            this.txtComplementoFuncionario.MaxLength = 45;
            this.txtComplementoFuncionario.Name = "txtComplementoFuncionario";
            this.txtComplementoFuncionario.Size = new System.Drawing.Size(166, 23);
            this.txtComplementoFuncionario.TabIndex = 12;
            // 
            // txtEnderecoFuncionario
            // 
            this.txtEnderecoFuncionario.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoFuncionario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtEnderecoFuncionario.Location = new System.Drawing.Point(416, 93);
            this.txtEnderecoFuncionario.MaxLength = 45;
            this.txtEnderecoFuncionario.Name = "txtEnderecoFuncionario";
            this.txtEnderecoFuncionario.Size = new System.Drawing.Size(166, 23);
            this.txtEnderecoFuncionario.TabIndex = 9;
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNomeFuncionario.Location = new System.Drawing.Point(80, 38);
            this.txtNomeFuncionario.MaxLength = 45;
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(166, 23);
            this.txtNomeFuncionario.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(613, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 19);
            this.label12.TabIndex = 102;
            this.label12.Text = "Logradouro:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(885, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 19);
            this.label11.TabIndex = 101;
            this.label11.Text = "CEP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(351, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 19);
            this.label10.TabIndex = 100;
            this.label10.Text = "Bairro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(637, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 19);
            this.label8.TabIndex = 98;
            this.label8.Text = "Numero:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(594, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 19);
            this.label7.TabIndex = 97;
            this.label7.Text = "Complemento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(328, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 96;
            this.label5.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(43, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 19);
            this.label4.TabIndex = 95;
            this.label4.Text = "RG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(338, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 94;
            this.label3.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(26, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 93;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(37, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 92;
            this.label1.Text = "CPF:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Enabled = false;
            this.txtMatricula.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtMatricula.Location = new System.Drawing.Point(80, 10);
            this.txtMatricula.MaxLength = 45;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(166, 23);
            this.txtMatricula.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label13.Location = new System.Drawing.Point(1, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 19);
            this.label13.TabIndex = 106;
            this.label13.Text = "Matricula:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label14.Location = new System.Drawing.Point(364, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 19);
            this.label14.TabIndex = 107;
            this.label14.Text = "Sexo:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSexo.Location = new System.Drawing.Point(418, 38);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(166, 23);
            this.cmbSexo.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Location = new System.Drawing.Point(256, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 19);
            this.label15.TabIndex = 110;
            this.label15.Text = "Data de nascimento:";
            // 
            // txtCidadeFuncionario
            // 
            this.txtCidadeFuncionario.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeFuncionario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCidadeFuncionario.Location = new System.Drawing.Point(712, 8);
            this.txtCidadeFuncionario.MaxLength = 45;
            this.txtCidadeFuncionario.Name = "txtCidadeFuncionario";
            this.txtCidadeFuncionario.Size = new System.Drawing.Size(166, 23);
            this.txtCidadeFuncionario.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(644, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 19);
            this.label9.TabIndex = 112;
            this.label9.Text = "Cidade:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtSenha.Location = new System.Drawing.Point(80, 64);
            this.txtSenha.MaxLength = 45;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(166, 23);
            this.txtSenha.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label16.Location = new System.Drawing.Point(22, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 19);
            this.label16.TabIndex = 114;
            this.label16.Text = "Senha:";
            // 
            // tooldica
            // 
            this.tooldica.AutoPopDelay = 5000;
            this.tooldica.InitialDelay = 300;
            this.tooldica.IsBalloon = true;
            this.tooldica.ReshowDelay = 100;
            this.tooldica.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooldica.ToolTipTitle = "Info";
            this.tooldica.UseAnimation = false;
            this.tooldica.UseFading = false;
            // 
            // mtbRgFuncionario
            // 
            this.mtbRgFuncionario.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbRgFuncionario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.mtbRgFuncionario.Location = new System.Drawing.Point(80, 88);
            this.mtbRgFuncionario.Mask = "00000000";
            this.mtbRgFuncionario.Name = "mtbRgFuncionario";
            this.mtbRgFuncionario.Size = new System.Drawing.Size(166, 23);
            this.mtbRgFuncionario.TabIndex = 4;
            this.tooldica.SetToolTip(this.mtbRgFuncionario, "Somente Numeros !");
            // 
            // mtbCpfFuncionario
            // 
            this.mtbCpfFuncionario.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCpfFuncionario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.mtbCpfFuncionario.Location = new System.Drawing.Point(80, 114);
            this.mtbCpfFuncionario.Mask = "000-000-000-00";
            this.mtbCpfFuncionario.Name = "mtbCpfFuncionario";
            this.mtbCpfFuncionario.Size = new System.Drawing.Size(166, 23);
            this.mtbCpfFuncionario.TabIndex = 5;
            this.tooldica.SetToolTip(this.mtbCpfFuncionario, "Somente numeros !");
            // 
            // mtbTelefoneFuncionario
            // 
            this.mtbTelefoneFuncionario.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefoneFuncionario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.mtbTelefoneFuncionario.Location = new System.Drawing.Point(416, 7);
            this.mtbTelefoneFuncionario.Mask = "(999) 000-0000";
            this.mtbTelefoneFuncionario.Name = "mtbTelefoneFuncionario";
            this.mtbTelefoneFuncionario.Size = new System.Drawing.Size(166, 23);
            this.mtbTelefoneFuncionario.TabIndex = 6;
            this.tooldica.SetToolTip(this.mtbTelefoneFuncionario, "Somente Numeros !");
            // 
            // mtbCepFuncionario
            // 
            this.mtbCepFuncionario.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCepFuncionario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.mtbCepFuncionario.Location = new System.Drawing.Point(935, 7);
            this.mtbCepFuncionario.Mask = "00000-9999";
            this.mtbCepFuncionario.Name = "mtbCepFuncionario";
            this.mtbCepFuncionario.Size = new System.Drawing.Size(83, 23);
            this.mtbCepFuncionario.TabIndex = 16;
            this.tooldica.SetToolTip(this.mtbCepFuncionario, "Somente Numeros !");
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(418, 66);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(166, 21);
            this.dtData.TabIndex = 8;
            this.dtData.Value = new System.DateTime(2023, 3, 29, 20, 35, 32, 0);
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1037, 434);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.mtbCepFuncionario);
            this.Controls.Add(this.mtbTelefoneFuncionario);
            this.Controls.Add(this.mtbCpfFuncionario);
            this.Controls.Add(this.mtbRgFuncionario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCidadeFuncionario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.dtgFuncionario);
            this.Controls.Add(this.txtLogradouroFuncionario);
            this.Controls.Add(this.txtBairroFuncionario);
            this.Controls.Add(this.txtNumeroFuncionario);
            this.Controls.Add(this.txtUfFuncionario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtComplementoFuncionario);
            this.Controls.Add(this.txtEnderecoFuncionario);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.frmFuncionarios_Load);
            this.pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.DataGridView dtgFuncionario;
        private System.Windows.Forms.TextBox txtLogradouroFuncionario;
        private System.Windows.Forms.TextBox txtBairroFuncionario;
        private System.Windows.Forms.TextBox txtNumeroFuncionario;
        private System.Windows.Forms.TextBox txtUfFuncionario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComplementoFuncionario;
        private System.Windows.Forms.TextBox txtEnderecoFuncionario;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCidadeFuncionario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolTip tooldica;
        private System.Windows.Forms.MaskedTextBox mtbRgFuncionario;
        private System.Windows.Forms.MaskedTextBox mtbCpfFuncionario;
        private System.Windows.Forms.MaskedTextBox mtbTelefoneFuncionario;
        private System.Windows.Forms.MaskedTextBox mtbCepFuncionario;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.DateTimePicker dtData;
    }
}