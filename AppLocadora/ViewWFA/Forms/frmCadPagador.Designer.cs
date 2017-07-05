namespace ViewWFA.Forms
{
    partial class frmCadPagador
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
            System.Windows.Forms.Label pAGADOR_CNPJCPFLabel;
            System.Windows.Forms.Label pAGADOR_NOMELabel;
            this.dgView = new System.Windows.Forms.DataGridView();
            this.pAGADOR_CNPJCPFTextBox = new System.Windows.Forms.TextBox();
            this.pAGADOR_NOMETextBox = new System.Windows.Forms.TextBox();
            this.pAGADORIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAGADORCNPJCPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAGADORNOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pAGADOR_CNPJCPFLabel = new System.Windows.Forms.Label();
            pAGADOR_NOMELabel = new System.Windows.Forms.Label();
            this.tpCadastro.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // tpCadastro
            // 
            this.tpCadastro.AutoScroll = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgView);
            this.panel2.Size = new System.Drawing.Size(589, 351);
            this.panel2.Controls.SetChildIndex(this.gbDados, 0);
            this.panel2.Controls.SetChildIndex(this.dgView, 0);
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(pAGADOR_NOMELabel);
            this.gbDados.Controls.Add(this.pAGADOR_NOMETextBox);
            this.gbDados.Controls.Add(pAGADOR_CNPJCPFLabel);
            this.gbDados.Controls.Add(this.pAGADOR_CNPJCPFTextBox);
            this.gbDados.Location = new System.Drawing.Point(3, 269);
            this.gbDados.Size = new System.Drawing.Size(583, 73);
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
            this.bSource.DataSource = typeof(Classes.Entidades.Pagador);
            // 
            // pAGADOR_CNPJCPFLabel
            // 
            pAGADOR_CNPJCPFLabel.AutoSize = true;
            pAGADOR_CNPJCPFLabel.Location = new System.Drawing.Point(6, 19);
            pAGADOR_CNPJCPFLabel.Name = "pAGADOR_CNPJCPFLabel";
            pAGADOR_CNPJCPFLabel.Size = new System.Drawing.Size(27, 13);
            pAGADOR_CNPJCPFLabel.TabIndex = 0;
            pAGADOR_CNPJCPFLabel.Text = "CPF";
            // 
            // pAGADOR_NOMELabel
            // 
            pAGADOR_NOMELabel.AutoSize = true;
            pAGADOR_NOMELabel.Location = new System.Drawing.Point(6, 45);
            pAGADOR_NOMELabel.Name = "pAGADOR_NOMELabel";
            pAGADOR_NOMELabel.Size = new System.Drawing.Size(39, 13);
            pAGADOR_NOMELabel.TabIndex = 2;
            pAGADOR_NOMELabel.Text = "NOME";
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.AllowUserToOrderColumns = true;
            this.dgView.AutoGenerateColumns = false;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pAGADORIDDataGridViewTextBoxColumn,
            this.pAGADORCNPJCPFDataGridViewTextBoxColumn,
            this.pAGADORNOMEDataGridViewTextBoxColumn});
            this.dgView.DataSource = this.bSource;
            this.dgView.Location = new System.Drawing.Point(3, 3);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgView.Size = new System.Drawing.Size(583, 260);
            this.dgView.TabIndex = 1;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            // 
            // pAGADOR_CNPJCPFTextBox
            // 
            this.pAGADOR_CNPJCPFTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.pAGADOR_CNPJCPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSource, "PAGADOR_CNPJCPF", true));
            this.pAGADOR_CNPJCPFTextBox.Location = new System.Drawing.Point(51, 16);
            this.pAGADOR_CNPJCPFTextBox.Name = "pAGADOR_CNPJCPFTextBox";
            this.pAGADOR_CNPJCPFTextBox.Size = new System.Drawing.Size(142, 20);
            this.pAGADOR_CNPJCPFTextBox.TabIndex = 1;
            // 
            // pAGADOR_NOMETextBox
            // 
            this.pAGADOR_NOMETextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.pAGADOR_NOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSource, "PAGADOR_NOME", true));
            this.pAGADOR_NOMETextBox.Location = new System.Drawing.Point(51, 42);
            this.pAGADOR_NOMETextBox.Name = "pAGADOR_NOMETextBox";
            this.pAGADOR_NOMETextBox.Size = new System.Drawing.Size(526, 20);
            this.pAGADOR_NOMETextBox.TabIndex = 3;
            // 
            // pAGADORIDDataGridViewTextBoxColumn
            // 
            this.pAGADORIDDataGridViewTextBoxColumn.DataPropertyName = "PAGADOR_ID";
            this.pAGADORIDDataGridViewTextBoxColumn.HeaderText = "PAGADOR_ID";
            this.pAGADORIDDataGridViewTextBoxColumn.Name = "pAGADORIDDataGridViewTextBoxColumn";
            this.pAGADORIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pAGADORIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pAGADORCNPJCPFDataGridViewTextBoxColumn
            // 
            this.pAGADORCNPJCPFDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pAGADORCNPJCPFDataGridViewTextBoxColumn.DataPropertyName = "PAGADOR_CNPJCPF";
            this.pAGADORCNPJCPFDataGridViewTextBoxColumn.HeaderText = "CNPJ/CPF";
            this.pAGADORCNPJCPFDataGridViewTextBoxColumn.Name = "pAGADORCNPJCPFDataGridViewTextBoxColumn";
            this.pAGADORCNPJCPFDataGridViewTextBoxColumn.ReadOnly = true;
            this.pAGADORCNPJCPFDataGridViewTextBoxColumn.Width = 84;
            // 
            // pAGADORNOMEDataGridViewTextBoxColumn
            // 
            this.pAGADORNOMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pAGADORNOMEDataGridViewTextBoxColumn.DataPropertyName = "PAGADOR_NOME";
            this.pAGADORNOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.pAGADORNOMEDataGridViewTextBoxColumn.Name = "pAGADORNOMEDataGridViewTextBoxColumn";
            this.pAGADORNOMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmCadPagador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(611, 520);
            this.Name = "frmCadPagador";
            this.Text = "Cadastro de pagador";
            this.Load += new System.EventHandler(this.frmCadPagador_Load);
            this.tpCadastro.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.TextBox pAGADOR_NOMETextBox;
        private System.Windows.Forms.TextBox pAGADOR_CNPJCPFTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAGADORIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAGADORCNPJCPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAGADORNOMEDataGridViewTextBoxColumn;
    }
}
