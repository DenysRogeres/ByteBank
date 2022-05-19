using System;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDenys = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Denys";
            cliente.CPF = "123.456.789-21";
            cliente.Telefone = "(61)999888";

            contaDenys.Titular = cliente;
            contaDenys.Saldo = 50;

            Console.WriteLine(contaDenys.Titular.Nome);
            Console.WriteLine(contaDenys.Saldo);


            Console.ReadLine();
        }
    }
}
