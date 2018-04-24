using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploWhile
{
    class Exemplo03
    {
        public Exemplo03()
        {
            int quantidade = 0;
            Console.Write("Deseja cadastrar? ");
            string continuar = Console.ReadLine();
            continuar = continuar.ToLower();
            double somaSalario = 0;

            while (continuar == "Sim")
            {
                Console.WriteLine("Valor hora: ");
                double valorHora = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Quantidade horas: ");
                int quantidadeHora = Convert.ToInt32(Console.ReadLine());

                double salario = valorHora * quantidadeHora;

                Console.WriteLine("Salário: " + salario);
                Console.Write("Deseja cadastrar novamente? ");
                continuar = Console.ReadLine();

                somaSalario = somaSalario + salario;
                double media = somaSalario / quantidade;


            }


            Console.WriteLine("Quantidade de pessoas cadastradas; " + quantidade);
            
            

        }
    }
}
