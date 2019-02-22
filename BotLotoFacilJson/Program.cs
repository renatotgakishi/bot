using BotLotoFacilJson;
using Newtonsoft.Json;
using System;
using System.Net;

namespace BotLotoFacilJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o numero do sorteio:");
            string numeroDoConcurso = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(numeroDoConcurso))
            {
                numeroDoConcurso = "1700";
            }

            string url = @"http://loterias.caixa.gov.br/wps/portal/loterias/landing/lotofacil/!ut/p/a1/04_Sj9CPykssy0xPLMnMz0vMAfGjzOLNDH0MPAzcDbz8vTxNDRy9_Y2NQ13CDA0sTIEKIoEKnN0dPUzMfQwMDEwsjAw8XZw8XMwtfQ0MPM2I02-AAzgaENIfrh-FqsQ9wBmoxN_FydLAGAgNTKEK8DkRrACPGwpyQyMMMj0VAcySpRM!/dl5/d5/L2dBISEvZ0FBIS9nQSEh/pw/Z7_61L0H0G0J0VSC0AC4GLFAD2003/res/id=buscaResultado/c=cacheLevelPage/=/?timestampAjax=1550868983592&concurso=" + numeroDoConcurso;
            string json;
            using (WebClient wc = new WebClient())
            {
                wc.Headers["Cookie"] = "security=true";
                json = wc.DownloadString(url);

            }

            Resultado resultadoLotoFacil = JsonConvert.DeserializeObject<Resultado>(json);
            Console.WriteLine(resultadoLotoFacil.ResultadoOrdenado);
            Console.WriteLine(resultadoLotoFacil.DtApuracao);
            Console.WriteLine("Qtde de jogadores 1 premio ${0} no valor de  {1}", resultadoLotoFacil.qt_ganhador_faixa1, resultadoLotoFacil.vr_rateio_faixa1);
            Console.WriteLine("Qtde de jogadores 2 premio ${0} no valor de  {1}", resultadoLotoFacil.qt_ganhador_faixa2, resultadoLotoFacil.vr_rateio_faixa2);
            Console.WriteLine("Qtde de jogadores 3 premio ${0} no valor de  {1}", resultadoLotoFacil.qt_ganhador_faixa3, resultadoLotoFacil.vr_rateio_faixa3);
            Console.WriteLine("Qtde de jogadores 4 premio ${0} no valor de  {1}", resultadoLotoFacil.qt_ganhador_faixa4, resultadoLotoFacil.vr_rateio_faixa4);
            Console.WriteLine("Qtde de jogadores 5 premio ${0} no valor de  {1}", resultadoLotoFacil.qt_ganhador_faixa5, resultadoLotoFacil.vr_rateio_faixa5);

            Console.ReadKey();
        }
    }
}
