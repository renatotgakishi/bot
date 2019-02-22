using System;
using System.Collections.Generic;
using System.Text;

namespace BotLotoFacilJson
{
    public class Resultado
    {
        
        public long ProximoConcurso { get; set; }
        public long ConcursoAnterior { get; set; }
        public object Forward { get; set; }
        public List<object> Mensagens { get; set; }
        public long NuConcurso { get; set; }
        public string DtApuracao { get; set; }
        public string DeResultado { get; set; }
        public object DeObservacao { get; set; }
        public int qt_ganhador_faixa1 { get; set; }        
        public int qt_ganhador_faixa2 { get; set; }
        public int qt_ganhador_faixa3 { get; set; }
        public int qt_ganhador_faixa4 { get; set; }
        public int qt_ganhador_faixa5 { get; set; }
        public decimal vr_rateio_faixa1 { get; set; }
        public decimal vr_rateio_faixa2 { get; set; }
        public decimal vr_rateio_faixa3 { get; set; }
        public decimal vr_rateio_faixa4 { get; set; }
        public decimal vr_rateio_faixa5 { get; set; }
        public string NoCidade { get; set; }
        public string SgUf { get; set; }
        public string VrAcumuladoFaixa1 { get; set; }
        public string VrAcumuladoFaixa2 { get; set; }
        public string VrEstimativa { get; set; }
        public long DtProximoConcurso { get; set; }
        public string VrArrecadado { get; set; }
        public string VrAcumuladoEspecial { get; set; }
        public string DeLocalSorteio { get; set; }
        public bool IcConcursoEspecial { get; set; }
        public bool SorteioAcumulado { get; set; }
        public bool RateioProcessamento { get; set; }
        public string LocalSorteio { get; set; }
        public List<GanhadoresPorUf> GanhadoresPorUf { get; set; }
        public bool Error { get; set; }
        public string ResultadoOrdenado { get; set; }
        public string DtApuracaoStr { get; set; }
        public string DtProximoConcursoStr { get; set; }
    }

    public partial class GanhadoresPorUf
    {
        public object ProximoConcurso { get; set; }
        public object ConcursoAnterior { get; set; }
        public object Forward { get; set; }
        public List<object> Mensagens { get; set; }
        public string CoLoteria { get; set; }
        public long NuConcurso { get; set; }
        public string SgUf { get; set; }
        public long QtGanhadores { get; set; }
        public string NoCidade { get; set; }
        public object Total { get; set; }
        public bool IcCanalEletronico { get; set; }
    }

}


