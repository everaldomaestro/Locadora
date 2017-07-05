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
            this.dgView = new System.Windows.Forms.DataGridView();
            this.bENEFICIARIOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bENEFICIARIOCNPJCPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bENEFICIARIORAZAOSOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bENEFICIARIONOMEFANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpCadastro.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.gbDados.Location = new System.Drawing.Point(3, 269);
            this.gbDados.Size = new System.Drawing.Size(583, 70);
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
            this.bSource.DataSource = typeof(Classes.Entidades.Beneficiario);
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.AllowUserToOrderColumns = true;
            this.dgView.AutoGenerateColumns = false;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bENEFICIARIOIDDataGridViewTextBoxColumn,
            this.bENEFICIARIOCNPJCPFDataGridViewTextBoxColumn,
            this.bENEFICIARIORAZAOSOCDataGridViewTextBoxColumn,
            this.bENEFICIARIONOMEFANDataGridViewTextBoxColumn});
            this.dgView.DataSource = this.bSource;
            this.dgView.Location = new System.Drawing.Point(3, 3);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgView.Size = new System.Drawing.Size(583, 260);
            this.dgView.TabIndex = 1;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            // 
            // bENEFICIARIOIDDataGridViewTextBoxColumn
            // 
            this.bENEFICIARIOIDDataGridViewTextBoxColumn.DataPropertyName = "BENEFICIARIO_ID";
            this.bENEFICIARIOIDDataGridViewTextBoxColumn.HeaderText = "BENEFICIARIO_ID";
            this.bENEFICIARIOIDDataGridViewTextBoxColumn.Name = "bENEFICIARIOIDDataGridViewTextBoxColumn";
            this.bENEFICIARIOIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bENEFICIARIOCNPJCPFDataGridViewTextBoxColumn
            // 
            this.bENEFICIARIOCNPJCPFDataGridViewTextBoxColumn.DataPropertyName = "BENEFICIARIO_CNPJCPF";
            this.bENEFICIARIOCNPJCPFDataGridViewTextBoxColumn.HeaderText = "BENEFICIARIO_CNPJCPF";
            this.bENEFICIARIOCNPJCPFDataGridViewTextBoxColumn.Name = "bENEFICIARIOCNPJCPFDataGridViewTextBoxColumn";
            this.bENEFICIARIOCNPJCPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bENEFICIARIORAZAOSOCDataGridViewTextBoxColumn
            // 
            this.bENEFICIARIORAZAOSOCDataGridViewTextBoxColumn.DataPropertyName = "BENEFICIARIO_RAZAOSOC";
            this.bENEFICIARIORAZAOSOCDataGridViewTextBoxColumn.HeaderText = "BENEFICIARIO_RAZAOSOC";
            this.bENEFICIARIORAZAOSOCDataGridViewTextBoxColumn.Name = "bENEFICIARIORAZAOSOCDataGridViewTextBoxColumn";
            this.bENEFICIARIORAZAOSOCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bENEFICIARIONOMEFANDataGridViewTextBoxColumn
            // 
            this.bENEFICIARIONOMEFANDataGridViewTextBoxColumn.DataPropertyName = "BENEFICIARIO_NOMEFAN";
            this.bENEFICIARIONOMEFANDataGridViewTextBoxColumn.HeaderText = "BENEFICIARIO_NOMEFAN";
            this.bENEFICIARIONOMEFANDataGridViewTextBoxColumn.Name = "bENEFICIARIONOMEFANDataGridViewTextBoxColumn";
            this.bENEFICIARIONOMEFANDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmCadPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(611, 520);
            this.Name = "frmCadPagamento";
            this.Text = "Cadastro de Beneficiário";
            this.Load += new System.EventHandler(this.frmCadBeneficiario_Load);
            this.tpCadastro.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn bENEFICIARIOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bENEFICIARIOCNPJCPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bENEFICIARIORAZAOSOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bENEFICIARIONOMEFANDataGridViewTextBoxColumn;
    }
}
