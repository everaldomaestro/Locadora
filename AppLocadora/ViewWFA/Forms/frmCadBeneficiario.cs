using Classes.Controller;
using Classes.Entidades;
using System;
using System.Windows.Forms;

namespace ViewWFA.Forms
{
    public partial class frmCadBeneficiario : Heranca.frmCadPai
    {
        public frmCadBeneficiario()
        {
            InitializeComponent();
        }

        private void frmCadBeneficiario_Load(object sender, EventArgs e)
        {
            FormatarGrid();
            CarregarDados();
            AtivarControles();
            BloquearEdicaoDados(true);
        }

        private void CarregarDados()
        {
            operacao = Operacao.visualizarRegistro;
            BeneficiarioController ModelController = new BeneficiarioController();
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
        }

        private void btnNovo_Click(object sender, EventArgs e)//ok
        {
            operacao = Operacao.gravarNovo;
            AtivarControles();
            BloquearEdicaoDados(false);

            bSource.AddNew();
            bENEFICIARIO_CNPJCPFTextBox.Focus();            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            BeneficiarioController ModelController = new BeneficiarioController();
            Beneficiario model = new Beneficiario();
            if (operacao == Operacao.gravarNovo)
            {
                model.BENEFICIARIO_CNPJCPF = bENEFICIARIO_CNPJCPFTextBox.Text;
                model.BENEFICIARIO_NOMEFAN = bENEFICIARIO_NOMEFANTextBox.Text;
                model.BENEFICIARIO_RAZAOSOC = bENEFICIARIO_RAZAOSOCTextBox.Text;

                ModelController.Inserir(model);
            }
            else if(operacao == Operacao.editarRegistro)
            {
                model = (Beneficiario) bSource.Current;
                model.BENEFICIARIO_CNPJCPF = bENEFICIARIO_CNPJCPFTextBox.Text;
                model.BENEFICIARIO_NOMEFAN = bENEFICIARIO_NOMEFANTextBox.Text;
                model.BENEFICIARIO_RAZAOSOC = bENEFICIARIO_RAZAOSOCTextBox.Text;

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

            bENEFICIARIO_CNPJCPFTextBox.Focus();
        }

        private void btnRemover_Click(object sender, EventArgs e)//OK
        {
            BeneficiarioController ModelController = new BeneficiarioController();
            Beneficiario model = (Beneficiario) bSource.Current;

            if (MessageBox.Show(
                "Tem certeza que deseja excluir o registro de " +
                model.BENEFICIARIO_NOMEFAN + "?", "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                ModelController.Excluir(model.BENEFICIARIO_ID);
                
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
            //Ordenação das colunas
            dgView.Columns[0].DisplayIndex = 0;
            dgView.Columns[1].DisplayIndex = 1;
            dgView.Columns[2].DisplayIndex = 3;
            dgView.Columns[3].DisplayIndex = 2;

            //Cabeçalho
            dgView.Columns[0].HeaderText = "ID";
            dgView.Columns[0].Visible = false;
            dgView.Columns[1].HeaderText = "CNPJ/CPF";            
            dgView.Columns[2].HeaderText = "RAZÃO SOCIAL";
            dgView.Columns[3].HeaderText = "APELIDO";

            //Preenchimento das células
            dgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
