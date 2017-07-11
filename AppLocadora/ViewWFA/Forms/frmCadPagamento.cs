using Classes.Controller;
using Classes.Entidades;
using System;
using System.Windows.Forms;

namespace ViewWFA.Forms
{
    public partial class frmCadPagamento : ViewWFA.Heranca.frmCadPai
    {
        public frmCadPagamento()
        {
            InitializeComponent();
        }

        private void frmCadPagamento_Load(object sender, EventArgs e)
        {            
            CarregarDados();
            FormatarGrid();
            AtivarControles();
            BloquearEdicaoDados(true);
        }

        private void CarregarDados()
        {
            operacao = Operacao.visualizarRegistro;            
            //Chaves estrangeiras
            BeneficiarioController beneficiarioController = new BeneficiarioController();
            beneficiarioBindingSource.DataSource = beneficiarioController.ListarTudo();
            
            Forma_PagController forma_PagController = new Forma_PagController();
            formaPagBindingSource.DataSource = forma_PagController.ListarTudo();
           
            Metodo_PagController metodo_PagController = new Metodo_PagController();
            metodoPagBindingSource.DataSource = metodo_PagController.ListarTudo();
            
            PagadorController pagadorController = new PagadorController();
            pagadorBindingSource.DataSource = pagadorController.ListarTudo();
            
            Tipo_PagController tipo_PagController = new Tipo_PagController();
            tipoPagBindingSource.DataSource = tipo_PagController.ListarTudo();
            
            PagamentoController ModelController = new PagamentoController();
            bSource.DataSource = ModelController.ListarTudo();
            QtdDados = bSource.Count;
        }
              
        private void BloquearEdicaoDados(bool cmd)
        {
            foreach (Control c in gbDados.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).ReadOnly = cmd;
                }
            }

            tbDataPag.Visible = cmd;
            tbDataVencimento.Visible = cmd;
            tbPagador.Visible = false;
            tbBeneficiario.Visible = false;
            tbMetodoPag.Visible = false;
            tbFormaPag.Visible = false;
            tbTipoPag.Visible = false;

            cbPagador.Enabled = !cmd;
            cbBeneficiario.Enabled = !cmd;
            cbMetodoPag.Enabled = !cmd;
            cbFormaPag.Enabled = !cmd;
            cbTipoPag.Enabled = !cmd;

            dpData.Visible = !cmd;
            dpVencimento.Visible = !cmd;

            if (cmd)
            {
                cbPagador.DropDownStyle = ComboBoxStyle.Simple;
                cbBeneficiario.DropDownStyle = ComboBoxStyle.Simple;
                cbMetodoPag.DropDownStyle = ComboBoxStyle.Simple;
                cbFormaPag.DropDownStyle = ComboBoxStyle.Simple;
                cbTipoPag.DropDownStyle = ComboBoxStyle.Simple;
            }
            else
            {
                cbPagador.DropDownStyle = ComboBoxStyle.DropDownList;
                cbBeneficiario.DropDownStyle = ComboBoxStyle.DropDownList;
                cbMetodoPag.DropDownStyle = ComboBoxStyle.DropDownList;
                cbFormaPag.DropDownStyle = ComboBoxStyle.DropDownList;
                cbTipoPag.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)//ok
        {
            operacao = Operacao.gravarNovo;
            AtivarControles();
            BloquearEdicaoDados(false);

            //Gambi
            cbBeneficiario.SelectedIndex = 0;
            cbPagador.SelectedIndex = 0;
            cbMetodoPag.SelectedIndex = 0;
            cbFormaPag.SelectedIndex = 0;
            cbTipoPag.SelectedIndex = 0;

            int idBeneficiario = (int)cbBeneficiario.SelectedValue;
            int idPagador = (int)cbPagador.SelectedValue;
            int idMetodoPag = (int)cbMetodoPag.SelectedValue;
            int idFormaPag = (int)cbFormaPag.SelectedValue;
            int idTipoPag = (int)cbTipoPag.SelectedValue;
            //Pause Gambi

            bSource.AddNew();

            //Continue Gambi
            dgView.CurrentRow.Cells[5].Value = idBeneficiario;
            dgView.CurrentRow.Cells[6].Value = idPagador;
            dgView.CurrentRow.Cells[7].Value = idMetodoPag;
            dgView.CurrentRow.Cells[8].Value = idFormaPag;
            dgView.CurrentRow.Cells[9].Value = idTipoPag;            
            //Fim Gambi

            dpData.Focus();            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            PagamentoController ModelController = new PagamentoController();
            Pagamento model = new Pagamento();
            if (operacao == Operacao.gravarNovo)
            {
                model.PAGAMENTO_DATA = dpData.Value;
                model.PAGAMENTO_VENCIMENTO = dpVencimento.Value;
                model.PAGAMENTO_VALORPAGAR = decimal.Parse(tbValorPagar.Text);
                model.PAGAMENTO_VALORPAGO = decimal.Parse(tbValorPago.Text);
                model.PAGAMENTO_BENEFICIARIO = int.Parse(tbBeneficiario.Text);
                model.PAGAMENTO_PAGADOR = int.Parse(tbPagador.Text);
                model.PAGAMENTO_METODOPAG = int.Parse(tbMetodoPag.Text);
                model.PAGAMENTO_FORMAPAG = int.Parse(tbFormaPag.Text);
                model.PAGAMENTO_TIPOPAG = int.Parse(tbTipoPag.Text);

                ModelController.Inserir(model);
            }
            else if(operacao == Operacao.editarRegistro)
            {
                model = (Pagamento) bSource.Current;

                model.PAGAMENTO_DATA = dpData.Value;
                model.PAGAMENTO_VENCIMENTO = dpVencimento.Value;
                model.PAGAMENTO_VALORPAGAR = decimal.Parse(tbValorPagar.Text);
                model.PAGAMENTO_VALORPAGO = decimal.Parse(tbValorPago.Text);
                model.PAGAMENTO_BENEFICIARIO = int.Parse(tbBeneficiario.Text);
                model.PAGAMENTO_PAGADOR = int.Parse(tbPagador.Text);
                model.PAGAMENTO_METODOPAG = int.Parse(tbMetodoPag.Text);
                model.PAGAMENTO_FORMAPAG = int.Parse(tbFormaPag.Text);
                model.PAGAMENTO_TIPOPAG = int.Parse(tbTipoPag.Text);

                ModelController.Atualizar(model);
            }

            CarregarDados();
            AtivarControles();
            BloquearEdicaoDados(true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            operacao = Operacao.editarRegistro;
            AtivarControles();
            BloquearEdicaoDados(false);

            dpData.Focus();
        }

        private void btnRemover_Click(object sender, EventArgs e)//OK
        {
            PagamentoController ModelController = new PagamentoController();
            Pagamento model = (Pagamento) bSource.Current;

            if (MessageBox.Show(
                "Tem certeza que deseja excluir o registro Nº: " +
                model.PAGAMENTO_ID + "?", "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                ModelController.Excluir(model.PAGAMENTO_ID);
                MessageBox.Show("Exclusão executada", "Exclusão",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Exclusão cancelada", "Exclusão", 
                    MessageBoxButtons.OK ,MessageBoxIcon.Information);
            }

            CarregarDados();
            AtivarControles();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bSource.CancelEdit();
            CarregarDados();
            AtivarControles();
            BloquearEdicaoDados(true);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)//OK
        {
            CarregarDados();
        }

        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCancelar.PerformClick();
        }

        private void FormatarGrid()
        {
            //Criar combobox "na mão"
            DataGridViewComboBoxColumn ColBeneficiario = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn ColPagador = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn ColMetodoPag = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn ColFormaPag = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn ColTipoPag = new DataGridViewComboBoxColumn();

            ColBeneficiario.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            ColPagador.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            ColMetodoPag.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            ColFormaPag.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            ColTipoPag.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            ColBeneficiario.DataSource = beneficiarioBindingSource;
            ColPagador.DataSource = pagadorBindingSource;
            ColMetodoPag.DataSource = metodoPagBindingSource;
            ColFormaPag.DataSource = formaPagBindingSource;
            ColTipoPag.DataSource = tipoPagBindingSource;

            ColBeneficiario.DataPropertyName = "PAGAMENTO_BENEFICIARIO";
            ColPagador.DataPropertyName = "PAGAMENTO_PAGADOR";
            ColMetodoPag.DataPropertyName = "PAGAMENTO_METODOPAG";
            ColFormaPag.DataPropertyName = "PAGAMENTO_FORMAPAG";
            ColTipoPag.DataPropertyName = "PAGAMENTO_TIPOPAG";

            ColBeneficiario.DisplayMember = "BENEFICIARIO_NOMEFAN";
            ColPagador.DisplayMember = "PAGADOR_NOME";
            ColMetodoPag.DisplayMember = "METODO_PAG_DESCRICAO";
            ColFormaPag.DisplayMember = "FORMA_PAG_DESCRICAO";
            ColTipoPag.DisplayMember = "TIPO_PAG_DESCRICAO";

            ColBeneficiario.ValueMember = "BENEFICIARIO_ID";
            ColPagador.ValueMember = "PAGADOR_ID";
            ColMetodoPag.ValueMember = "METODO_PAG_ID";
            ColFormaPag.ValueMember = "FORMA_PAG_ID";
            ColTipoPag.ValueMember = "TIPO_PAG_ID";

            dgView.Columns.Insert(5, ColBeneficiario);
            dgView.Columns.Insert(6, ColPagador);
            dgView.Columns.Insert(7, ColMetodoPag);
            dgView.Columns.Insert(8, ColFormaPag);
            dgView.Columns.Insert(9, ColTipoPag);

            //Cabeçalho
            dgView.Columns[0].HeaderText = "ID";
            dgView.Columns[1].HeaderText = "DATA PAG";
            dgView.Columns[2].HeaderText = "VENCIMENTO";
            dgView.Columns[3].HeaderText = "VALOR PAGAR";
            dgView.Columns[4].HeaderText = "VALOR PAGO";
            dgView.Columns[5].HeaderText = "BENEFICIÁRIO";
            dgView.Columns[6].HeaderText = "PAGADOR";
            dgView.Columns[7].HeaderText = "METODO PAG";
            dgView.Columns[8].HeaderText = "FORMA PAG";
            dgView.Columns[9].HeaderText = "TIPO PAG";

            //Preenchimento das células      
            dgView.AutoResizeColumns();
            
            //Máscara de dados
            dgView.Columns[3].DefaultCellStyle.Format = "R$ 000.00";
            dgView.Columns[4].DefaultCellStyle.Format = "R$ 000.00";
        }
    }
}
