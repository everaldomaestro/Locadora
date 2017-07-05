namespace ViewWFA.Forms
{
    partial class frmCadMetodo_Pag
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
            System.Windows.Forms.Label mETODO_PAG_DESCRICAOLabel;
            this.dgView = new System.Windows.Forms.DataGridView();
            this.mETODO_PAG_DESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.mETODOPAGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mETODOPAGDESCRICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mETODO_PAG_DESCRICAOLabel = new System.Windows.Forms.Label();
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
            this.panel2.Controls.SetChildIndex(this.gbDados, 0);
            this.panel2.Controls.SetChildIndex(this.dgView, 0);
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(mETODO_PAG_DESCRICAOLabel);
            this.gbDados.Controls.Add(this.mETODO_PAG_DESCRICAOTextBox);
            this.gbDados.Location = new System.Drawing.Point(3, 297);
            this.gbDados.Size = new System.Drawing.Size(583, 42);
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
            this.bSource.DataSource = typeof(Classes.Entidades.Metodo_Pag);
            // 
            // mETODO_PAG_DESCRICAOLabel
            // 
            mETODO_PAG_DESCRICAOLabel.AutoSize = true;
            mETODO_PAG_DESCRICAOLabel.Location = new System.Drawing.Point(6, 16);
            mETODO_PAG_DESCRICAOLabel.Name = "mETODO_PAG_DESCRICAOLabel";
            mETODO_PAG_DESCRICAOLabel.Size = new System.Drawing.Size(69, 13);
            mETODO_PAG_DESCRICAOLabel.TabIndex = 0;
            mETODO_PAG_DESCRICAOLabel.Text = "DESCRIÇÃO";
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.AllowUserToOrderColumns = true;
            this.dgView.AutoGenerateColumns = false;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mETODOPAGIDDataGridViewTextBoxColumn,
            this.mETODOPAGDESCRICAODataGridViewTextBoxColumn});
            this.dgView.DataSource = this.bSource;
            this.dgView.Location = new System.Drawing.Point(3, 3);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgView.Size = new System.Drawing.Size(583, 288);
            this.dgView.TabIndex = 1;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            // 
            // mETODO_PAG_DESCRICAOTextBox
            // 
            this.mETODO_PAG_DESCRICAOTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mETODO_PAG_DESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSource, "METODO_PAG_DESCRICAO", true));
            this.mETODO_PAG_DESCRICAOTextBox.Location = new System.Drawing.Point(81, 13);
            this.mETODO_PAG_DESCRICAOTextBox.Name = "mETODO_PAG_DESCRICAOTextBox";
            this.mETODO_PAG_DESCRICAOTextBox.Size = new System.Drawing.Size(496, 20);
            this.mETODO_PAG_DESCRICAOTextBox.TabIndex = 1;
            // 
            // mETODOPAGIDDataGridViewTextBoxColumn
            // 
            this.mETODOPAGIDDataGridViewTextBoxColumn.DataPropertyName = "METODO_PAG_ID";
            this.mETODOPAGIDDataGridViewTextBoxColumn.HeaderText = "METODO_PAG_ID";
            this.mETODOPAGIDDataGridViewTextBoxColumn.Name = "mETODOPAGIDDataGridViewTextBoxColumn";
            this.mETODOPAGIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mETODOPAGIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // mETODOPAGDESCRICAODataGridViewTextBoxColumn
            // 
            this.mETODOPAGDESCRICAODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mETODOPAGDESCRICAODataGridViewTextBoxColumn.DataPropertyName = "METODO_PAG_DESCRICAO";
            this.mETODOPAGDESCRICAODataGridViewTextBoxColumn.HeaderText = "DESCRIÇÃO";
            this.mETODOPAGDESCRICAODataGridViewTextBoxColumn.Name = "mETODOPAGDESCRICAODataGridViewTextBoxColumn";
            this.mETODOPAGDESCRICAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmCadMetodo_Pag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(611, 520);
            this.Name = "frmCadMetodo_Pag";
            this.Text = "Cadastro de métodos de pagamento";
            this.Load += new System.EventHandler(this.frmCadMetodo_Pag_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox mETODO_PAG_DESCRICAOTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn mETODOPAGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mETODOPAGDESCRICAODataGridViewTextBoxColumn;
    }
}
