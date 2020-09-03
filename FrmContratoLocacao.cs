using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contrato_de_Locação
{
    public partial class FrmContratoLocacao : Form
    {
        public FrmContratoLocacao()
        {
            InitializeComponent();
        }

        private void FrmContratoLocacao_Load(object sender, EventArgs e)
        {
            cbGeneroLocatario.SelectedIndex = -1;
            cbGeneroLocador.SelectedIndex = -1;
        }

        private void btnGerarContrato_Click(object sender, EventArgs e)
        {
            FrmRelatorioContratoLocacao frmRelatorio = new FrmRelatorioContratoLocacao();
            frmRelatorio.ShowDialog();
        }
    }
}
