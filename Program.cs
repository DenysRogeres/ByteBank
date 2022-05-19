using System;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDenys = new ContaCorrente();
            contaDenys.titular = new Pessoa();

            contaDenys.titular.nome = "Denys";
            contaDenys.titular.cpf = "123.456.789-09";
            contaDenys.titular.telefone = "(61)9999-8888";
            contaDenys.numero = 123456;
            contaDenys.agencia = 25;
            contaDenys.saldo = 2400;

            Console.WriteLine(contaDenys.saldo);
            Console.WriteLine(contaDenys.titular.nome);



            Console.ReadLine();
        }
    }
}
