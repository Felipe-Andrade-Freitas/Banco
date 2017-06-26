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
        public int saldo;
        public bool idade;

        bool possuiIdadeMenor(int idade)
        {
            return idade < 18;
        }

        bool saldoMaiorPermitido(int valor)
        {
            return valor >= 200;
        }

        public string sacar(int valor, int idade) 
        {

            if (possuiIdadeMenor(idade))
            {
                return "Idade invalida";
            }

            if (saldoMaiorPermitido(valor))
            {
                return "VALOR INVALIDO";
            }

            /*if (this.saldo >= valor)
            {
                this.saldo -= valor;
            }*/
            else
            {
                return "OK";
            }
        }

        public void result(int valor, int idade)
        {
            string result = sacar(valor, idade);
        }

        public void Deposita(int valor)
        {
            this.saldo += valor;
        }

        public void Transfere(int valor, int idade, Conta destino)
        {
            if(true)
            {
                this.sacar(valor, idade);
                destino.Deposita(valor);
            }
        }

    }
}
