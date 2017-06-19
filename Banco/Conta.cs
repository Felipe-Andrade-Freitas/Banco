using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Conta
    {
        public int numeroDaConta1 = 1;
        public string titularDaConta1 = "";
        public double saldo;
        public bool idade;

        public bool Saca(double Valor)
        {
            if(idade)
            {
                return false;
            }
            else if (Valor >= )
            {
                this.saldo -= Valor;
                return true;
            }
            else if (Valor <= 200)
            {
                return false;
            }
            else if (saldo >= Valor)
            {
                this.saldo -= Valor;
                return true;
            }
            else
            {
                return false;
            }

            /*if (this.saldo >= Valor)
            {
                this.saldo -= Valor;
                return true;
            }
            return false;*/
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }
        public void Transfere(double valor, Conta destino)
        {
            if(this.Saca(valor))
            {
                destino.Deposita(valor);
            }
        }

    }
}
