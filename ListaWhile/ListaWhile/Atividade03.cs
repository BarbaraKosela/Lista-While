using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaWhile
{
    class Atividade03
    {
        public Atividade03()
        {
            int quantidade = 0;
            Console.WriteLine("Digite seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            while ((peso > -1) && (peso < 301))
            {
                quantidade = quantidade + 1;
                Console.WriteLine("Digite seu peso: ");
                peso = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Quantidade de pessoas cadastradas: " + quantidade);

        }
    }
}
