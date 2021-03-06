﻿using Classes.Controller;
using Classes.Entidades;
using System;
using System.Windows.Forms;

namespace ViewWFA.Forms
{
    public partial class frmCadForma_Pag : ViewWFA.Heranca.frmCadPai
    {
        public frmCadForma_Pag()
        {
            InitializeComponent();
        }

        private void frmCadForma_Pag_Load(object sender, EventArgs e)
        {
            FormatarGrid();
            CarregarDados();
            AtivarControles();
            BloquearEdicaoDados(true);
        }

        private void CarregarDados()
        {
            operacao = Operacao.visualizarRegistro;
            Forma_PagController ModelController = new Forma_PagController();
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
            fORMA_PAG_DESCRICAOTextBox.Focus();            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Forma_PagController ModelController = new Forma_PagController();
            Forma_Pag model = new Forma_Pag();
            if (operacao == Operacao.gravarNovo)
            {
                model.FORMA_PAG_DESCRICAO = fORMA_PAG_DESCRICAOTextBox.Text;

                ModelController.Inserir(model);
            }
            else if(operacao == Operacao.editarRegistro)
            {
                model = (Forma_Pag) bSource.Current;
                model.FORMA_PAG_DESCRICAO = fORMA_PAG_DESCRICAOTextBox.Text;

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

            fORMA_PAG_DESCRICAOTextBox.Focus();
        }

        private void btnRemover_Click(object sender, EventArgs e)//OK
        {
            Forma_PagController ModelController = new Forma_PagController();
            Forma_Pag model = (Forma_Pag) bSource.Current;

            if (MessageBox.Show(
                "Tem certeza que deseja excluir o registro de " +
                model.FORMA_PAG_DESCRICAO + "?", "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                ModelController.Excluir(model.FORMA_PAG_ID);                
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
            dgView.Columns[1].HeaderText = "DESCRIÇÃO";

            //Preenchimento das células
            dgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
