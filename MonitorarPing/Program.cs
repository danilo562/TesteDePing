using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.IO;

namespace MonitorarPing
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("MONITORAMENTO IP.", Console.Title);
            Console.Write("==| ESTE PROGRAMA VAI MONITORAR O IP INFORMADO PARA VERIFICAR O MOMENTO QUE PERDER A CONEXÃO |==============  ");
            Console.WriteLine("");
            Console.WriteLine("ESCRITO POR DANILO NOVAES. ");
            Console.WriteLine("VERSÃO 1.0");
            Console.WriteLine("DW NEW SOFTWARE");
            Console.WriteLine("");


            string ip;
            Monitorar monitorar = new Monitorar();
            Console.Write("Digite O IP PARA MONITORAR ");
            ip = Console.ReadLine();
            monitorar.VerificarConexao(ip);
                     
            
        }


       


        


    }
}
