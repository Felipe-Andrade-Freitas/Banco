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

        // Existem duas Formas de se fazer um método, usando o void e o bool.
        // o void não retorna nenhum valor de dentro do método, já o bool retorna.
        /*
        public void Saca(double Valor)
        {
            if(this.saldo >= Valor)
            {
                this.saldo -= Valor;
            }
        }
        */
        public bool Saca(double Valor)
        {
            if (this.saldo >= Valor)
            {
                this.saldo -= Valor;
                return true;
            }
            return false;
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
