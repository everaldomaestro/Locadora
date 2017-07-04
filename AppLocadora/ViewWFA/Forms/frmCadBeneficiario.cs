using Classes.Controller;
using Classes.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ViewWFA.Forms
{
    public partial class frmCadBeneficiario : ViewWFA.Heranca.frmCadPai
    {
        public frmCadBeneficiario()
        {
            InitializeComponent();
        }

        private void frmCadBeneficiario_Load(object sender, EventArgs e)
        {
            CarregarDados();
            AtivarControles(true);
        }

        private void CarregarDados()
        {
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

            foreach(Control c in gbDados.Controls)
            {
                if (c is TextBox)
                {                   
                    ((TextBox) c).ReadOnly = cmd;
                }
            }
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            AtivarControles(false);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AtivarControles(true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AtivarControles(false);
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
                //ModelController.Excluir(b.BENEFICIARIO_ID);
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
            AtivarControles(true);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)//OK
        {
            CarregarDados();
        }
    }
}
