using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaWhile
{
    class Atividade08
    {
        public Atividade08()
        {


            Console.Write("Quantidade de caracteres que deseja digitar: ");
            int caracteres = Convert.ToInt32(Console.ReadLine());
            int quantidade = 0;
            
            
            

            while (quantidade < caracteres)
            {


                char caracter = Console.ReadLine()[0];
                caracter = Convert.ToChar(Console.ReadLine());
                
                
                quantidade = quantidade + 1;
            }


            Console.WriteLine("Texto: " + caracteres);
            
            
            
            
            




            
            

            
            

            
        }
    }
}
