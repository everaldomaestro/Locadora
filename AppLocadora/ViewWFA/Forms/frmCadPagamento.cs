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
            AtivarControles(true);
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
        }
        
        private void AtivarControles(bool cmd)
        {
            btnPrimeiro.Enabled = cmd;
            btnAnterior.Enabled = cmd;
            btnProximo.Enabled = cmd;
            btnUltimo.Enabled = cmd;

            btnNovo.Enabled = cmd;
            btnSalvar.Enabled = !cmd;
            btnEditar.Enabled = cmd;
            btnRemover.Enabled = cmd;
            btnCancelar.Enabled = !cmd;
            btnAtualizar.Enabled = cmd;            
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
            tbPagador.Visible = true;
            tbBeneficiario.Visible = true;
            tbMetodoPag.Visible = true;
            tbFormaPag.Visible = true;
            tbTipoPag.Visible = true;

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
            AtivarControles(false);
            BloquearEdicaoDados(false);

            bSource.AddNew();

            dgView.CurrentRow.Cells[5].Value = dgView.Rows[0].Cells[5].Value.ToString();
            dgView.CurrentRow.Cells[6].Value = dgView.Rows[0].Cells[6].Value.ToString();
            dgView.CurrentRow.Cells[7].Value = dgView.Rows[0].Cells[7].Value.ToString();
            dgView.CurrentRow.Cells[8].Value = dgView.Rows[0].Cells[8].Value.ToString();
            dgView.CurrentRow.Cells[9].Value = dgView.Rows[0].Cells[9].Value.ToString();

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
                model.PAGAMENTO_VALORPAGAR = decimal.Parse(pAGAMENTO_VALORPAGARTextBox.Text);
                model.PAGAMENTO_VALORPAGO = decimal.Parse(pAGAMENTO_VALORPAGOTextBox.Text);
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
                model.PAGAMENTO_VALORPAGAR = decimal.Parse(pAGAMENTO_VALORPAGARTextBox.Text);
                model.PAGAMENTO_VALORPAGO = decimal.Parse(pAGAMENTO_VALORPAGOTextBox.Text);
                model.PAGAMENTO_BENEFICIARIO = int.Parse(tbBeneficiario.Text);
                model.PAGAMENTO_PAGADOR = int.Parse(tbPagador.Text);
                model.PAGAMENTO_METODOPAG = int.Parse(tbMetodoPag.Text);
                model.PAGAMENTO_FORMAPAG = int.Parse(tbFormaPag.Text);
                model.PAGAMENTO_TIPOPAG = int.Parse(tbTipoPag.Text);

                ModelController.Atualizar(model);
            }

            CarregarDados();
            AtivarControles(true);
            BloquearEdicaoDados(true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            operacao = Operacao.editarRegistro;
            AtivarControles(false);
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
                CarregarDados();
                MessageBox.Show("Exclusão executada", "Exclusão",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Exclusão cancelada", "Exclusão", 
                    MessageBoxButtons.OK ,MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bSource.CancelEdit();
            CarregarDados();
            AtivarControles(true);
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
    }
}
