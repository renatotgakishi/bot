using System;
using System.Net;

namespace BotMegaSenaJson
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

            Console.ReadKey();
        }
    }
}
