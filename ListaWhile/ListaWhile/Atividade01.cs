using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaWhile
{
    class Atividade01
    {
        public Atividade01()
        {
            Console.WriteLine("Digite seu nome, para sair digite fim.");
            string nome = Console.ReadLine();
            nome = nome.ToLower();
     
            

            while (nome != "fim")
            {
                Console.WriteLine("Digite seu nome, para sair digite fim.");
                nome = Console.ReadLine().ToLower();
           
            }

            
















        }



    }
}
