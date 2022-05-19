namespace ByteBank
{
    public class ContaCorrente
    {
        public Pessoa titular;
        public int numero;
        public int agencia;
        public double saldo;

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
                return false;
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaCorrente)
        {
            if (this.saldo < valor)
                return false;
            else
            {
                this.saldo -= valor;
                contaCorrente.saldo += valor;

                return true;
            }
        }

    }

}
