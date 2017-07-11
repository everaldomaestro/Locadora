using Classes.Controller;
using Classes.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ViewWFA.Forms
{
    public partial class frmCadPagador : Heranca.frmCadPai
    {
        public frmCadPagador()
        {
            InitializeComponent();
        }
        
        private void frmCadPagador_Load(object sender, EventArgs e)
        {
            FormatarGrid();
            CarregarDados();
            AtivarControles();
            BloquearEdicaoDados(true);
        }

        private void CarregarDados()
        {
            operacao = Operacao.visualizarRegistro;
            PagadorController ModelController = new PagadorController();
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
            pAGADOR_CNPJCPFTextBox.Focus();            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool [] ObjValido = new bool [3];
            bool gravar = false;

            if (validation.CPF(pAGADOR_CNPJCPFTextBox.Text.ToString()))
            {
                pAGADOR_CNPJCPFTextBox.ForeColor = DefaultForeColor;
                ObjValido[0] = true;
            }
            else
            {
                pAGADOR_CNPJCPFTextBox.ForeColor = System.Drawing.Color.Red;
                ObjValido[0] = false;
            }

            if (validation.Nome(pAGADOR_NOMETextBox.Text.ToString()))
            {
                pAGADOR_NOMETextBox.ForeColor = DefaultForeColor;
                ObjValido[1] = true;
            }
            else
            {
                pAGADOR_NOMETextBox.ForeColor = System.Drawing.Color.Red;
                ObjValido[1] = false;
            }

            if (validation.Nome(pAGADOR_NOMECOMPLETOTextBox.Text.ToString()))
            {
                pAGADOR_NOMECOMPLETOTextBox.ForeColor = DefaultForeColor;
                ObjValido[2] = true;
            }
            else
            {
                pAGADOR_NOMECOMPLETOTextBox.ForeColor = System.Drawing.Color.Red;
                ObjValido[2] = false;
            }

            for (int i = 0; i < 3; i++)
            {
                if(ObjValido[i] == true)
                {
                    gravar = true;
                }
                else
                {
                    gravar = false;
                    break;
                }
            }

            if (gravar)
            {
                PagadorController ModelController = new PagadorController();
                Pagador model = new Pagador();
                if (operacao == Operacao.gravarNovo)
                {
                    model.PAGADOR_CNPJCPF = pAGADOR_CNPJCPFTextBox.Text;
                    model.PAGADOR_NOMECOMPLETO = pAGADOR_NOMECOMPLETOTextBox.Text;
                    model.PAGADOR_NOME = pAGADOR_NOMETextBox.Text;

                    //ModelController.Inserir(model);
                }
                else if (operacao == Operacao.editarRegistro)
                {
                    model = (Pagador)bSource.Current;
                    model.PAGADOR_CNPJCPF = pAGADOR_CNPJCPFTextBox.Text;
                    model.PAGADOR_NOMECOMPLETO = pAGADOR_NOMECOMPLETOTextBox.Text;
                    model.PAGADOR_NOME = pAGADOR_NOMETextBox.Text;

                    //ModelController.Atualizar(model);
                }

                CarregarDados();
                AtivarControles();
                BloquearEdicaoDados(true);
            }
            else
            {
                MessageBox.Show("Corrija os campos em vermelho");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            operacao = Operacao.editarRegistro;
            AtivarControles();
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
            //Cabeçalho
            dgView.Columns[0].HeaderText = "ID";
            dgView.Columns[0].Visible = false;
            dgView.Columns[1].HeaderText = "CPF";
            dgView.Columns[2].HeaderText = "NOME";
            dgView.Columns[3].HeaderText = "NOME COMPLETO";

            //Preenchimento das células
            dgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void pAGADOR_NOMETextBox_Enter(object sender, EventArgs e)
        {   
            string Dica = "Digite um nome válido. Acento agudo permitido. Outros caracteres não serão aceitos.";
            tsStatus.ForeColor = System.Drawing.Color.White;
            tsStatus.BackColor = System.Drawing.Color.Red;
            tsStatus.Text = Dica;
        }

        private void pAGADOR_NOMETextBox_Leave(object sender, EventArgs e)
        {
            tsStatus.Text = null;
        }
    }
}
