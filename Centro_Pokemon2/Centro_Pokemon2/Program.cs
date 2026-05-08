using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Centro_Pokemon2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 6)    // !=  diferente
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"
██████╗░░█████╗░██╗░░██╗███████╗███╗░░░███╗░█████╗░███╗░░██╗
██╔══██╗██╔══██╗██║░██╔╝██╔════╝████╗░████║██╔══██╗████╗░██║
██████╔╝██║░░██║█████═╝░█████╗░░██╔████╔██║██║░░██║██╔██╗██║
██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░██║╚██╔╝██║██║░░██║██║╚████║
██║░░░░░╚█████╔╝██║░╚██╗███████╗██║░╚═╝░██║╚█████╔╝██║░╚███║
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚══╝");
                Console.ResetColor();
                Console.WriteLine("\n 1 - Cadastro de Pokemon");
                Console.WriteLine("\n 2 - Cadastro de Pokebolas");
                Console.WriteLine("\n 3 - Cadastro de Treinadores");
                Console.WriteLine("\n 4 - Cadastro de Cidade");
                Console.WriteLine("\n 5 - Cadastro de Ginásios");
                Console.WriteLine("\n 6 - Sair");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite a opção escolhida: ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastroPokemon();
                        break;
                    case 2:
                        pokebola();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção Invalida!!");
                        Console.ResetColor();
                        Thread.Sleep(2000);  //pausa na programação por 2s

                        break;
                }


            }
        }

        static void CadastroPokemon()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░");

            Console.ResetColor();
            Console.WriteLine("\n Nome do Pokemon: ");
            string nomePokemon = Console.ReadLine();
            Console.WriteLine("\n Status do Pokemon: ");
            string statusPokemon = Console.ReadLine();
            Console.WriteLine("\n QTD de Golpes do Pokemon: ");
            int qtdGolpes = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdGolpes; i++)
            {
                Console.WriteLine($"\n Golpe do {i} Pokemon: ");
                string golpePokemon = Console.ReadLine();
            }
            Console.WriteLine("\n QTD de Evolução do Pokemon: ");
            int qtdevolucao = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdevolucao; i++)
            {
                Console.WriteLine($"\n Golpe do {i} Pokemon: ");
                string evolucaoPokemon = Console.ReadLine();
            }
            Console.WriteLine("\n Elemento do Pokemon: ");
            string elementoPokemon = Console.ReadLine();

            Console.WriteLine("\n Fraqueza do Pokemon: ");
            int fraquezaEvolucao = int.Parse(Console.ReadLine());
            for (int i = 1; i <= fraquezaEvolucao; i++)
            {
                Console.WriteLine($"\n Fraqueza {i} do Pokemon: ");
                string FraquezaPokemon = Console.ReadLine();
            }
            Console.WriteLine("\n Raridade do Pokemon: ");
            string raridadePokemon = Console.ReadLine();
            Console.WriteLine("\n Peso do Pokemon: ");
            double pesoPokemon = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Cadastro Finalizado!!!! ");
            Thread.Sleep(2000);
        }



        static void pokebola()
        {





        }

    }
}
