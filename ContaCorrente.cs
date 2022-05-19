namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int numero;
        public int agencia;
        private double saldo;

        public double ObterSaldo()
        {
            return this.saldo;
        }

        public void DefinirSaldo(double saldo)
        {
            if(saldo < 0)
            {
                return;
            }
            this.saldo = saldo;
        }

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
