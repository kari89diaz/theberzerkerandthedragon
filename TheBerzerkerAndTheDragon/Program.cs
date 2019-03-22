using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBerzerkerAndTheDragon
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "comienzo";
            int option = 0;
            int menu;

            while (command != "fin")
            {
                Console.WriteLine("The Berzerker and the Dragon");
                Console.WriteLine("");
                Console.WriteLine("1. Jugar");
                Console.WriteLine("2. Créditos");
                Console.WriteLine("3. Salir");

                menu = int.Parse(Console.ReadLine());

                if (menu == 3)
                {
                    Environment.Exit(-1);
                }
                else if (menu == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Karina Díaz");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (menu == 1)
                {
                    while (command != "fin")
                    {
                        switch (command)
                        {
                            case ("comienzo"): //1
                                option = 0;

                                Console.WriteLine("Estás en la entrada de la cueva.");
                                Console.WriteLine("¿Qué quieres hacer?");
                                Console.WriteLine("1. Buscar antorcha");
                                Console.WriteLine("2. Seguir a oscuras");

                                option = int.Parse(Console.ReadLine());

                                if (option == 1)
                                {
                                    int torch;
                                    Random randomtorch = new Random();
                                    torch = randomtorch.Next(1, 100);

                                    if (torch < 20)
                                    {
                                        command = "searchtorch";
                                    }
                                    else
                                    {
                                        Console.WriteLine("No encontraste ninguna antorcha");
                                        command = "seguir oscuras";
                                    }
                                }
                                else if (option == 2)
                                {
                                    command = "seguir oscuras";
                                }
                                else
                                {
                                    Console.WriteLine("Error");
                                    Console.ReadKey();
                                }

                                Console.Clear();

                                break;

                            case "searchtorch": //2
                                option = 0;

                                Console.WriteLine("Encuentras una antorcha. Ves un pasillo y un pozo");
                                Console.WriteLine("1. Seguir pasillo");
                                Console.WriteLine("2. Bajar pozo");
                                Console.WriteLine("3. Salir");

                                option = int.Parse(Console.ReadLine());

                                if (option == 1)
                                {
                                    command = "followlight";
                                }
                                else if (option == 2)
                                {
                                    command = "bajar pozo";
                                }
                                else if (option == 3)
                                {
                                    command = "salir";
                                }
                                else
                                {
                                    Console.WriteLine("Error");
                                    Console.ReadKey();
                                }

                                Console.Clear();

                                break;

                            case "salir": //3
                                option = 0;

                                Console.WriteLine("Sabes que no estás preparado para esto");
                                Console.ReadKey();
                                Environment.Exit(-1);

                                break;

                            case "bajar pozo": //4
                                option = 0;

                                Console.WriteLine("Bajaste al pozo y una serpiente venenosa te mordió");
                                Console.ReadKey();
                                Environment.Exit(-1);

                                break;

                            case "seguir oscuras": //5
                                option = 0;

                                Console.WriteLine("Sientes viento");
                                Console.WriteLine("1. Seguir sin tantear");
                                Console.WriteLine("2. Tanteas muy bien tus pasos antes de seguir");
                                Console.WriteLine("3. Salir");

                                option = int.Parse(Console.ReadLine());

                                if (option == 1)
                                {
                                    command = "cae al pozo";
                                }
                                else if (option == 2)
                                {
                                    command = "tantear";
                                }
                                else if (option == 3)
                                {
                                    command = "salir";
                                }
                                else
                                {
                                    Console.WriteLine("Error");
                                    Console.ReadKey();
                                }

                                Console.Clear();

                                break;

                            case "cae al pozo": //6
                                option = 0;

                                Console.WriteLine("Te caíste a un pozo lleno de serpientes");
                                Console.ReadKey();
                                Environment.Exit(-1);
                                break;

                            case "tantear": //7
                                option = 0;

                                Console.WriteLine("Vez dos caminos, uno luminoso y el otro oscuro");
                                Console.WriteLine("1. Ir por el camino oscuro");
                                Console.WriteLine("2.Seguir la luz");
                                Console.WriteLine("3. Huir");

                                option = int.Parse(Console.ReadLine());

                                if (option == 1)
                                {
                                    command = "camino oscuro";
                                }
                                else if (option == 2)
                                {
                                    command = "followlight";
                                }
                                else if (option == 3)
                                {
                                    command = "salir";
                                }
                                else
                                {
                                    Console.WriteLine("Error");
                                    Console.ReadKey();
                                }

                                Console.Clear();

                                break;

                            case "camino oscuro": //8
                                option = 0;

                                Console.WriteLine("Te moriste");
                                Console.ReadKey();
                                Environment.Exit(-1);

                                break;

                            case "followlight": //9
                                option = 0;

                                Console.WriteLine("Sigues el camino sin inconvenientes");
                                Console.WriteLine("1. Seguir");
                                Console.WriteLine("2. Observar");

                                option = int.Parse(Console.ReadLine());

                                if (option == 1)
                                {
                                    command = "sin cuidado";
                                }
                                else if (option == 2)
                                {
                                    command = "searchtraps";
                                }
                                else
                                {
                                    Console.WriteLine("Error");
                                    Console.ReadKey();
                                }

                                Console.Clear();

                                break;

                            case "sin cuidado": //10
                                option = 0;

                                Console.WriteLine("Pisaste una trampa y moriste");
                                Console.ReadKey();
                                Environment.Exit(-1);

                                break;

                            case "searchtraps": //11
                                option = 0;

                                Console.WriteLine("Encontraste una trampa y la evadiste");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("Estás frente al dragón");
                                Console.WriteLine("1.Luchar");
                                Console.WriteLine("2. Hablar");

                                option = int.Parse(Console.ReadLine());

                                if (option == 1)
                                {
                                    command = "fightdragon";
                                }
                                else if (option == 2)
                                {
                                    command = "talkdragon";
                                }
                                else
                                {
                                    Console.WriteLine("Error");
                                    Console.ReadKey();
                                }

                                Console.Clear();

                                break;

                            case "fightdragon":
                                option = 0;

                                Console.WriteLine("Moriste");
                                Console.ReadKey();
                                Environment.Exit(-1);

                                break;

                            case "talkdragon":
                                option = 0;

                                Console.WriteLine("Ganaste");
                                Console.ReadKey();

                                command = "fin";

                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}