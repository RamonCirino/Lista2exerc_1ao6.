using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa
{
    class Program
    {
        // Função utilizada no exercício 3.

        static int Maior(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        static void Main(string[] args)
        {
            // 1. Uma empresa quer transmitir dados pelo telefone, mas está preocupada com a interceptação telefônica. Todos os seus dados são
            // trasmitidos como inteiros de quatro dígitos. Ela pediu para que você escreva um programa que criptografe seus dados, para que
            // eles possam ser transmitidos com mais segurança. Seu aplicativo deve ler um inteiro de quatro dígitos fornecidos pelo usuário
            // e criptografá-lo da seguinte forma: sebstitua cada dígito por (a soma desse dígito mais 7) módulo 10. Em seguida, troque o 
            // primeiro dígito pelo terceiro e troque o segundo dígito pelo quarto e imprima o inteiro criptografado.

            /// Declaração das variáveis:

            int Entrada = 0;
            int resto1 = 0;
            int resto2 = 0;
            int resto3 = 0;
            int temp1 = 0;
            int temp2 = 0;
            int temp3 = 0;
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;

            Console.WriteLine("\tExercíco1: \n");

            Console.WriteLine("Digite um número inteiro de quatro dígitos: \n");

            Entrada = int.Parse(Console.ReadLine());

            // Desmembrando o primeiro dígito - n1:

            temp1 = (Entrada / 1000);
            resto1 = (Entrada % 1000);
            num1 = temp1;

            // Desmembrando o segundo dígito - n2:

            temp2 = (resto1 / 100);
            resto2 = (resto1 % 100);
            num2 = temp2;

            // Desmembrando o terceiro dígito - n3:

            temp3 = (resto2 / 10);
            resto3 = (resto2 % 10);
            num3 = temp3;

            // Adquirindo o quarto dígito:

            num4 = resto3;

            // Criptografando os dados:

            n1 = (num1 + 7) % 10;
            n2 = (num2 + 7) % 10;
            n3 = (num3 + 7) % 10;
            n4 = (num4 + 7) % 10;

            Console.Write("\n");

            //Imprimindo o número criptografado (Com as posições trocadas):

            Console.WriteLine("O número criptografado correspondente ao valor digitado é: \n");

            Console.Write(n3);
            Console.Write(n4);
            Console.Write(n1);
            Console.Write(n2);

           
            Console.ReadKey();
            Console.Clear();


            // 2. Crie um programa em C# que determina se o cliente de uma loja de departamentos ultrapassou o limite de crédito em uma conta.
            // Para cada cliente modelado em uma classe, os seguintes dados estão disponíveis:

            // a) Número da conta;
            // b) O saldo no início do mês;
            // c) O total de todos os itens cobrados desse cliente no mês corrente;
            // d) O total de todos os créditos aplicados na conta desse cliente no mês corrente;
            // e) O limite de crédito permitido.

            // O programa deve fornecer como valores inteiros cada um desses fatos, e através dos métodos da classe cliente: calcular o
            // novo saldo (= saldo inicial + cobranças - créditos), exibir o novo saldo e determinar se o novo saldo ultrapassa o limite de 
            // crédito do cliente. Para os clientes cujo o limite de crédito foi ultrapassado, o programa deve exibir a mensagem: " Limite
            // de crédito Excedido!". Teste a classe criada, bem como os métodos propostos na classe principal do seu programa.

            Console.WriteLine("Exercício 2:\n ");

            int saldo = 0;

            Console.WriteLine("Digite o valor do saldo atual:\n ");
            saldo = int.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(saldo, 2, 300, 400, 2000);
            Console.WriteLine("O seu novo saldo é de:\n");
            Console.WriteLine(cliente.CalcularNovoSaldo());

            cliente.AtualizarSaldo();

            if (cliente.UltrapassouLimite())
            {
                Console.WriteLine("Limite de Credito Excedido.");
            }
            else
            {
                Console.WriteLine("Ainda há crédito disponivel.");
            }

            Console.ReadKey();
            Console.Clear();

                       
            // 3. Implemente o método Maior (a,b) que receba dois números inteiros como parâmetro e retorna qual deles é o maior.

            Console.WriteLine("Exercício 3:\n ");

            int numero1 = 0;
            int numero2 = 0;
                       
            Console.WriteLine("Digite o valor de um número inteiro e pressione a tecla ENTER:\n ");

            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de outro número inteiro e pressione a tecla ENTER:\n ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 == numero2)
            {
                Console.WriteLine("\t Os números digitados são iguais!");
            }
            else
            {
                Console.WriteLine("\t O maior número digitado foi o número:\t" + Maior(numero1, numero2));
            }
            
            Console.ReadKey();
            Console.Clear();


            // 4. Escreva uma programa que leia 3 números inteiros referente ao comprimento dos lados de um triângulo e classifique como:
            // Triângulo equilátero, isósceles ou escaleno.

            Console.WriteLine("\t Exercício 4: \n");

            string L1 = "";
            string L2 = "";
            string L3 = "";

            Console.WriteLine("O seguinte Programa Classificará um determinado triângulo\nreferente a medida dos seus lados.\n");
            
            Console.WriteLine("Digite a medida de um dos lados do triângulo:\n");

            L1 = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Digite a medida de outro lado do triângulo:\n");

            L2 = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Digite a última medida do triângulo:\n");

            L3 = Console.ReadLine();

            Console.WriteLine("\n");

            if (L1 == L2 && L2 == L3)

            {
                Console.WriteLine("Esse é um triângulo EQUILÁTERO");
            }

            else if (L1 == L2 || L2 == L3 || L1 == L3)

            {
                Console.WriteLine("Esse é um triângulo ISÓSCELES");
            }

            else
            {
                Console.WriteLine("Esse é um triângulo ESCALENO");
            }
            
            Console.ReadKey();
            Console.Clear();


            // 5. Escreva um programa que leia apenas uma letra do alfabeto como entrada e classifique-a como vogal ou consoante. Seu programa
            // deverá aceitar como entrada apenas um caracter, ou seja, se o usuário digitar dois ou mais caracteres, o sistema deverá informar
            // ao usuário a entrada rejeitada.

            Console.WriteLine("\t Exercício 5: \n");

            int verifica = 0;

            Console.WriteLine("Digite uma letra do alfabeto:\n");
                      
            var letra = Console.ReadLine().ToArray();

            string[] vogais = new string[] { "a", "A", "e", "E", "i", "I", "o", "O", "u", "U" };

            
            if ( letra.Length == 1 )
            {
                for(int i = 0; i < vogais.Length; i++)
                {
                    if(letra[0].ToString() == vogais[i])
                    {
                        verifica = 1;
                    }                                        
                }

                if (verifica == 1)
                {
                    Console.WriteLine("\n \t A letra digitada é uma VOGAL.");
                }

                else
                {
                    Console.WriteLine("\n \t A letra digitada é uma CONSOANTE ou um caracter qualquer.");
                }

            }
            else
            {
                Console.WriteLine("ENTRADA REJEITADA!");
            }

            Console.ReadKey();
            Console.Clear();

            // 6. "Um número é Primo se ele for divisível por 1 e por ele mesmo". Escreva um programa que verifica se um número é primo.

            Console.WriteLine("\t Exercício 6: \n");

            Console.WriteLine("Digite um número natural maior que 2 e verifique se ele é Primo ou não:\n");

            int numprimo = 0;
            int restodivisao = 0;
            int denominador = 0;
            int verificador = 0;
           
            numprimo = int.Parse(Console.ReadLine());

            for(denominador = 2; denominador < numprimo; denominador++)
            {
                restodivisao = numprimo % denominador;
                
                if (restodivisao == 0)
                {
                    verificador = 1;
                }                
            }
            
            if (verificador == 1)
            {
                Console.WriteLine("O número digitado não é um número PRIMO.");
            }
            else
            {
                Console.WriteLine("O número digitado é um número PRIMO.");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
