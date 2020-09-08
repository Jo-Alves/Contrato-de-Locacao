using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace Contrato_de_Locação
{
    public partial class FrmRelatorioContratoLocacao : Form
    {
        public FrmRelatorioContratoLocacao()
        {
            InitializeComponent();
        }

        public FrmRelatorioContratoLocacao(string Locador, string NomeLocador, string NacionalidadeLocador, string EstadoCivilLocador, string RGLocador, string CPFLocador, string EnderecoLocador, string NumeroLocador, string BairroLocador, string EstadoLocador, string Locatario, string NomeLocatario, string NacionalidadeLocatario, string EstadoCivilLocatario, string RgLocatario, string CPFLocatario, string EnderecoLocatario, string NumeroLocatario, string BairroLocatario, string PrazoLocacao, string InicioLocacao, string FinalLocacao, string ValorMensal, string ForoComarca, string artigoLocador, string artigoLocatario, string Observacao, string vencimento, string CidadeLocador, string CidadeLocatario, string EstadoLocatario, string EnderecoImovel, string NumeroImovel, string BairroImovel, string CidadeImovel, string EstadoImovel, string artigoSemana, string GetMesOuMeses)
        {
            InitializeComponent();

            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("Locador", Locador.ToUpper()));
            rpc.Add(new ReportParameter("NacionalidadeLocador", NacionalidadeLocador));
            rpc.Add(new ReportParameter("RGLocador", RGLocador));

            if (!string.IsNullOrEmpty(EstadoCivilLocador))
                rpc.Add(new ReportParameter("EstadoCivilLocador", EstadoCivilLocador + ","));
            rpc.Add(new ReportParameter("CPFLocador", CPFLocador));
            rpc.Add(new ReportParameter("EnderecoLocador", EnderecoLocador));
            rpc.Add(new ReportParameter("BairroLocador", BairroLocador));
            rpc.Add(new ReportParameter("CidadeLocador", CidadeLocador.ToUpper()));
            rpc.Add(new ReportParameter("EstadoLocador", EstadoLocador.ToUpper()));
            rpc.Add(new ReportParameter("Locatario", Locatario.ToUpper()));
            rpc.Add(new ReportParameter("NacionalidadeLocatario", NacionalidadeLocatario));
            rpc.Add(new ReportParameter("RGLocatario", RgLocatario));
            if (!string.IsNullOrEmpty(EstadoCivilLocatario))
                rpc.Add(new ReportParameter("EstadoCivilLocatario", EstadoCivilLocatario + ","));
            rpc.Add(new ReportParameter("CPFLocatario", CPFLocatario));
            rpc.Add(new ReportParameter("EnderecoLocatario", EnderecoLocatario));
            rpc.Add(new ReportParameter("BairroLocatario", BairroLocatario));
            rpc.Add(new ReportParameter("CidadeLocatario", CidadeLocatario));
            rpc.Add(new ReportParameter("EstadoLocatario", EstadoLocatario));
            rpc.Add(new ReportParameter("NomeLocador", NomeLocador));
            rpc.Add(new ReportParameter("NomeLocatario", NomeLocatario));
            rpc.Add(new ReportParameter("NumeroLocatario", NumeroLocatario));
            rpc.Add(new ReportParameter("NumeroLocador", NumeroLocador));
            rpc.Add(new ReportParameter("ForoComarca", ForoComarca));

            if (!string.IsNullOrEmpty(Observacao))
                rpc.Add(new ReportParameter("Observacao", "OBS: " + Observacao));

            rpc.Add(new ReportParameter("InicioLocacao", InicioLocacao));
            rpc.Add(new ReportParameter("FinalLocacao", FinalLocacao));
            rpc.Add(new ReportParameter("Valor", ValorMensal));
            rpc.Add(new ReportParameter("Vencimento", vencimento));
            rpc.Add(new ReportParameter("artigoLocadorMin", artigoLocador.ToLower()));
            rpc.Add(new ReportParameter("ArtigoLocadorMai", artigoLocador.ToUpper()));
            rpc.Add(new ReportParameter("LocatarioMin", Locatario.ToLower()));
            rpc.Add(new ReportParameter("ArtigoLocatarioMai", artigoLocatario.ToUpper()));
            rpc.Add(new ReportParameter("artigoLocatarioMin", artigoLocatario.ToLower()));
            rpc.Add(new ReportParameter("Observacao", Observacao));
            rpc.Add(new ReportParameter("EnderecoImovel", EnderecoImovel));
            rpc.Add(new ReportParameter("NumeroImovel", NumeroImovel));
            rpc.Add(new ReportParameter("BairroImovel", BairroImovel));
            rpc.Add(new ReportParameter("CidadeImovel", CidadeImovel));
            rpc.Add(new ReportParameter("EstadoImovel", EstadoImovel));
            rpc.Add(new ReportParameter("PrazoLocacao", PrazoLocacao));
            rpc.Add(new ReportParameter("LocadorMin", Locador.ToLower()));
            rpc.Add(new ReportParameter("dataContrato", DateTime.Now.ToLongDateString()));
            rpc.Add(new ReportParameter("artigoSemana", artigoSemana));
            rpc.Add(new ReportParameter("MesOuMeses", GetMesOuMeses));

            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }

        private void FrmContratoLocacao_Load(object sender, EventArgs e)
        {

        }
    }
}
