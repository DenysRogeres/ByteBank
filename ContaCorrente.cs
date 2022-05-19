namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        public int Agenda { get; set; }
        private double _saldo;

        public double Saldo
        {
            get 
            { 
                return _saldo; 
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }

        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
                return false;
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaCorrente)
        {
            if (_saldo < valor)
                return false;
            else
            {
                _saldo -= valor;
                contaCorrente._saldo += valor;

                return true;
            }
        }

    }

}
