using Classes.Controller;
using Classes.Entidades;
using System;
using System.Windows.Forms;

namespace ViewWFA.Forms
{
    public partial class frmCadMetodo_Pag : ViewWFA.Heranca.frmCadPai
    {
        public frmCadMetodo_Pag()
        {
            InitializeComponent();
        }

        private void frmCadBeneficiario_Load(object sender, EventArgs e)
        {
            CarregarDados();
            AtivarControles(true);
            BloquearEdicaoDados(true);
        }

        private void CarregarDados()
        {
            operacao = Operacao.visualizarRegistro;
            BeneficiarioController ModelController = new BeneficiarioController();
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
            //bENEFICIARIO_CNPJCPFTextBox.Focus();            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            BeneficiarioController ModelController = new BeneficiarioController();
            Beneficiario model = new Beneficiario();
            if (operacao == Operacao.gravarNovo)
            {
                //model.BENEFICIARIO_CNPJCPF = bENEFICIARIO_CNPJCPFTextBox.Text;
                //model.BENEFICIARIO_NOMEFAN = bENEFICIARIO_NOMEFANTextBox.Text;
                //model.BENEFICIARIO_RAZAOSOC = bENEFICIARIO_RAZAOSOCTextBox.Text;

                ModelController.Inserir(model);
            }
            else if(operacao == Operacao.editarRegistro)
            {
                model = (Beneficiario) bSource.Current;
                //model.BENEFICIARIO_CNPJCPF = bENEFICIARIO_CNPJCPFTextBox.Text;
                //model.BENEFICIARIO_NOMEFAN = bENEFICIARIO_NOMEFANTextBox.Text;
                //model.BENEFICIARIO_RAZAOSOC = bENEFICIARIO_RAZAOSOCTextBox.Text;

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

            //bENEFICIARIO_CNPJCPFTextBox.Focus();
        }

        private void btnRemover_Click(object sender, EventArgs e)//OK
        {
            BeneficiarioController ModelController = new BeneficiarioController();
            Beneficiario b = (Beneficiario) bSource.Current;

            if (MessageBox.Show(
                "Tem certeza que deseja excluir o registro de " +
                b.BENEFICIARIO_NOMEFAN + "?", "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                ModelController.Excluir(b.BENEFICIARIO_ID);
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
