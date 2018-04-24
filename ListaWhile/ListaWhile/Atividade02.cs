using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaWhile
{
    class Atividade02
    {
        public Atividade02()
        {
            Console.WriteLine("Digite sua idade, para sair digite um número maior que 128.");
            int idade = Convert.ToInt32(Console.ReadLine());


            while (idade < 129)
            {
                Console.WriteLine("Digite sua idade, para sair digite um número maior que 128.");
                idade = Convert.ToInt32(Console.ReadLine());
            }


        }


    }
}
