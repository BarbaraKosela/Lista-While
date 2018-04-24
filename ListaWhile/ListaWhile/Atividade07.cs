using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaWhile
{
    class Atividade07
    {
        public Atividade07()
        {
            int jogadorAtual = 0, sexoF = 0, sexoM = 0;
            double maiorPeso = int.MinValue, menorPeso = int.MaxValue, maiorAltura = int.MinValue, menorQuantidadeDeAmarelos = int.MaxValue, 
                maiorQuantidadeDeVermelhos = 0, maiorQuantidadeDeAmarelos = 0, menorQuantidadeDeVermelhos = 0;
            string nomeMaiorPeso = "", nomeMenorPeso = "", nomeMaiorAltura = "", maiorNome = "", letraF = "", letraM = "", 
                nomeMenorQuantidadeDeAmarelos = "", menorNome = maiorNome, nomeMaiorQuantidadeVermelhos = "", nomeMaiorQuantidadeDeAmarelos = "",
                nomeMenorQuantidadeVermelhos = "";
            
            
            
                

            


            while (jogadorAtual < 2)
            {
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                

                Console.WriteLine("Peso: ");
                double peso = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Sexo (digite F para feminino e M para masculino): ");
                string sexo = Console.ReadLine().ToLower();
                letraF = sexo.Substring(0).ToLower();
                letraM = sexo.Substring(0).ToLower();

                Console.WriteLine("Altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Quantidade de gols marcados: ");
                int gols = Convert.ToInt32(Console.ReadLine()); 
                

                Console.WriteLine("Quantidade de cartões amarelos recebidos: ");
                int cartaoAmarelo = Convert.ToInt32(Console.ReadLine());
                

                Console.WriteLine("Quantidade de cartões vermelhos recebidos: ");
                int cartaoVermelho = Convert.ToInt32(Console.ReadLine());


                Console.Clear();
                
                




                if (peso > maiorPeso)
                {
                    maiorPeso = peso;
                    nomeMaiorPeso = nome;


                }

                if (peso < menorPeso)
                {
                    menorPeso = peso;
                    nomeMenorPeso = nome;
                }

                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                    nomeMaiorAltura = nome;
                }

                if (nome.Length > maiorNome.Length)
                {
                    maiorNome = nome;
                }

                if (letraF == "f")
                {
                    sexoF = sexoF + 1;
                }

                jogadorAtual = jogadorAtual + 1;

                if (letraM == "m")
                {
                    sexoM = sexoM + 1;
                }

                if (cartaoAmarelo < menorQuantidadeDeAmarelos)
                {
                    menorQuantidadeDeAmarelos = cartaoAmarelo;
                    nomeMenorQuantidadeDeAmarelos = nome;
                }

                if (nome.Length < maiorNome.Length)
                {
                    menorNome = nome;
                }
                
                if (cartaoVermelho > maiorQuantidadeDeVermelhos)
                {
                    maiorQuantidadeDeVermelhos = cartaoVermelho;
                    nomeMaiorQuantidadeVermelhos = nome;
                }

                if (cartaoAmarelo > maiorQuantidadeDeAmarelos)
                {
                    maiorQuantidadeDeAmarelos = cartaoAmarelo;
                    nomeMaiorQuantidadeDeAmarelos = nome;
                }

                if (cartaoVermelho < menorQuantidadeDeVermelhos)
                {
                    menorQuantidadeDeVermelhos = cartaoVermelho;
                    nomeMenorQuantidadeVermelhos = nome;
                }

            }

            Console.WriteLine("\nO jogador com menor peso é: " + nomeMenorPeso);
            Console.WriteLine("\nO jogador com a maior altura é: " + maiorAltura);
            Console.WriteLine("\nO jogador com maior nome é: " + maiorNome);
            Console.WriteLine("\nNúmero de jogadores do sexo F: " + sexoF);
            Console.WriteLine("\nNúmero de jogadores do sexo M: " + sexoM);
            Console.WriteLine("\nO jogador com a menor quantidade de cartões amarelos é: " + nomeMenorQuantidadeDeAmarelos);
            Console.WriteLine("\nO jogador com menor nome é: " + menorNome);
            Console.WriteLine("\nO jogador com maior peso é: " + nomeMaiorPeso);
            Console.WriteLine("\nO jogador com a maior quantidade de cartões vermelhos é: " + nomeMaiorQuantidadeVermelhos);
            Console.WriteLine("\nO jogador com a maior quantidade de cartões amarelos é: " + nomeMaiorQuantidadeDeAmarelos);
            Console.WriteLine("\nO jogador com a menor quantidade de cartões vermelhos é: " + nomeMenorQuantidadeVermelhos);


            
        }
    }
}
