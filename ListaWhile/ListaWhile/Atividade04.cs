using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaWhile
{
    class Atividade04
    {
        public Atividade04()
        {
            
            Console.WriteLine("Digite a quantidade de carros que deseja cadastrar: ");
            
            int quantidadeDeCarros = Convert.ToInt32(Console.ReadLine());

            string primeiraLetra = "";
            
            double somaAno = 0, somaValor = 0;
            
            int numero = 0, letrasG = 0, letrasA = 0;
            
            int quantidade = 0;

            while (numero < quantidadeDeCarros)
            {
                
                Console.WriteLine("Digite o modelo: ");
                string modelo = Console.ReadLine().ToLower();
                primeiraLetra = modelo.Substring(0).ToLower();

                Console.WriteLine("Valor: ");
                double valor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ano do carro: ");
                int ano = Convert.ToInt32(Console.ReadLine());

                somaValor = somaValor + valor;
                somaAno = somaAno + ano;
                quantidade = quantidade + 1;
                

                if (primeiraLetra == "g")
                {
                    letrasG = letrasG + 1;
                }

                else if (primeiraLetra == "a")
                {
                    letrasA = letrasA + 1;
                }
               
                numero = numero + 1;


            }

            
            double mediaAno = somaAno / quantidade;
            double mediaValor = somaValor / quantidade;
            Console.WriteLine("A média dos anos é: " + mediaAno);
            Console.WriteLine("A média dos valores é: " + mediaValor);
            Console.WriteLine("O número de carros com a inicial G é: " + letrasG);
            Console.WriteLine("O número de carros com a incial A é: " + letrasA);
            


        }
    }
}
