using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MonitorarPing
{
    class Monitorar
    {

        public void VerificarConexao( string ipp) {
            string ip = ipp;
            Boolean veriricar = false;
            StringBuilder str = new StringBuilder();
            Console.WriteLine("MONITORANDO O IP " + ip);

            while (ip != "")
            {
                DateTime thisDay = DateTime.Now;
                Ping p = new Ping();
                PingReply pr = p.Send(ip);



                str.AppendLine(string.Format("Address: {0}", pr.Address));
                str.AppendLine(string.Format("Status: {0}", pr.Status));

                //  Console.WriteLine(str.ToString());

                if (pr.Status == IPStatus.TimedOut || pr.Status == IPStatus.DestinationHostUnreachable)
                {
                    EscreveArquivo("CONEXÃO PERDIDA DO IP " + ip + "  " + pr.Status.ToString() + " AS " + thisDay.Hour.ToString() + " " + thisDay.ToString() + thisDay.Hour.ToString() + thisDay.Minute.ToString() + thisDay.Second.ToString() + thisDay.Millisecond.ToString());
                    Console.WriteLine("CONEXÃO PERDIDA DO IP " + ip + "  " + pr.Status.ToString() + " AS " + thisDay.Hour.ToString() + " " + thisDay.ToString() + thisDay.Hour.ToString() + thisDay.Minute.ToString() + thisDay.Second.ToString() + thisDay.Millisecond.ToString());
                    veriricar = true;
                }
                else if (veriricar == true)
                {

                    Console.WriteLine("MONITORANDO O IP " + ip);
                    veriricar = false;

                }

            }
        
        }



        private void EscreveArquivo(string mensagem)
        {


            if (mensagem != "")
            {
                StreamWriter arquivo1;

                //Colocando o endereço físico (caminho do arquivo texto) 
                string Caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString() +@"\log\log.txt";

                //usando o metodo e abrindo o arquivo texto
                arquivo1 = File.AppendText(Caminho);

                //continuando escrevendo neste arquivo
                //escrevendo a partir da ultima linha 
                arquivo1.WriteLine();
                arquivo1.WriteLine(mensagem);


                arquivo1.Close();

            }
        }



    }
}
