using System;

namespace ModelagemTelefone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nokia: ");
            Smartphone nokia = new Nokia(numero: "37998679008", modelo: "5100", imei: "dsscd313a5a5", memoria: 512);

            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Lanterna");

            Console.WriteLine("\n\nIphone:");

            Smartphone iPhone = new IPhone(numero: "35984012356", modelo: "15", imei: "sd645dfg65d55", memoria: 1024);
            iPhone.Ligar();
            iPhone.ReceberLigacao();
            iPhone.InstalarAplicativo("Github");
            
        }
    }
}
