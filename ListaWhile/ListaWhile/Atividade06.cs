using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaWhile
{
    class Atividade06
    {
        public Atividade06()
        {

            int bolos = 0, sanduiches = 0, doces = 0, pizzas = 0, quantidade = 0;
            double valorTotal = 0, preco = 0;

            Console.WriteLine("  ______________________________________________________________________  ");
            Console.WriteLine(" |                               MENU:                                  | ");
            Console.WriteLine(" |______________________________________________________________________| ");
            Console.WriteLine(" |CODIGO         |  TIPO:        |  NOME:              | VALOR:         | ");
            Console.WriteLine(" |_______________|_______________|_____________________|________________| ");
            Console.WriteLine(" |   1           | Bolos         |Bolo Brigadeiro      | 29,50          | ");
            Console.WriteLine(" |   2           | Bolos         |Bolo Floresta Negra  |  2,00          | ");
            Console.WriteLine(" |   3           | Bolos         |Bolo Leite c/ Nutella| 29,23          | ");
            Console.WriteLine(" |   4           | Bolos         |Bolo Mousse Chocolate|  7,10          | ");
            Console.WriteLine(" |   5           | Bolos         |Bolo Nega Maluca     | 19,33          | ");
            Console.WriteLine(" |   6           | Doces         |Bomba de Creme       | 17,71          | ");
            Console.WriteLine(" |   7           | Doces         |Bomba de Morango     |  4,82          | ");
            Console.WriteLine(" |   8           | Sanduiches    |File com fritas e    | 21,16          | ");
            Console.WriteLine(" |               |               |      Cheddar        |                | ");
            Console.WriteLine(" |   9           | Sanduiches    |Hambúrguer com queijo| 12,70          | ");
            Console.WriteLine(" |               |               | champignon e rúcula |                | ");
            Console.WriteLine(" |   10          | Sanduiches    |Provolone com salame | 19,70          | ");
            Console.WriteLine(" |   11          | Sanduiches    |Vegetariano berinjela| 28,22          | ");
            Console.WriteLine(" |   12          | Pizzas        |Calabresa            |  8,98          | ");
            Console.WriteLine(" |   13          | Pizzas        |Napolitana           |  0,42          | ");
            Console.WriteLine(" |   14          |Pizzas         |Peruana              | 18,36          | ");
            Console.WriteLine(" |   15          | Pizzas        |Portuguesa           | 27,50          | ");
            Console.WriteLine(" |_______________|_______________|_____________________|________________| ");
            Console.WriteLine(" |   16                          |Sair                                  | ");
            Console.WriteLine(" |_______________________________|______________________________________| ");

            Console.WriteLine("\nEscolha seu pedido: ");
            int escolha = Convert.ToInt32(Console.ReadLine());
            escolha = 0;

            


            while (escolha != 16)
            {
                Console.Clear();
                Console.WriteLine("  ______________________________________________________________________  ");
                Console.WriteLine(" |                               MENU:                                  | ");
                Console.WriteLine(" |______________________________________________________________________| ");
                Console.WriteLine(" |CODIGO         |  TIPO:        |  NOME:              | VALOR:         | ");
                Console.WriteLine(" |_______________|_______________|_____________________|________________| ");
                Console.WriteLine(" |   1           | Bolos         |Bolo Brigadeiro      | 29,50          | ");
                Console.WriteLine(" |   2           | Bolos         |Bolo Floresta Negra  |  2,00          | ");
                Console.WriteLine(" |   3           | Bolos         |Bolo Leite c/ Nutella| 29,23          | ");
                Console.WriteLine(" |   4           | Bolos         |Bolo Mousse Chocolate|  7,10          | ");
                Console.WriteLine(" |   5           | Bolos         |Bolo Nega Maluca     | 19,33          | ");
                Console.WriteLine(" |   6           | Doces         |Bomba de Creme       | 17,71          | ");
                Console.WriteLine(" |   7           | Doces         |Bomba de Morango     |  4,82          | ");
                Console.WriteLine(" |   8           | Sanduiches    |File com fritas e    | 21,16          | ");
                Console.WriteLine(" |               |               |      Cheddar        |                | ");
                Console.WriteLine(" |   9           | Sanduiches    |Hambúrguer com queijo| 12,70          | ");
                Console.WriteLine(" |               |               | champignon e rúcula |                | ");
                Console.WriteLine(" |   10          | Sanduiches    |Provolone com salame | 19,70          | ");
                Console.WriteLine(" |   11          | Sanduiches    |Vegetariano berinjela| 28,22          | ");
                Console.WriteLine(" |   12          | Pizzas        |Calabresa            |  8,98          | ");
                Console.WriteLine(" |   13          | Pizzas        |Napolitana           |  0,42          | ");
                Console.WriteLine(" |   14          | Pizzas        |Peruana              | 18,36          | ");
                Console.WriteLine(" |   15          | Pizzas        |Portuguesa           | 27,50          | ");
                Console.WriteLine(" |_______________|_______________|_____________________|________________| ");
                Console.WriteLine(" |   16                          |Sair                                  | ");
                Console.WriteLine(" |_______________________________|______________________________________| ");
                
                Console.Write("\nEscolha seu pedido: ");
                escolha = Convert.ToInt32(Console.ReadLine());
                

                if (escolha == 1)
                {

                    preco = preco + 29.50;
                    bolos = bolos + 1;
                    quantidade = quantidade + 1;
                         
                }

                else if (escolha == 2)
                {
                    preco = preco + 2.00;
                    bolos = bolos + 1;
                    quantidade = quantidade + 1;
                }

                else if (escolha == 3)
                {
                    preco = preco + 29.23;
                    escolha = bolos + 1;
                    quantidade = quantidade + 1;
                }

                else if (escolha == 4)
                {
                    preco = preco + 7.10;
                    bolos = bolos + 1;
                    quantidade = quantidade + 1;
                }

                else if (escolha == 5)
                {
                    preco = preco + 19.33;
                    bolos = bolos + 1;
                    quantidade = quantidade + 1;
                }

                else if (escolha == 6)
                {
                    preco = preco + 17.71;
                    doces = doces + 1;
                    quantidade = quantidade + 1;
                }

                else if (escolha == 7)
                {
                    preco = preco + 4.82;
                    doces = doces + 1;
                    quantidade = quantidade + 1;
                }
                
                else if (escolha == 8)
                {
                    preco = preco + 21.16;
                    sanduiches = sanduiches + 1;
                    quantidade = quantidade + 1;
                }

                else if (escolha == 9)
                {
                    preco = preco + 12.70;
                    sanduiches = sanduiches + 1;
                    quantidade = quantidade + 1;
                }

                else if (escolha == 10)
                {
                    preco = preco + 19.70;
                    quantidade = quantidade + 1;
                    sanduiches = sanduiches + 1;
                }

                else if (escolha == 11)
                {
                    preco = preco + 28.22;
                    quantidade = quantidade + 1;
                    sanduiches = sanduiches + 1;
                }

                else if (escolha == 12)
                {
                    quantidade = quantidade + 1;
                    preco = preco + 8.98;
                    pizzas = pizzas + 1;
                }
                
                else if (escolha == 13)
                {
                    quantidade = quantidade + 1;
                    preco = preco + 0.42;
                    pizzas = pizzas + 1;
                }
                
                else if (escolha == 14)
                {
                    quantidade = quantidade + 1;
                    preco = preco + 18.36;
                    pizzas = pizzas + 1;
                }
                
                else if (escolha == 15)
                {
                    quantidade = quantidade + 1;
                    preco = preco + 27.50;
                    pizzas = pizzas + 1;
                }



                

            }

            Console.WriteLine("\n\nTotal dos pedidos: " + preco);
            Console.WriteLine("Quantidade de produtos consumidos: " + quantidade);
            Console.WriteLine("Quantidade de bolos: " + bolos);
            Console.WriteLine("Quantidade de doces: " + doces);
            Console.WriteLine("Quantidade de sanduíches: " + sanduiches);
            Console.WriteLine("Quantidade de pizzas: " + pizzas);
            Console.WriteLine("Media dos pedidos: " + preco / quantidade);

        }
    }
}
