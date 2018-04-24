using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaWhile
{
    class Atividade05
    {
        public Atividade05()

        {

            Console.WriteLine("Digite um número: ");
            int numero01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um número: ");
            int numero02 = Convert.ToInt32(Console.ReadLine());
            int selecionar = 0;


            Console.WriteLine("  ______________________________________________________ ");
            Console.WriteLine("@|                      | M E N U |                     |");
            Console.WriteLine("@|______________________________________________________|");
            Console.WriteLine("@|     Número 1             |    S O M A R              |");
            Console.WriteLine("@|     Número 2             |    S U B T R A I R        |");
            Console.WriteLine("@|     Número 3             |    M U L T I P L I C A R  |");
            Console.WriteLine("@|     Número 4             |    D I V I D I R          |");
            Console.WriteLine("@|     Número 5             |    S A I R                |");
            Console.WriteLine("@|__________________________|___________________________|");

            Console.WriteLine("Digite um número de 1 à 4, selecione 5 para sair: ");
            selecionar = Convert.ToInt32(Console.ReadLine());

            if (selecionar == 1)
            {

                Console.WriteLine("O resultado da soma é: " + (numero01 + numero02));

            }

            else if (selecionar == 2)
            {
                Console.WriteLine("O resultado da subtração é: " + (numero01 - numero02));
            }

            else if (selecionar == 3)
            {
                Console.WriteLine("O resultado da multiplicação é: " + (numero01 * numero02));
            }

            else if (selecionar == 4)
            {
                Console.WriteLine("O resultado da divisão é: " + (numero01 / numero02));
            }



            while ((selecionar < 5)&&(selecionar >0))
            {
                Console.WriteLine("  ______________________________________________________ ");
                Console.WriteLine("@|                      | M E N U |                     |");
                Console.WriteLine("@|______________________________________________________|");
                Console.WriteLine("@|     Número 1             |    S O M A R              |");
                Console.WriteLine("@|     Número 2             |    S U B T R A I R        |");
                Console.WriteLine("@|     Número 3             |    M U L T I P L I C A R  |");
                Console.WriteLine("@|     Número 4             |    D I V I D I R          |");
                Console.WriteLine("@|     Número 5             |    S A I R                |");
                Console.WriteLine("@|__________________________|___________________________|");

                Console.WriteLine("Digite um número de 1 à 4, selecione 5 para sair: ");
                selecionar = Convert.ToInt32(Console.ReadLine());
                
                if (selecionar == 1)
                {

                    Console.WriteLine("O resultado da soma é: " + (numero01 + numero02));

                }

                else if (selecionar == 2)
                {
                    Console.WriteLine("O resultado da subtração é: " + (numero01 - numero02));
                }

                else if (selecionar == 3)
                {
                    Console.WriteLine("O resultado da multiplicação é: " + (numero01 * numero02));
                }

                else if (selecionar == 4)
                {
                    Console.WriteLine("O resultado da divisão é: " + (numero01 / numero02));
                }

                

                
                
            }
           
            
            

            

            


        }
    }
}
