using System;
using System.Windows.Forms;
using Util;

namespace ViewWFA.Heranca
{
    public partial class frmCadPai : Form
    {
        protected enum Operacao
        {
            gravarNovo,
            editarRegistro,
            visualizarRegistro
        }

        protected static Operacao operacao;
        protected static int QtdDados;
        protected static Validation validation = new Validation();

        public frmCadPai()
        {
            InitializeComponent();
        }

        protected void AtivarControles()
        {
            if (QtdDados == 0 && operacao == Operacao.visualizarRegistro)
            {
                btnPrimeiro.Enabled = false;
                btnAnterior.Enabled = false;
                btnProximo.Enabled = false;
                btnUltimo.Enabled = false;

                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                btnEditar.Enabled = false;
                btnRemover.Enabled = false;
                btnCancelar.Enabled = false;
                btnAtualizar.Enabled = true;
            }
            else if (QtdDados != 0 && operacao == Operacao.visualizarRegistro)
            {
                btnPrimeiro.Enabled = true;
                btnAnterior.Enabled = true;
                btnProximo.Enabled = true;
                btnUltimo.Enabled = true;

                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                btnEditar.Enabled = true;
                btnRemover.Enabled = true;
                btnCancelar.Enabled = false;
                btnAtualizar.Enabled = true;
            }
            else
            {
                btnPrimeiro.Enabled = false;
                btnAnterior.Enabled = false;
                btnProximo.Enabled = false;
                btnUltimo.Enabled = false;

                btnNovo.Enabled = false;
                btnSalvar.Enabled = true;
                btnEditar.Enabled = false;
                btnRemover.Enabled = false;
                btnCancelar.Enabled = true;
                btnAtualizar.Enabled = false;
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            bSource.MoveFirst();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            bSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            bSource.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            bSource.MoveLast();
        }
    }
}
