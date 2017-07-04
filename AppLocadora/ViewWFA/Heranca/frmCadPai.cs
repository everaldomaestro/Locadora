using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewWFA.Heranca
{
    public partial class frmCadPai : Form
    {
        public frmCadPai()
        {
            InitializeComponent();
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
