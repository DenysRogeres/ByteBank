using System;

namespace ByBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDenys = new ContaCorrente();
            ContaCorrente contaRayssa = new ContaCorrente();

            contaDenys.nome = "Denys";
            contaDenys.saldo = 500;

            contaRayssa.nome = "Rayssa";
            contaRayssa.saldo = 100;

            Console.WriteLine("Conta Denys " + contaDenys.saldo);
            Console.WriteLine("Conta Rayssa " + contaRayssa.saldo);

            bool resultadoTransferencia = contaDenys.Transferir(2000, contaRayssa);

            Console.WriteLine("Conta Denys " + contaDenys.saldo);
            Console.WriteLine("Conta Rayssa " + contaRayssa.saldo);


            if (resultadoTransferencia == true)
                Console.WriteLine("Transferência realizada!");
            else
                Console.WriteLine("Transferência não realizada!");
           
            Console.ReadLine();
        }
    }
}
