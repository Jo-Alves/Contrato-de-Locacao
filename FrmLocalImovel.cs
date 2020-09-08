using System;
using System.Windows.Forms;

namespace Contrato_de_Locação
{
    public partial class FrmLocalImovel : Form
    {
        public FrmLocalImovel()
        {
            InitializeComponent();
        }

        public string EnderecoImovel { get; set; }
        public string NumeroImovel { get; set; }
        public string BairroImovel { get; set; }
        public string CidadeImovel { get; set; }
        public string EstadoImovel { get; set; }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            EnderecoImovel = txtEndereco.Text.Trim();
            NumeroImovel = txtNumero.Text.Trim();
            BairroImovel = txtBairro.Text.Trim();
            CidadeImovel = txtCidade.Text.Trim();
            EstadoImovel = cbEstado.Text;

            if (string.IsNullOrEmpty(EnderecoImovel) && string.IsNullOrEmpty(NumeroImovel) && string.IsNullOrEmpty(BairroImovel) && string.IsNullOrEmpty(CidadeImovel) && string.IsNullOrEmpty(EstadoImovel))
            {
                MessageBox.Show("Informe o local do Imóvel!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.Close();
        }

        private void btnBuscarCep_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ws = new WsCorreios.AtendeClienteClient())
                {
                    var consultaCep = ws.consultaCEP(mkCEP.Text);
                    txtEndereco.Text = consultaCep.end;
                    txtBairro.Text = consultaCep.bairro;
                    txtCidade.Text = consultaCep.cidade;
                    cbEstado.Text = consultaCep.uf;
                }
            }
            catch
            {
                MessageBox.Show("Cep inválido e/ou sem conexão com a internet!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmLocalImovel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (mkCEP.Focused)
                    btnBuscarCep_Click(sender, e);
                else
                    btnConfirmar_Click(sender, e);
            }
        }
    }
}
