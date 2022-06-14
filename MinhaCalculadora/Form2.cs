using System;
using System.Windows.Forms;

namespace MinhaCalculadora
{
    public partial class frm_Historico : Form
    {
        public frm_Historico()
        {
            InitializeComponent();
        }

        private void btn_limparhistorico_Click(object sender, EventArgs e)
        {
            tb_historicocompleto.Clear();
        }

        
    }
}
