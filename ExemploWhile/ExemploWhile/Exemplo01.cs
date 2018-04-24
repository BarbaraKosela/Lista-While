using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploWhile
{
    class Exemplo01
    {
        public Exemplo01()
        {
            int alunoAtual = 0;

            while (alunoAtual < 19)
            {
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                alunoAtual = alunoAtual + 1;

            }
        }
    }
}
