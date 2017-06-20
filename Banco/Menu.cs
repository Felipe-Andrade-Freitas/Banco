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
            Felipe.idade = true;

            // Irei depositar na conta de Felipe como saldo inicial o valor de 1000.0
            Felipe.Deposita(1000);
            // Felipe sacou o valor de 100.0 e exibi o valor de seu novo saldo
            
            
            if (result != "")
	        {
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("saque realizado com sucesso");
            }

            // Criando Conta de Elaine
            Conta Elaine = new Conta();
            Elaine.numeroDaConta1 = 2;
            Elaine.titularDaConta1 = "Elaine Cristina";
            Elaine.idade = false;

            // Irei depositar na conta de Elaine como saldo inicial o valor de 1000.0
            Elaine.Deposita(1000);

            // Elaine transferiu o valor de 100.0 para Felipe
            Elaine.Transfere(100, 42, Felipe);

            // Irei exibir o saldo de Elaine
            MessageBox.Show("Elaine, transferencia realizada com sucesso. \nSeu saldo é: " + Elaine.saldo);
            
            // Altomaticamente o saldo de Felipe muda acrescentando o valor de transferência
            MessageBox.Show("Elaine, o saldo de Felipe é: " + Felipe.saldo);

            // Elaine sacou o valor de 100.0 e exibi o valor de seu novo saldo
            
            if (Elaine.sacar(100, 42))
            {
                MessageBox.Show("Elaine, saque realizado com sucesso.\nSeu saldo é: " + Elaine.saldo);
            }
            else
            {
                MessageBox.Show("Elaine, saldo Insuficiente.\nSeu saldo é: " + Elaine.saldo);
            }

        }
    }
}
