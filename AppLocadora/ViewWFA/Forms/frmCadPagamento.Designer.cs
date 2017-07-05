namespace ViewWFA.Forms
{
    partial class frmCadPagamento
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
            System.Windows.Forms.Label pAGAMENTO_DATALabel;
            System.Windows.Forms.Label pAGAMENTO_VENCIMENTOLabel;
            System.Windows.Forms.Label pAGAMENTO_VALORPAGARLabel;
            System.Windows.Forms.Label pAGAMENTO_VALORPAGOLabel;
            System.Windows.Forms.Label pAGAMENTO_PAGADORLabel;
            System.Windows.Forms.Label pAGAMENTO_METODOPAGLabel;
            System.Windows.Forms.Label pAGAMENTO_FORMAPAGLabel;
            System.Windows.Forms.Label pAGAMENTO_TIPOPAGLabel;
            System.Windows.Forms.Label pAGAMENTO_BENEFICIARIOLabel;
            this.dgView = new System.Windows.Forms.DataGridView();
            this.dpData = new System.Windows.Forms.DateTimePicker();
            this.dpVencimento = new System.Windows.Forms.DateTimePicker();
            this.pAGAMENTO_VALORPAGARTextBox = new System.Windows.Forms.TextBox();
            this.pAGAMENTO_VALORPAGOTextBox = new System.Windows.Forms.TextBox();
            this.tbPagador = new System.Windows.Forms.TextBox();
            this.tbMetodoPag = new System.Windows.Forms.TextBox();
            this.tbFormaPag = new System.Windows.Forms.TextBox();
            this.tbTipoPag = new System.Windows.Forms.TextBox();
            this.tbDataPag = new System.Windows.Forms.TextBox();
            this.tbDataVencimento = new System.Windows.Forms.TextBox();
            this.beneficiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbBeneficiario = new System.Windows.Forms.TextBox();
            this.pagadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metodoPagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formaPagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoPagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAGAMENTOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAGAMENTODATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAGAMENTOVENCIMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAGAMENTOVALORPAGARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAGAMENTOVALORPAGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAGAMENTOBENEFICIARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pAGAMENTOPAGADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pAGAMENTOMETODOPAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pAGAMENTOFORMAPAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pAGAMENTOTIPOPAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbBeneficiario = new System.Windows.Forms.ComboBox();
            this.cbFormaPag = new System.Windows.Forms.ComboBox();
            this.cbMetodoPag = new System.Windows.Forms.ComboBox();
            this.cbPagador = new System.Windows.Forms.ComboBox();
            this.cbTipoPag = new System.Windows.Forms.ComboBox();
            pAGAMENTO_DATALabel = new System.Windows.Forms.Label();
            pAGAMENTO_VENCIMENTOLabel = new System.Windows.Forms.Label();
            pAGAMENTO_VALORPAGARLabel = new System.Windows.Forms.Label();
            pAGAMENTO_VALORPAGOLabel = new System.Windows.Forms.Label();
            pAGAMENTO_PAGADORLabel = new System.Windows.Forms.Label();
            pAGAMENTO_METODOPAGLabel = new System.Windows.Forms.Label();
            pAGAMENTO_FORMAPAGLabel = new System.Windows.Forms.Label();
            pAGAMENTO_TIPOPAGLabel = new System.Windows.Forms.Label();
            pAGAMENTO_BENEFICIARIOLabel = new System.Windows.Forms.Label();
            this.tpCadastro.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPagBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tpCadastro
            // 
            this.tpCadastro.AutoScroll = true;
            this.tpCadastro.Size = new System.Drawing.Size(601, 492);
            // 
            // tpConsulta
            // 
            this.tpConsulta.Size = new System.Drawing.Size(601, 490);
            // 
            // tabControl
            // 
            this.tabControl.Size = new System.Drawing.Size(609, 518);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(6, 436);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgView);
            this.panel2.Size = new System.Drawing.Size(589, 368);
            this.panel2.Controls.SetChildIndex(this.gbDados, 0);
            this.panel2.Controls.SetChildIndex(this.dgView, 0);
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.cbTipoPag);
            this.gbDados.Controls.Add(this.cbPagador);
            this.gbDados.Controls.Add(this.cbMetodoPag);
            this.gbDados.Controls.Add(this.cbFormaPag);
            this.gbDados.Controls.Add(this.cbBeneficiario);
            this.gbDados.Controls.Add(pAGAMENTO_BENEFICIARIOLabel);
            this.gbDados.Controls.Add(this.tbBeneficiario);
            this.gbDados.Controls.Add(this.tbDataVencimento);
            this.gbDados.Controls.Add(this.tbDataPag);
            this.gbDados.Controls.Add(pAGAMENTO_TIPOPAGLabel);
            this.gbDados.Controls.Add(this.tbTipoPag);
            this.gbDados.Controls.Add(pAGAMENTO_FORMAPAGLabel);
            this.gbDados.Controls.Add(this.tbFormaPag);
            this.gbDados.Controls.Add(pAGAMENTO_METODOPAGLabel);
            this.gbDados.Controls.Add(this.tbMetodoPag);
            this.gbDados.Controls.Add(pAGAMENTO_PAGADORLabel);
            this.gbDados.Controls.Add(this.tbPagador);
            this.gbDados.Controls.Add(pAGAMENTO_VALORPAGOLabel);
            this.gbDados.Controls.Add(this.pAGAMENTO_VALORPAGOTextBox);
            this.gbDados.Controls.Add(pAGAMENTO_VALORPAGARLabel);
            this.gbDados.Controls.Add(this.pAGAMENTO_VALORPAGARTextBox);
            this.gbDados.Controls.Add(pAGAMENTO_VENCIMENTOLabel);
            this.gbDados.Controls.Add(this.dpVencimento);
            this.gbDados.Controls.Add(pAGAMENTO_DATALabel);
            this.gbDados.Controls.Add(this.dpData);
            this.gbDados.Location = new System.Drawing.Point(3, 217);
            this.gbDados.Size = new System.Drawing.Size(586, 146);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // bSource
            // 
            this.bSource.DataSource = typeof(Classes.Entidades.Pagamento);
            // 
            // pAGAMENTO_DATALabel
            // 
            pAGAMENTO_DATALabel.AutoSize = true;
            pAGAMENTO_DATALabel.Location = new System.Drawing.Point(6, 16);
            pAGAMENTO_DATALabel.Name = "pAGAMENTO_DATALabel";
            pAGAMENTO_DATALabel.Size = new System.Drawing.Size(64, 13);
            pAGAMENTO_DATALabel.TabIndex = 0;
            pAGAMENTO_DATALabel.Text = "DATA PAG.";
            // 
            // pAGAMENTO_VENCIMENTOLabel
            // 
            pAGAMENTO_VENCIMENTOLabel.AutoSize = true;
            pAGAMENTO_VENCIMENTOLabel.Location = new System.Drawing.Point(287, 16);
            pAGAMENTO_VENCIMENTOLabel.Name = "pAGAMENTO_VENCIMENTOLabel";
            pAGAMENTO_VENCIMENTOLabel.Size = new System.Drawing.Size(78, 13);
            pAGAMENTO_VENCIMENTOLabel.TabIndex = 2;
            pAGAMENTO_VENCIMENTOLabel.Text = "VENCIMENTO";
            // 
            // pAGAMENTO_VALORPAGARLabel
            // 
            pAGAMENTO_VALORPAGARLabel.AutoSize = true;
            pAGAMENTO_VALORPAGARLabel.Location = new System.Drawing.Point(6, 41);
            pAGAMENTO_VALORPAGARLabel.Name = "pAGAMENTO_VALORPAGARLabel";
            pAGAMENTO_VALORPAGARLabel.Size = new System.Drawing.Size(83, 13);
            pAGAMENTO_VALORPAGARLabel.TabIndex = 4;
            pAGAMENTO_VALORPAGARLabel.Text = "VALOR PAGAR";
            // 
            // pAGAMENTO_VALORPAGOLabel
            // 
            pAGAMENTO_VALORPAGOLabel.AutoSize = true;
            pAGAMENTO_VALORPAGOLabel.Location = new System.Drawing.Point(199, 41);
            pAGAMENTO_VALORPAGOLabel.Name = "pAGAMENTO_VALORPAGOLabel";
            pAGAMENTO_VALORPAGOLabel.Size = new System.Drawing.Size(76, 13);
            pAGAMENTO_VALORPAGOLabel.TabIndex = 6;
            pAGAMENTO_VALORPAGOLabel.Text = "VALOR PAGO";
            // 
            // pAGAMENTO_PAGADORLabel
            // 
            pAGAMENTO_PAGADORLabel.AutoSize = true;
            pAGAMENTO_PAGADORLabel.Location = new System.Drawing.Point(6, 67);
            pAGAMENTO_PAGADORLabel.Name = "pAGAMENTO_PAGADORLabel";
            pAGAMENTO_PAGADORLabel.Size = new System.Drawing.Size(60, 13);
            pAGAMENTO_PAGADORLabel.TabIndex = 8;
            pAGAMENTO_PAGADORLabel.Text = "PAGADOR";
            // 
            // pAGAMENTO_METODOPAGLabel
            // 
            pAGAMENTO_METODOPAGLabel.AutoSize = true;
            pAGAMENTO_METODOPAGLabel.Location = new System.Drawing.Point(287, 94);
            pAGAMENTO_METODOPAGLabel.Name = "pAGAMENTO_METODOPAGLabel";
            pAGAMENTO_METODOPAGLabel.Size = new System.Drawing.Size(82, 13);
            pAGAMENTO_METODOPAGLabel.TabIndex = 10;
            pAGAMENTO_METODOPAGLabel.Text = "METODO PAG.";
            // 
            // pAGAMENTO_FORMAPAGLabel
            // 
            pAGAMENTO_FORMAPAGLabel.AutoSize = true;
            pAGAMENTO_FORMAPAGLabel.Location = new System.Drawing.Point(6, 121);
            pAGAMENTO_FORMAPAGLabel.Name = "pAGAMENTO_FORMAPAGLabel";
            pAGAMENTO_FORMAPAGLabel.Size = new System.Drawing.Size(73, 13);
            pAGAMENTO_FORMAPAGLabel.TabIndex = 12;
            pAGAMENTO_FORMAPAGLabel.Text = "FORMA PAG.";
            // 
            // pAGAMENTO_TIPOPAGLabel
            // 
            pAGAMENTO_TIPOPAGLabel.AutoSize = true;
            pAGAMENTO_TIPOPAGLabel.Location = new System.Drawing.Point(287, 121);
            pAGAMENTO_TIPOPAGLabel.Name = "pAGAMENTO_TIPOPAGLabel";
            pAGAMENTO_TIPOPAGLabel.Size = new System.Drawing.Size(60, 13);
            pAGAMENTO_TIPOPAGLabel.TabIndex = 14;
            pAGAMENTO_TIPOPAGLabel.Text = "TIPO PAG.";
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.AllowUserToOrderColumns = true;
            this.dgView.AutoGenerateColumns = false;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pAGAMENTOIDDataGridViewTextBoxColumn,
            this.pAGAMENTODATADataGridViewTextBoxColumn,
            this.pAGAMENTOVENCIMENTODataGridViewTextBoxColumn,
            this.pAGAMENTOVALORPAGARDataGridViewTextBoxColumn,
            this.pAGAMENTOVALORPAGODataGridViewTextBoxColumn,
            this.pAGAMENTOBENEFICIARIODataGridViewTextBoxColumn,
            this.pAGAMENTOPAGADORDataGridViewTextBoxColumn,
            this.pAGAMENTOMETODOPAGDataGridViewTextBoxColumn,
            this.pAGAMENTOFORMAPAGDataGridViewTextBoxColumn,
            this.pAGAMENTOTIPOPAGDataGridViewTextBoxColumn});
            this.dgView.DataSource = this.bSource;
            this.dgView.Location = new System.Drawing.Point(3, 3);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgView.Size = new System.Drawing.Size(583, 208);
            this.dgView.TabIndex = 1;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            // 
            // dpData
            // 
            this.dpData.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bSource, "PAGAMENTO_DATA", true));
            this.dpData.Location = new System.Drawing.Point(70, 12);
            this.dpData.Name = "dpData";
            this.dpData.Size = new System.Drawing.Size(212, 20);
            this.dpData.TabIndex = 1;
            // 
            // dpVencimento
            // 
            this.dpVencimento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bSource, "PAGAMENTO_VENCIMENTO", true));
            this.dpVencimento.Location = new System.Drawing.Point(366, 12);
            this.dpVencimento.Name = "dpVencimento";
            this.dpVencimento.Size = new System.Drawing.Size(214, 20);
            this.dpVencimento.TabIndex = 3;
            // 
            // pAGAMENTO_VALORPAGARTextBox
            // 
            this.pAGAMENTO_VALORPAGARTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.pAGAMENTO_VALORPAGARTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSource, "PAGAMENTO_VALORPAGAR", true));
            this.pAGAMENTO_VALORPAGARTextBox.Location = new System.Drawing.Point(95, 38);
            this.pAGAMENTO_VALORPAGARTextBox.Name = "pAGAMENTO_VALORPAGARTextBox";
            this.pAGAMENTO_VALORPAGARTextBox.Size = new System.Drawing.Size(98, 20);
            this.pAGAMENTO_VALORPAGARTextBox.TabIndex = 7;
            // 
            // pAGAMENTO_VALORPAGOTextBox
            // 
            this.pAGAMENTO_VALORPAGOTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.pAGAMENTO_VALORPAGOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSource, "PAGAMENTO_VALORPAGO", true));
            this.pAGAMENTO_VALORPAGOTextBox.Location = new System.Drawing.Point(281, 38);
            this.pAGAMENTO_VALORPAGOTextBox.Name = "pAGAMENTO_VALORPAGOTextBox";
            this.pAGAMENTO_VALORPAGOTextBox.Size = new System.Drawing.Size(102, 20);
            this.pAGAMENTO_VALORPAGOTextBox.TabIndex = 8;
            // 
            // tbPagador
            // 
            this.tbPagador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPagador.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSource, "PAGAMENTO_PAGADOR", true));
            this.tbPagador.Location = new System.Drawing.Point(95, 64);
            this.tbPagador.Name = "tbPagador";
            this.tbPagador.Size = new System.Drawing.Size(452, 20);
            this.tbPagador.TabIndex = 9;
            // 
            // tbMetodoPag
            // 
            this.tbMetodoPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMetodoPag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSource, "PAGAMENTO_METODOPAG", true));
            this.tbMetodoPag.Location = new System.Drawing.Point(375, 91);
            this.tbMetodoPag.Name = "tbMetodoPag";
            this.tbMetodoPag.Size = new System.Drawing.Size(172, 20);
            this.tbMetodoPag.TabIndex = 11;
            // 
            // tbFormaPag
            // 
            this.tbFormaPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbFormaPag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSource, "PAGAMENTO_FORMAPAG", true));
            this.tbFormaPag.Location = new System.Drawing.Point(95, 118);
            this.tbFormaPag.Name = "tbFormaPag";
            this.tbFormaPag.Size = new System.Drawing.Size(152, 20);
            this.tbFormaPag.TabIndex = 12;
            // 
            // tbTipoPag
            // 
            this.tbTipoPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTipoPag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSource, "PAGAMENTO_TIPOPAG", true));
            this.tbTipoPag.Location = new System.Drawing.Point(375, 118);
            this.tbTipoPag.Name = "tbTipoPag";
            this.tbTipoPag.Size = new System.Drawing.Size(172, 20);
            this.tbTipoPag.TabIndex = 13;
            // 
            // tbDataPag
            // 
            this.tbDataPag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSource, "PAGAMENTO_DATA", true));
            this.tbDataPag.Location = new System.Drawing.Point(70, 12);
            this.tbDataPag.Name = "tbDataPag";
            this.tbDataPag.Size = new System.Drawing.Size(211, 20);
            this.tbDataPag.TabIndex = 5;
            // 
            // tbDataVencimento
            // 
            this.tbDataVencimento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSource, "PAGAMENTO_VENCIMENTO", true));
            this.tbDataVencimento.Location = new System.Drawing.Point(366, 12);
            this.tbDataVencimento.Name = "tbDataVencimento";
            this.tbDataVencimento.Size = new System.Drawing.Size(214, 20);
            this.tbDataVencimento.TabIndex = 6;
            // 
            // beneficiarioBindingSource
            // 
            this.beneficiarioBindingSource.DataSource = typeof(Classes.Entidades.Beneficiario);
            // 
            // pAGAMENTO_BENEFICIARIOLabel
            // 
            pAGAMENTO_BENEFICIARIOLabel.AutoSize = true;
            pAGAMENTO_BENEFICIARIOLabel.Location = new System.Drawing.Point(6, 95);
            pAGAMENTO_BENEFICIARIOLabel.Name = "pAGAMENTO_BENEFICIARIOLabel";
            pAGAMENTO_BENEFICIARIOLabel.Size = new System.Drawing.Size(81, 13);
            pAGAMENTO_BENEFICIARIOLabel.TabIndex = 18;
            pAGAMENTO_BENEFICIARIOLabel.Text = "BENEFICIÁRIO";
            // 
            // tbBeneficiario
            // 
            this.tbBeneficiario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbBeneficiario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSource, "PAGAMENTO_BENEFICIARIO", true));
            this.tbBeneficiario.Location = new System.Drawing.Point(95, 91);
            this.tbBeneficiario.Name = "tbBeneficiario";
            this.tbBeneficiario.Size = new System.Drawing.Size(152, 20);
            this.tbBeneficiario.TabIndex = 10;
            // 
            // pagadorBindingSource
            // 
            this.pagadorBindingSource.DataSource = typeof(Classes.Entidades.Pagador);
            // 
            // metodoPagBindingSource
            // 
            this.metodoPagBindingSource.DataSource = typeof(Classes.Entidades.Metodo_Pag);
            // 
            // formaPagBindingSource
            // 
            this.formaPagBindingSource.DataSource = typeof(Classes.Entidades.Forma_Pag);
            // 
            // tipoPagBindingSource
            // 
            this.tipoPagBindingSource.DataSource = typeof(Classes.Entidades.Tipo_Pag);
            // 
            // pAGAMENTOIDDataGridViewTextBoxColumn
            // 
            this.pAGAMENTOIDDataGridViewTextBoxColumn.DataPropertyName = "PAGAMENTO_ID";
            this.pAGAMENTOIDDataGridViewTextBoxColumn.HeaderText = "PAGAMENTO_ID";
            this.pAGAMENTOIDDataGridViewTextBoxColumn.Name = "pAGAMENTOIDDataGridViewTextBoxColumn";
            this.pAGAMENTOIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pAGAMENTODATADataGridViewTextBoxColumn
            // 
            this.pAGAMENTODATADataGridViewTextBoxColumn.DataPropertyName = "PAGAMENTO_DATA";
            this.pAGAMENTODATADataGridViewTextBoxColumn.HeaderText = "PAGAMENTO_DATA";
            this.pAGAMENTODATADataGridViewTextBoxColumn.Name = "pAGAMENTODATADataGridViewTextBoxColumn";
            this.pAGAMENTODATADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pAGAMENTOVENCIMENTODataGridViewTextBoxColumn
            // 
            this.pAGAMENTOVENCIMENTODataGridViewTextBoxColumn.DataPropertyName = "PAGAMENTO_VENCIMENTO";
            this.pAGAMENTOVENCIMENTODataGridViewTextBoxColumn.HeaderText = "PAGAMENTO_VENCIMENTO";
            this.pAGAMENTOVENCIMENTODataGridViewTextBoxColumn.Name = "pAGAMENTOVENCIMENTODataGridViewTextBoxColumn";
            this.pAGAMENTOVENCIMENTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pAGAMENTOVALORPAGARDataGridViewTextBoxColumn
            // 
            this.pAGAMENTOVALORPAGARDataGridViewTextBoxColumn.DataPropertyName = "PAGAMENTO_VALORPAGAR";
            this.pAGAMENTOVALORPAGARDataGridViewTextBoxColumn.HeaderText = "PAGAMENTO_VALORPAGAR";
            this.pAGAMENTOVALORPAGARDataGridViewTextBoxColumn.Name = "pAGAMENTOVALORPAGARDataGridViewTextBoxColumn";
            this.pAGAMENTOVALORPAGARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pAGAMENTOVALORPAGODataGridViewTextBoxColumn
            // 
            this.pAGAMENTOVALORPAGODataGridViewTextBoxColumn.DataPropertyName = "PAGAMENTO_VALORPAGO";
            this.pAGAMENTOVALORPAGODataGridViewTextBoxColumn.HeaderText = "PAGAMENTO_VALORPAGO";
            this.pAGAMENTOVALORPAGODataGridViewTextBoxColumn.Name = "pAGAMENTOVALORPAGODataGridViewTextBoxColumn";
            this.pAGAMENTOVALORPAGODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pAGAMENTOBENEFICIARIODataGridViewTextBoxColumn
            // 
            this.pAGAMENTOBENEFICIARIODataGridViewTextBoxColumn.DataPropertyName = "PAGAMENTO_BENEFICIARIO";
            this.pAGAMENTOBENEFICIARIODataGridViewTextBoxColumn.DataSource = this.beneficiarioBindingSource;
            this.pAGAMENTOBENEFICIARIODataGridViewTextBoxColumn.DisplayMember = "BENEFICIARIO_NOMEFAN";
            this.pAGAMENTOBENEFICIARIODataGridViewTextBoxColumn.HeaderText = "PAGAMENTO_BENEFICIARIO";
            this.pAGAMENTOBENEFICIARIODataGridViewTextBoxColumn.Name = "pAGAMENTOBENEFICIARIODataGridViewTextBoxColumn";
            this.pAGAMENTOBENEFICIARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.pAGAMENTOBENEFICIARIODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pAGAMENTOBENEFICIARIODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pAGAMENTOBENEFICIARIODataGridViewTextBoxColumn.ValueMember = "BENEFICIARIO_ID";
            // 
            // pAGAMENTOPAGADORDataGridViewTextBoxColumn
            // 
            this.pAGAMENTOPAGADORDataGridViewTextBoxColumn.DataPropertyName = "PAGAMENTO_PAGADOR";
            this.pAGAMENTOPAGADORDataGridViewTextBoxColumn.DataSource = this.pagadorBindingSource;
            this.pAGAMENTOPAGADORDataGridViewTextBoxColumn.DisplayMember = "PAGADOR_NOME";
            this.pAGAMENTOPAGADORDataGridViewTextBoxColumn.HeaderText = "PAGAMENTO_PAGADOR";
            this.pAGAMENTOPAGADORDataGridViewTextBoxColumn.Name = "pAGAMENTOPAGADORDataGridViewTextBoxColumn";
            this.pAGAMENTOPAGADORDataGridViewTextBoxColumn.ReadOnly = true;
            this.pAGAMENTOPAGADORDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pAGAMENTOPAGADORDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pAGAMENTOPAGADORDataGridViewTextBoxColumn.ValueMember = "PAGADOR_ID";
            // 
            // pAGAMENTOMETODOPAGDataGridViewTextBoxColumn
            // 
            this.pAGAMENTOMETODOPAGDataGridViewTextBoxColumn.DataPropertyName = "PAGAMENTO_METODOPAG";
            this.pAGAMENTOMETODOPAGDataGridViewTextBoxColumn.DataSource = this.metodoPagBindingSource;
            this.pAGAMENTOMETODOPAGDataGridViewTextBoxColumn.DisplayMember = "METODO_PAG_DESCRICAO";
            this.pAGAMENTOMETODOPAGDataGridViewTextBoxColumn.HeaderText = "PAGAMENTO_METODOPAG";
            this.pAGAMENTOMETODOPAGDataGridViewTextBoxColumn.Name = "pAGAMENTOMETODOPAGDataGridViewTextBoxColumn";
            this.pAGAMENTOMETODOPAGDataGridViewTextBoxColumn.ReadOnly = true;
            this.pAGAMENTOMETODOPAGDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pAGAMENTOMETODOPAGDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pAGAMENTOMETODOPAGDataGridViewTextBoxColumn.ValueMember = "METODO_PAG_ID";
            // 
            // pAGAMENTOFORMAPAGDataGridViewTextBoxColumn
            // 
            this.pAGAMENTOFORMAPAGDataGridViewTextBoxColumn.DataPropertyName = "PAGAMENTO_FORMAPAG";
            this.pAGAMENTOFORMAPAGDataGridViewTextBoxColumn.DataSource = this.formaPagBindingSource;
            this.pAGAMENTOFORMAPAGDataGridViewTextBoxColumn.DisplayMember = "FORMA_PAG_DESCRICAO";
            this.pAGAMENTOFORMAPAGDataGridViewTextBoxColumn.HeaderText = "PAGAMENTO_FORMAPAG";
            this.pAGAMENTOFORMAPAGDataGridViewTextBoxColumn.Name = "pAGAMENTOFORMAPAGDataGridViewTextBoxColumn";
            this.pAGAMENTOFORMAPAGDataGridViewTextBoxColumn.ReadOnly = true;
            this.pAGAMENTOFORMAPAGDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pAGAMENTOFORMAPAGDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pAGAMENTOFORMAPAGDataGridViewTextBoxColumn.ValueMember = "FORMA_PAG_ID";
            // 
            // pAGAMENTOTIPOPAGDataGridViewTextBoxColumn
            // 
            this.pAGAMENTOTIPOPAGDataGridViewTextBoxColumn.DataPropertyName = "PAGAMENTO_TIPOPAG";
            this.pAGAMENTOTIPOPAGDataGridViewTextBoxColumn.DataSource = this.tipoPagBindingSource;
            this.pAGAMENTOTIPOPAGDataGridViewTextBoxColumn.DisplayMember = "TIPO_PAG_DESCRICAO";
            this.pAGAMENTOTIPOPAGDataGridViewTextBoxColumn.HeaderText = "PAGAMENTO_TIPOPAG";
            this.pAGAMENTOTIPOPAGDataGridViewTextBoxColumn.Name = "pAGAMENTOTIPOPAGDataGridViewTextBoxColumn";
            this.pAGAMENTOTIPOPAGDataGridViewTextBoxColumn.ReadOnly = true;
            this.pAGAMENTOTIPOPAGDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pAGAMENTOTIPOPAGDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pAGAMENTOTIPOPAGDataGridViewTextBoxColumn.ValueMember = "TIPO_PAG_ID";
            // 
            // cbBeneficiario
            // 
            this.cbBeneficiario.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bSource, "PAGAMENTO_BENEFICIARIO", true));
            this.cbBeneficiario.DataSource = this.beneficiarioBindingSource;
            this.cbBeneficiario.DisplayMember = "BENEFICIARIO_NOMEFAN";
            this.cbBeneficiario.FormattingEnabled = true;
            this.cbBeneficiario.Location = new System.Drawing.Point(95, 91);
            this.cbBeneficiario.Name = "cbBeneficiario";
            this.cbBeneficiario.Size = new System.Drawing.Size(186, 21);
            this.cbBeneficiario.TabIndex = 21;
            this.cbBeneficiario.ValueMember = "BENEFICIARIO_ID";
            // 
            // cbFormaPag
            // 
            this.cbFormaPag.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bSource, "PAGAMENTO_FORMAPAG", true));
            this.cbFormaPag.DataSource = this.formaPagBindingSource;
            this.cbFormaPag.DisplayMember = "FORMA_PAG_DESCRICAO";
            this.cbFormaPag.FormattingEnabled = true;
            this.cbFormaPag.Location = new System.Drawing.Point(95, 118);
            this.cbFormaPag.Name = "cbFormaPag";
            this.cbFormaPag.Size = new System.Drawing.Size(186, 21);
            this.cbFormaPag.TabIndex = 22;
            this.cbFormaPag.ValueMember = "FORMA_PAG_ID";
            // 
            // cbMetodoPag
            // 
            this.cbMetodoPag.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bSource, "PAGAMENTO_METODOPAG", true));
            this.cbMetodoPag.DataSource = this.metodoPagBindingSource;
            this.cbMetodoPag.DisplayMember = "METODO_PAG_DESCRICAO";
            this.cbMetodoPag.FormattingEnabled = true;
            this.cbMetodoPag.Location = new System.Drawing.Point(375, 91);
            this.cbMetodoPag.Name = "cbMetodoPag";
            this.cbMetodoPag.Size = new System.Drawing.Size(205, 21);
            this.cbMetodoPag.TabIndex = 23;
            this.cbMetodoPag.ValueMember = "METODO_PAG_ID";
            // 
            // cbPagador
            // 
            this.cbPagador.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bSource, "PAGAMENTO_PAGADOR", true));
            this.cbPagador.DataSource = this.pagadorBindingSource;
            this.cbPagador.DisplayMember = "PAGADOR_NOME";
            this.cbPagador.FormattingEnabled = true;
            this.cbPagador.Location = new System.Drawing.Point(95, 64);
            this.cbPagador.Name = "cbPagador";
            this.cbPagador.Size = new System.Drawing.Size(485, 21);
            this.cbPagador.TabIndex = 24;
            this.cbPagador.ValueMember = "PAGADOR_ID";
            // 
            // cbTipoPag
            // 
            this.cbTipoPag.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bSource, "PAGAMENTO_TIPOPAG", true));
            this.cbTipoPag.DataSource = this.tipoPagBindingSource;
            this.cbTipoPag.DisplayMember = "TIPO_PAG_DESCRICAO";
            this.cbTipoPag.FormattingEnabled = true;
            this.cbTipoPag.Location = new System.Drawing.Point(375, 118);
            this.cbTipoPag.Name = "cbTipoPag";
            this.cbTipoPag.Size = new System.Drawing.Size(205, 21);
            this.cbTipoPag.TabIndex = 25;
            this.cbTipoPag.ValueMember = "TIPO_PAG_ID";
            // 
            // frmCadPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(611, 546);
            this.Name = "frmCadPagamento";
            this.Text = "Cadastro de pagamento";
            this.Load += new System.EventHandler(this.frmCadPagamento_Load);
            this.tpCadastro.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPagBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.TextBox tbPagador;
        private System.Windows.Forms.TextBox pAGAMENTO_VALORPAGOTextBox;
        private System.Windows.Forms.TextBox pAGAMENTO_VALORPAGARTextBox;
        private System.Windows.Forms.DateTimePicker dpVencimento;
        private System.Windows.Forms.DateTimePicker dpData;
        private System.Windows.Forms.TextBox tbFormaPag;
        private System.Windows.Forms.TextBox tbMetodoPag;
        private System.Windows.Forms.TextBox tbTipoPag;
        private System.Windows.Forms.TextBox tbDataVencimento;
        private System.Windows.Forms.TextBox tbDataPag;
        private System.Windows.Forms.BindingSource beneficiarioBindingSource;
        private System.Windows.Forms.TextBox tbBeneficiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAGAMENTOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAGAMENTODATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAGAMENTOVENCIMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAGAMENTOVALORPAGARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAGAMENTOVALORPAGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pAGAMENTOBENEFICIARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pAGAMENTOPAGADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pagadorBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn pAGAMENTOMETODOPAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource metodoPagBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn pAGAMENTOFORMAPAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource formaPagBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn pAGAMENTOTIPOPAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tipoPagBindingSource;
        private System.Windows.Forms.ComboBox cbTipoPag;
        private System.Windows.Forms.ComboBox cbPagador;
        private System.Windows.Forms.ComboBox cbMetodoPag;
        private System.Windows.Forms.ComboBox cbFormaPag;
        private System.Windows.Forms.ComboBox cbBeneficiario;
    }
}
