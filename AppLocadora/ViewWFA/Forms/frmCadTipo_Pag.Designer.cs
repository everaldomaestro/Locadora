namespace ViewWFA.Forms
{
    partial class frmCadTipo_Pag
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
            System.Windows.Forms.Label tIPO_PAG_DESCRICAOLabel;
            this.dgView = new System.Windows.Forms.DataGridView();
            this.tIPO_PAG_DESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.tIPOPAGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOPAGDESCRICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tIPO_PAG_DESCRICAOLabel = new System.Windows.Forms.Label();
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
            this.panel2.Size = new System.Drawing.Size(589, 343);
            this.panel2.Controls.SetChildIndex(this.gbDados, 0);
            this.panel2.Controls.SetChildIndex(this.dgView, 0);
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(tIPO_PAG_DESCRICAOLabel);
            this.gbDados.Controls.Add(this.tIPO_PAG_DESCRICAOTextBox);
            this.gbDados.Location = new System.Drawing.Point(3, 299);
            this.gbDados.Size = new System.Drawing.Size(583, 41);
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
            this.bSource.DataSource = typeof(Classes.Entidades.Tipo_Pag);
            // 
            // tIPO_PAG_DESCRICAOLabel
            // 
            tIPO_PAG_DESCRICAOLabel.AutoSize = true;
            tIPO_PAG_DESCRICAOLabel.Location = new System.Drawing.Point(6, 16);
            tIPO_PAG_DESCRICAOLabel.Name = "tIPO_PAG_DESCRICAOLabel";
            tIPO_PAG_DESCRICAOLabel.Size = new System.Drawing.Size(69, 13);
            tIPO_PAG_DESCRICAOLabel.TabIndex = 0;
            tIPO_PAG_DESCRICAOLabel.Text = "DESCRIÇÃO";
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.AllowUserToOrderColumns = true;
            this.dgView.AutoGenerateColumns = false;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIPOPAGIDDataGridViewTextBoxColumn,
            this.tIPOPAGDESCRICAODataGridViewTextBoxColumn});
            this.dgView.DataSource = this.bSource;
            this.dgView.Location = new System.Drawing.Point(3, 3);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgView.Size = new System.Drawing.Size(583, 290);
            this.dgView.TabIndex = 1;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            // 
            // tIPO_PAG_DESCRICAOTextBox
            // 
            this.tIPO_PAG_DESCRICAOTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tIPO_PAG_DESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSource, "TIPO_PAG_DESCRICAO", true));
            this.tIPO_PAG_DESCRICAOTextBox.Location = new System.Drawing.Point(81, 13);
            this.tIPO_PAG_DESCRICAOTextBox.Name = "tIPO_PAG_DESCRICAOTextBox";
            this.tIPO_PAG_DESCRICAOTextBox.Size = new System.Drawing.Size(496, 20);
            this.tIPO_PAG_DESCRICAOTextBox.TabIndex = 1;
            // 
            // tIPOPAGIDDataGridViewTextBoxColumn
            // 
            this.tIPOPAGIDDataGridViewTextBoxColumn.DataPropertyName = "TIPO_PAG_ID";
            this.tIPOPAGIDDataGridViewTextBoxColumn.HeaderText = "TIPO_PAG_ID";
            this.tIPOPAGIDDataGridViewTextBoxColumn.Name = "tIPOPAGIDDataGridViewTextBoxColumn";
            this.tIPOPAGIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tIPOPAGIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tIPOPAGDESCRICAODataGridViewTextBoxColumn
            // 
            this.tIPOPAGDESCRICAODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tIPOPAGDESCRICAODataGridViewTextBoxColumn.DataPropertyName = "TIPO_PAG_DESCRICAO";
            this.tIPOPAGDESCRICAODataGridViewTextBoxColumn.HeaderText = "DESCRIÇÃO";
            this.tIPOPAGDESCRICAODataGridViewTextBoxColumn.Name = "tIPOPAGDESCRICAODataGridViewTextBoxColumn";
            this.tIPOPAGDESCRICAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmCadTipo_Pag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(611, 520);
            this.Name = "frmCadTipo_Pag";
            this.Text = "Cadastro de tipo de pagamento";
            this.Load += new System.EventHandler(this.frmCadTipo_Pag_Load);
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
        private System.Windows.Forms.TextBox tIPO_PAG_DESCRICAOTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOPAGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOPAGDESCRICAODataGridViewTextBoxColumn;
    }
}
