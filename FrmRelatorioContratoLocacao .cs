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
    public partial class FrmRelatorioContratoLocacao : Form
    {
        public FrmRelatorioContratoLocacao()
        {
            InitializeComponent();
        }
        
        private void FrmContratoLocacao_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
