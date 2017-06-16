using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void sacarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criando Conta de Felipe
            Conta Felipe = new Conta();
            Felipe.numeroDaConta1 = 1;
            Felipe.titularDaConta1 = "Felipe Andrade";
            // Irei depositar na conta de Felipe como saldo inicial o valor de 1000.0
            Felipe.Deposita(1000.0);
            // Felipe sacou o valor de 100.0 e exibi o valor de seu novo saldo
            if (Felipe.Saca(100.0))
            {
                MessageBox.Show("Saque realizado com sucesso.\nSeu saldo é: " + Felipe.saldo);
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente.\nSeu saldo é: " + Felipe.saldo);
            }

            // Criando Conta de Elaine
            Conta Elaine = new Conta();
            Elaine.numeroDaConta1 = 2;
            Elaine.titularDaConta1 = "Elaine Cristina";
            // Irei depositar na conta de Elaine como saldo inicial o valor de 1000.0
            Elaine.Deposita(1000.0);
            // Elaine transferiu o valor de 100.0 para Felipe
            Elaine.Transfere(100.0, Felipe);
            // Irei exibir o saldo de Elaine
            MessageBox.Show("Transferencia realizada com sucesso. \nSeu saldo é: " + Elaine.saldo);
            // Altomaticamente o saldo de Felipe muda acrescentando o valor de transferência
            MessageBox.Show("O saldo de Felipe é: " + Felipe.saldo);
            // Elaine sacou o valor de 100.0 e exibi o valor de seu novo saldo
            if (Elaine.Saca(100.0))
            {
                MessageBox.Show("Saque realizado com sucesso.\nSeu saldo é: " + Elaine.saldo);
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente.\nSeu saldo é: " + Elaine.saldo);
            }

        }
    }
}
