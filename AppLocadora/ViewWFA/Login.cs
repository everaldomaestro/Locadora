using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewWFA.Forms;

namespace ViewWFA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadBeneficiario frm1 = new frmCadBeneficiario();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCadForma_Pag frm2 = new frmCadForma_Pag();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCadMetodo_Pag frm3 = new frmCadMetodo_Pag();
            frm3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmCadPagador frm4 = new frmCadPagador();
            frm4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCadPagamento frm5 = new frmCadPagamento();
            frm5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmCadTipo_Pag frm6 = new frmCadTipo_Pag();
            frm6.Show();
        }
    }
}
