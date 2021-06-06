using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idadeMaria = 30;
            int idadeFrancisco = 31;
            int idadeJoao = 30;

            double mediaIdade;

            mediaIdade = (idadeMaria + idadeFrancisco + idadeJoao) / 3.00;

            MessageBox.Show("Maria tem : " + idadeMaria + " Já Francisco possui : " + idadeFrancisco 
                + " e João tem : " + idadeJoao + " Media das 3 idades é : " + (double)mediaIdade);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int pi = 3.14;
            double pi = 3.14;
            MessageBox.Show("O código não compila, pois 3.14 não cabe dentro de um inteiro: " + pi);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("piQuebrado é : " + piQuebrado);
            //Resultado será 3
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = 12, b = 91, c = 5;
            double delta, a1, a2;

            delta = b * b  - 4*a*c;
            a1=(-b + Math.Sqrt((int)delta)) / (2 * a);
            a2=(-b - Math.Sqrt((int)delta)) / (2 * a);

            MessageBox.Show("Valor A1 : " + (int)a1 + " Valor A2 : " + (int)a2 );
            //Declarei em Cast as Var a1 e a2 para ter um resultado inteiro mesmo sabendo que estão declarados como double.
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorSaque = 10.0;
            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com sucesso : " + saldo);
                //mensagem:	Saque	realizado	com	sucesso;	saldo:	90.0
            }
            else
            {
                MessageBox.Show("Saldo Insulficiente");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double saldo = 5.0;
            double valorSaque = 10.0;
            if(saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com Sucesso : " + saldo);
            }
            else
            {
                MessageBox.Show("Saldo Insulficiente : " + saldo);
                //mensagem:	Saldo	Insuficiente;	saldo	5.0
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double saldo = 500;
            if(saldo < 0.0)
            {
                MessageBox.Show("Você esta no Negativo = " + saldo);
            }
            else if( saldo < 1000000.0)
            {
                MessageBox.Show("Você é um bom cliente : " + saldo);
            }
            else
            {
                MessageBox.Show("Você é milionário !!! " + saldo);
                //"Você	é	um	bom	cliente"
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int idade = 16;
            bool brasileiro = true;

            if (idade > 16 || brasileiro)
            {
                idade = 17;
                MessageBox.Show("Esta halitado a votar : " + idade + " - " + brasileiro);
            }
            else
            {
                MessageBox.Show(" Não esta habilitado a vota em nosso pais ");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double valorNotaFiscal = 600;
            double imposto;
            
            if (valorNotaFiscal <= 999)
            {
                imposto = valorNotaFiscal * 0.02;                
                MessageBox.Show("Valor do imposto é : " + imposto);
            }
            else if (valorNotaFiscal >= 1000 && valorNotaFiscal <= 2999)
            {
                imposto = valorNotaFiscal * 0.025;
                MessageBox.Show("Valor do imposto é : " + imposto);
            }
            else if (valorNotaFiscal >= 3000 && valorNotaFiscal <= 6999)
            {
                imposto = valorNotaFiscal * 0.028;
                MessageBox.Show("Valor do imposto é : " + imposto);
            }
            else
            {
                imposto = valorNotaFiscal * 0.03;
                MessageBox.Show("Valor do imposto é : " + imposto);
            }           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //int valor = 15;
            //string mensagem = "";

            //if (valor > 10)
            //{
            //    mensagem = "Maior que dez";
            //}
            //else
            //{
            //    mensagem = "Menor que dez";
            //}
            //MessageBox.Show(mensagem);

            int valor = 5;
            string mensagem = "O valor pode ser ";
            //USANDO OPERADOR TERNARIO
            mensagem += valor >= 10 ? "Maior" : "Menor";
            MessageBox.Show(mensagem);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int total = 2;
            for (int i = 0; i < 5; i += 1)
            {
                total = total * 2;
            }
            MessageBox.Show("O total é: " + total);
            // Total é : 64
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int numero = 0;
            for (int i = 1; i <= 1000; i += 1)
            {
                numero = numero + i;
                MessageBox.Show("Soma de um a mil : " + numero);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string multiplo = "";            
            for (int i = 3; i <= 100; i += 3)
            {
                //if (numero % 3 == 0) ignorei essa condição para deixar o cod. menor
                multiplo += " " + i;
                MessageBox.Show("Multiplo de 3 de 1 a 100 : " + multiplo);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for(int i = 1; i <= 100; i += 1)
            {
                if (i % 3 != 0)
                {
                    soma += i ;
                }
                MessageBox.Show("Soma : " + soma);
                // a Resultado é 3367
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string divisiveis = "";
            
            for (int i = 1; i <= 30; i += 1)
            {
                if (i % 3 == 0 || i % 4 == 0)
                {
                    divisiveis += " " + i;
                }
            }
            MessageBox.Show("Números Divisíveis por 3 e 4: " + divisiveis);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int fatorial = 1;            
            for (int n = 1; n <= 10; n++)
            {
                fatorial = fatorial * n;                
                MessageBox.Show(" Fatorial de 1 a 10 : " + fatorial);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int Fibonacci1 = 0, Fibonacci2 = 1, Fibonacci;
            for (int i = 0; i < 101; i++)
            {
                Fibonacci = Fibonacci1;
                Fibonacci1 = Fibonacci2;
                Fibonacci2 = Fibonacci1 + Fibonacci;                
                MessageBox.Show("Fibonacci em Tela : " + Fibonacci2);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int n = 4;
            for ( int i = 1; i <= n; i++ )
            {
                for (int j = 1; j <= i; j++ )
                {
                    MessageBox.Show(i * j + " ");
                }
                MessageBox.Show(" ");
            }
        }
        // Exercicios 6.7 são de logica, deixo para interpretação de vcs.
        // Exercicios Opcionais da 6.7 e Exercicios da 6.9 estão no Projeto Inicial,
        // feito em outra solução...
        // Exercicios da 7.5 Também de Logica.
        // Cap. 9 Ja começamos nosso projeto para criar uma Instituição financeira do Zero...
    }
}
