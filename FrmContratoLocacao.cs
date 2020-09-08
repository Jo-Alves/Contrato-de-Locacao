using System;
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
            cbGeneroLocatario.SelectedIndex = 1;
            cbGeneroLocador.SelectedIndex = 1;
        }

        string artigoLocador, artigoLocatario;

        private string GetArtigoDiaSemana()
        {
            string artigoSemana = "a";

            string[] diaHoje = DateTime.Now.ToLongDateString().Split(Convert.ToChar(","));
            if (diaHoje[0].ToLower() == "domingo" || diaHoje[0].ToLower() == "sábado")
            {
                artigoSemana = "o";
            }

            return artigoSemana;
        }

        private void btnGerarContrato_Click(object sender, EventArgs e)
        {
            if (mkCPFLocador.Text == mkCPFLocatario.Text)
            {
                MessageBox.Show("CPF São idênticos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            FrmLocalImovel localImovel = new FrmLocalImovel();
            localImovel.ShowDialog();
            if (string.IsNullOrEmpty(localImovel.EnderecoImovel) && string.IsNullOrEmpty(localImovel.NumeroImovel) && string.IsNullOrEmpty(localImovel.BairroImovel) && string.IsNullOrEmpty(localImovel.CidadeImovel) && string.IsNullOrEmpty(localImovel.EstadoImovel))
            {
                MessageBox.Show("Informe o local do Imóvel!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string inicioLocacao = dtInicioLocacao.Text, finalLocacao = dtFinalLocacao.Text;

            DateTime inicio = Convert.ToDateTime(dtInicioLocacao.Text);
            inicioLocacao = inicio.ToLongDateString();
            DateTime final = Convert.ToDateTime(dtFinalLocacao.Text);
            finalLocacao = final.ToLongDateString();

            FrmRelatorioContratoLocacao frmRelatorio = new FrmRelatorioContratoLocacao(gpLocador.Text.Trim().ToUpper(), txtNomeLocador.Text.Trim(), txtNacionalidadeLocador.Text.Trim(), cbEstadoCivilLocador.Text.Trim(), txtRGLocador.Text.Trim(), mkCPFLocador.Text, txtEnderecoLocador.Text.Trim(), txtNumeroLocador.Text.Trim(), txtBairroLocador.Text.Trim(), cbEstadoLocador.Text, gpLocatario.Text.Trim().ToUpper(), txtNomeLocatario.Text.Trim(), txtNacionalidadeLocatario.Text.Trim(), cbEstadoCivilLocatario.Text.Trim(), txtRgLocatario.Text.Trim(), mkCPFLocatario.Text, txtEnderecoLocatario.Text.Trim(), txtNumeroLocatario.Text.Trim(), txtBairroLocatario.Text.Trim(), numPrazoLocacao.Value.ToString(), inicioLocacao, finalLocacao, txtValorMensal.Text, txtForoComarca.Text.Trim(), artigoLocador, artigoLocatario, rtbObservacao.Text.Trim(), numVencimento.Value.ToString(), txtCidadeLocador.Text.Trim(), txtCidadeLocatario.Text.Trim(), cbEstadoLocatario.Text.Trim(), localImovel.EnderecoImovel, localImovel.NumeroImovel, localImovel.BairroImovel, localImovel.CidadeImovel, localImovel.EstadoImovel, GetArtigoDiaSemana(), GetMesOuMeses());
            frmRelatorio.ShowDialog();
        }

        private void cbGeneroLocador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGeneroLocador.SelectedIndex == 0)
            {
                gpLocador.Text = "Locadora";
                cbEstadoCivilLocador.Items.Clear();
                cbEstadoCivilLocador.Items.AddRange(new Object[] {
                    "",
                    "Casada",
                    "Divorciada",
                    "Solteira",
                    "Viúva"
                });

                cbEstadoCivilLocador.SelectedIndex = 0;
                artigoLocador = "a";
            }
            else if (cbGeneroLocador.SelectedIndex == 1)
            {
                gpLocador.Text = "Locador";
                cbEstadoCivilLocador.Items.Clear();
                cbEstadoCivilLocador.Items.AddRange(new Object[] {
                    "",
                    "Casado",
                    "Divorciado",
                    "Solteiro",
                    "Viúvo"
                });

                cbEstadoCivilLocador.SelectedIndex = 0;
                artigoLocador = "o";
            }
        }

        private void cbGeneroLocatario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGeneroLocatario.SelectedIndex == 0)
            {
                gpLocatario.Text = "Locatária";
                cbEstadoCivilLocatario.Items.Clear();

                cbEstadoCivilLocatario.Items.AddRange(new Object[] {
                    "",
                    "Casada",
                    "Divorciada",
                    "Solteira",
                    "Viúva"
                });

                cbEstadoCivilLocatario.SelectedIndex = 0;
                artigoLocatario = "a";
            }
            else if (cbGeneroLocatario.SelectedIndex == 1)
            {
                gpLocatario.Text = "Locatário";
                cbEstadoCivilLocatario.Items.Clear();
                cbEstadoCivilLocatario.Items.AddRange(new Object[] {
                    "",
                    "Casado",
                    "Divorciado",
                    "Solteiro",
                    "Viúvo"
                });

                cbEstadoCivilLocatario.SelectedIndex = 0;
                artigoLocatario = "o";
            }
        }

        private void txtValorMensal_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtValorMensal.Text))
                    txtValorMensal.Text = Convert.ToDecimal(txtValorMensal.Text.Trim()).ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private string GetMesOuMeses()
        {
            if (numPrazoLocacao.Value == 1)
                return "mês";
            else
                return "meses";
        }

        private void numPrazoLocacao_ValueChanged(object sender, EventArgs e)
        {
            dtFinalLocacao.Text = GetFinalDataLocacao();

        }

        private string GetFinalDataLocacao()
        {
            DateTime dataInicioLocacao = Convert.ToDateTime(dtInicioLocacao.Text);
            DateTime dataFinalLocacao = dataInicioLocacao.AddMonths(int.Parse(numPrazoLocacao.Value.ToString()));
            return dataFinalLocacao.ToShortDateString();
        }

        private void btnBuscarCepLocador_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ws = new WsCorreios.AtendeClienteClient())
                {
                    var consultaCep = ws.consultaCEP(mkCEPLocador.Text);
                    txtEnderecoLocador.Text = consultaCep.end;
                    txtBairroLocador.Text = consultaCep.bairro;
                    txtCidadeLocador.Text = consultaCep.cidade;
                    cbEstadoLocador.Text = consultaCep.uf;
                }
            }
            catch
            {
                MessageBox.Show("Cep inválido e/ou sem conexão com a internet!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscarCepLocatario_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ws = new WsCorreios.AtendeClienteClient())
                {
                    var consultaCep = ws.consultaCEP(mkCEPLocatario.Text);
                    txtEnderecoLocatario.Text = consultaCep.end;
                    txtBairroLocatario.Text = consultaCep.bairro;
                    txtCidadeLocatario.Text = consultaCep.cidade;
                    cbEstadoLocatario.Text = consultaCep.uf;
                }
            }
            catch
            {
                MessageBox.Show("Cep inválido e/ou sem conexão com a internet!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mkCPFLocador_Leave(object sender, EventArgs e)
        {
            if (mkCPFLocador.MaskCompleted)
            {
                string validar = mkCPFLocador.Text;
                if (!CPF.ValidaCPF(validar))
                {
                    MessageBox.Show("O número do CPF é Inválido!", "Validação CPF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private void mkCPFLocatario_Leave(object sender, EventArgs e)
        {
            if (mkCPFLocatario.MaskCompleted)
            {
                string validar = mkCPFLocatario.Text;
                if (!CPF.ValidaCPF(validar))
                {
                    MessageBox.Show("O número do CPF é Inválido!", "Validação CPF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private void dtInicioLocacao_ValueChanged(object sender, EventArgs e)
        {
            dtFinalLocacao.Text = GetFinalDataLocacao();
        }

        private void FrmContratoLocacao_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (mkCEPLocador.Focused)
                    btnBuscarCepLocador_Click(sender, e);
                else if (mkCEPLocatario.Focused)
                    btnBuscarCepLocatario_Click(sender, e);
                else
                    btnGerarContrato_Click(sender, e);
            }
        }

        private void txtValorMensal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txtValorMensal.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }
    }
}