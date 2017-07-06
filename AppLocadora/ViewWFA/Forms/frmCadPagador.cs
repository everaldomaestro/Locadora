using Classes.Controller;
using Classes.Entidades;
using System;
using System.Windows.Forms;

namespace ViewWFA.Forms
{
    public partial class frmCadPagador : ViewWFA.Heranca.frmCadPai
    {
        public frmCadPagador()
        {
            InitializeComponent();
        }

        private void frmCadPagador_Load(object sender, EventArgs e)
        {
            FormatarGrid();
            CarregarDados();
            AtivarControles(true);
            BloquearEdicaoDados(true);
        }

        private void CarregarDados()
        {
            operacao = Operacao.visualizarRegistro;
            PagadorController ModelController = new PagadorController();
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
        }

        private void btnNovo_Click(object sender, EventArgs e)//ok
        {
            operacao = Operacao.gravarNovo;
            AtivarControles(false);
            BloquearEdicaoDados(false);

            bSource.AddNew();
            pAGADOR_CNPJCPFTextBox.Focus();            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            PagadorController ModelController = new PagadorController();
            Pagador model = new Pagador();
            if (operacao == Operacao.gravarNovo)
            {
                model.PAGADOR_CNPJCPF = pAGADOR_CNPJCPFTextBox.Text;
                model.PAGADOR_NOME = pAGADOR_NOMETextBox.Text;

                ModelController.Inserir(model);
            }
            else if(operacao == Operacao.editarRegistro)
            {
                model = (Pagador) bSource.Current;
                model.PAGADOR_CNPJCPF = pAGADOR_CNPJCPFTextBox.Text;
                model.PAGADOR_NOME = pAGADOR_NOMETextBox.Text;

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

            pAGADOR_CNPJCPFTextBox.Focus();
        }

        private void btnRemover_Click(object sender, EventArgs e)//OK
        {
            PagadorController ModelController = new PagadorController();
            Pagador model = (Pagador) bSource.Current;

            if (MessageBox.Show(
                "Tem certeza que deseja excluir o registro de " +
                model.PAGADOR_NOME + "?", "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                ModelController.Excluir(model.PAGADOR_ID);
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

        private void FormatarGrid()
        {
            //Cabeçalho
            dgView.Columns[0].HeaderText = "ID";
            dgView.Columns[0].Visible = false;
            dgView.Columns[1].HeaderText = "CPF";
            dgView.Columns[2].HeaderText = "NOME";

            //Preenchimento das células
            dgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
