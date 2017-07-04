namespace ViewWFA.Forms
{
    partial class frmCadBeneficiario
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
            System.Windows.Forms.Label bENEFICIARIO_CNPJCPFLabel;
            System.Windows.Forms.Label bENEFICIARIO_NOMEFANLabel;
            System.Windows.Forms.Label bENEFICIARIO_RAZAOSOCLabel;
            this.beneficiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bENEFICIARIO_CNPJCPFTextBox = new System.Windows.Forms.TextBox();
            this.bENEFICIARIO_NOMEFANTextBox = new System.Windows.Forms.TextBox();
            this.bENEFICIARIO_RAZAOSOCTextBox = new System.Windows.Forms.TextBox();
            bENEFICIARIO_CNPJCPFLabel = new System.Windows.Forms.Label();
            bENEFICIARIO_NOMEFANLabel = new System.Windows.Forms.Label();
            bENEFICIARIO_RAZAOSOCLabel = new System.Windows.Forms.Label();
            this.tpCadastro.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource)).BeginInit();
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
            this.gbDados.Controls.Add(bENEFICIARIO_RAZAOSOCLabel);
            this.gbDados.Controls.Add(this.bENEFICIARIO_RAZAOSOCTextBox);
            this.gbDados.Controls.Add(bENEFICIARIO_NOMEFANLabel);
            this.gbDados.Controls.Add(this.bENEFICIARIO_NOMEFANTextBox);
            this.gbDados.Controls.Add(bENEFICIARIO_CNPJCPFLabel);
            this.gbDados.Controls.Add(this.bENEFICIARIO_CNPJCPFTextBox);
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
            // bENEFICIARIO_CNPJCPFLabel
            // 
            bENEFICIARIO_CNPJCPFLabel.AutoSize = true;
            bENEFICIARIO_CNPJCPFLabel.Location = new System.Drawing.Point(6, 18);
            bENEFICIARIO_CNPJCPFLabel.Name = "bENEFICIARIO_CNPJCPFLabel";
            bENEFICIARIO_CNPJCPFLabel.Size = new System.Drawing.Size(59, 13);
            bENEFICIARIO_CNPJCPFLabel.TabIndex = 0;
            bENEFICIARIO_CNPJCPFLabel.Text = "CNPJ/CPF";
            // 
            // bENEFICIARIO_NOMEFANLabel
            // 
            bENEFICIARIO_NOMEFANLabel.AutoSize = true;
            bENEFICIARIO_NOMEFANLabel.Location = new System.Drawing.Point(252, 18);
            bENEFICIARIO_NOMEFANLabel.Name = "bENEFICIARIO_NOMEFANLabel";
            bENEFICIARIO_NOMEFANLabel.Size = new System.Drawing.Size(53, 13);
            bENEFICIARIO_NOMEFANLabel.TabIndex = 2;
            bENEFICIARIO_NOMEFANLabel.Text = "APELIDO";
            // 
            // bENEFICIARIO_RAZAOSOCLabel
            // 
            bENEFICIARIO_RAZAOSOCLabel.AutoSize = true;
            bENEFICIARIO_RAZAOSOCLabel.Location = new System.Drawing.Point(6, 44);
            bENEFICIARIO_RAZAOSOCLabel.Name = "bENEFICIARIO_RAZAOSOCLabel";
            bENEFICIARIO_RAZAOSOCLabel.Size = new System.Drawing.Size(85, 13);
            bENEFICIARIO_RAZAOSOCLabel.TabIndex = 4;
            bENEFICIARIO_RAZAOSOCLabel.Text = "RAZÃO SOCIAL";
            // 
            // beneficiarioBindingSource
            // 
            this.beneficiarioBindingSource.DataSource = typeof(Classes.Entidades.Beneficiario);
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.AllowUserToOrderColumns = true;
            this.dgView.AutoGenerateColumns = false;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.dgView.DataSource = this.bSource;
            this.dgView.Location = new System.Drawing.Point(3, 3);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgView.Size = new System.Drawing.Size(583, 260);
            this.dgView.TabIndex = 1;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BENEFICIARIO_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BENEFICIARIO_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BENEFICIARIO_CNPJCPF";
            this.dataGridViewTextBoxColumn2.HeaderText = "CNPJ/CPF";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 84;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BENEFICIARIO_NOMEFAN";
            this.dataGridViewTextBoxColumn4.HeaderText = "APELIDO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 78;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BENEFICIARIO_RAZAOSOC";
            this.dataGridViewTextBoxColumn3.HeaderText = "RAZÃO SOCIAL";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // bENEFICIARIO_CNPJCPFTextBox
            // 
            this.bENEFICIARIO_CNPJCPFTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bENEFICIARIO_CNPJCPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSource, "BENEFICIARIO_CNPJCPF", true));
            this.bENEFICIARIO_CNPJCPFTextBox.Location = new System.Drawing.Point(97, 15);
            this.bENEFICIARIO_CNPJCPFTextBox.Name = "bENEFICIARIO_CNPJCPFTextBox";
            this.bENEFICIARIO_CNPJCPFTextBox.Size = new System.Drawing.Size(149, 20);
            this.bENEFICIARIO_CNPJCPFTextBox.TabIndex = 1;
            // 
            // bENEFICIARIO_NOMEFANTextBox
            // 
            this.bENEFICIARIO_NOMEFANTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bENEFICIARIO_NOMEFANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSource, "BENEFICIARIO_NOMEFAN", true));
            this.bENEFICIARIO_NOMEFANTextBox.Location = new System.Drawing.Point(311, 15);
            this.bENEFICIARIO_NOMEFANTextBox.Name = "bENEFICIARIO_NOMEFANTextBox";
            this.bENEFICIARIO_NOMEFANTextBox.Size = new System.Drawing.Size(266, 20);
            this.bENEFICIARIO_NOMEFANTextBox.TabIndex = 3;
            // 
            // bENEFICIARIO_RAZAOSOCTextBox
            // 
            this.bENEFICIARIO_RAZAOSOCTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bENEFICIARIO_RAZAOSOCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSource, "BENEFICIARIO_RAZAOSOC", true));
            this.bENEFICIARIO_RAZAOSOCTextBox.Location = new System.Drawing.Point(97, 41);
            this.bENEFICIARIO_RAZAOSOCTextBox.Name = "bENEFICIARIO_RAZAOSOCTextBox";
            this.bENEFICIARIO_RAZAOSOCTextBox.Size = new System.Drawing.Size(480, 20);
            this.bENEFICIARIO_RAZAOSOCTextBox.TabIndex = 5;
            // 
            // frmCadBeneficiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(611, 520);
            this.Name = "frmCadBeneficiario";
            this.Text = "Cadastro de Beneficiário";
            this.Load += new System.EventHandler(this.frmCadBeneficiario_Load);
            this.tpCadastro.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.BindingSource beneficiarioBindingSource;
        private System.Windows.Forms.TextBox bENEFICIARIO_RAZAOSOCTextBox;
        private System.Windows.Forms.TextBox bENEFICIARIO_NOMEFANTextBox;
        private System.Windows.Forms.TextBox bENEFICIARIO_CNPJCPFTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
