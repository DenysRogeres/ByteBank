using System;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDenys = new ContaCorrente();
            contaDenys.titular = new Cliente();

            contaDenys.titular.nome = "Denys";
            contaDenys.titular.cpf = "123.456.789-09";
            contaDenys.titular.telefone = "(61)9999-8888";
            contaDenys.numero = 123456;
            contaDenys.agencia = 25;

            contaDenys.DefinirSaldo(500);
            Console.WriteLine(contaDenys.ObterSaldo());
            Console.WriteLine(contaDenys.titular.nome);



            Console.ReadLine();
        }
    }
}
