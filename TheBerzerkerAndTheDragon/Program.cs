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
            string command = "beginning";
            int option = 0;
            int menu;

            while (command != "end")
            {
                Console.WriteLine("The Berzerker and the Dragon");
                Console.WriteLine("");
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Credits");
                Console.WriteLine("3. Exit");

                menu = int.Parse(Console.ReadLine());

                if (menu == 3)
                {
                    Environment.Exit(-1);
                }
                else if (menu == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Made by:");
                    Console.WriteLine("Karina Díaz");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("As a personal practice for my C# studies");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (menu == 1)
                {
                    while (command != "end")
                    {
                        switch (command)
                        {
                            case ("beginning"): //1
                                option = 0;

                                Console.Clear();
                                Console.WriteLine("You're Grog the Berserker, a renowned warrior from norther lands");
                                Console.WriteLine("");
                                Console.WriteLine("Some day, in a tabern who was frequented by all kind of adventurers, while you was enjoying a delicious milk jar, before a brutal fight with a weak man who dare to laugh at your, apparently, funny taste for such a big man, an old woman tells you about a ancient dragon who, the legends says, guards an enormous treasure.");
                                Console.WriteLine("");
                                Console.WriteLine("Before the tabern was set on fire because an unfortunable incident, where this weak man falls into the embers of a stove, and starts to run like a insane with his clothes burning, you start your adventure to the ruins where this dragon lives.");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("You arrive at the entrance of the ruins. It's seem that they were carved in the stone, and it looks more to a cave than ancient ruins.");
                                Console.WriteLine("Inside there is only darkness, and you wasn't cautious enough to buy a torch before. Well... who needs a torch when you have your axe, anyway?");
                                Console.WriteLine("");
                                Console.WriteLine("What do you want to do?");
                                Console.WriteLine("");
                                Console.WriteLine("**Choose an option with your number keybard and press enter**");
                                Console.WriteLine("");
                                Console.WriteLine("1. Search for a torch, better to be cautious");
                                Console.WriteLine("2. Go into the darkness, you are a berserker, danmit!");
                                Console.WriteLine("3. Run like a chicken.");

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
                                        Console.WriteLine("You search for almost an hour for a torch, but didn't find anything.");
                                        Console.WriteLine("You now remember the old woman saying no one has stepped this ruins for a long, long time.");
                                        Console.WriteLine("Now you will have to grope for a way into the darkness.");
                                        command = "intodarkness";
                                    }
                                }
                                else if (option == 2)
                                {
                                    command = "intodarkness";
                                }
                                else if (option == 3)
                                {
                                    command = "run";
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

                                Console.WriteLine("You decide to search for a torch in the darkness to enlight you way through that ruins. After a arduous search you manage to find a torch");
                                Console.WriteLine("You think that's strange because the old woman says that no one was steped on this ruins for a long time.");
                                Console.WriteLine("That old witch fouls you, and now you know it. You burn in anger, but you know that you have to go on with your quest, in the end, you are a berserker");
                                Console.WriteLine("");
                                Console.WriteLine("Now that you have the torch, you turn it on and you can see a big entrance room, with a well in the center and a hallway on the other side from you.")
                                Console.WriteLine("What do you want to do?");
                                Console.WriteLine("");
                                Console.WriteLine("1. Look into the well.");
                                Console.WriteLine("2. Ignore the well and go directly to the hallway.");

                                option = int.Parse(Console.ReadLine());

                                if (option == 1)
                                {
                                    command = "lookwell";
                                }
                                else if (option == 2)
                                {
                                    command = "followlight";
                                }
                                else
                                {
                                    Console.WriteLine("Error");
                                    Console.ReadKey();
                                }

                                Console.Clear();

                                break;

                            case "run": //3
                                option = 0;

                                Console.WriteLine("You know that you aren't prepare for this challenge, you coward!");
                                Console.ReadKey();
                                Environment.Exit(-1);

                                break;

                            case "lookwell": //4
                                option = 0;

                                Console.WriteLine("You get closer to the well. It's totally black, and the borders are unestable.");
                                Console.WriteLine("Your natural curiosity leads you to the corner of the well");
                                Console.WriteLine("You forget that you are a big and heavy man, and a little clumsy, and you slide from the border and fall into the well");
                                Console.WriteLine("The fall isn't painful, the well wasn't deep, but you feel a lot of crawling things at your sides and under your body");
                                Console.ReadKey();
                                Console.WriteLine("Now over you");
                                Console.ReadKey();
                                Console.WriteLine("You feel a little bite");
                                Console.ReadKey();
                                Console.WriteLine("Now you feel deezy");
                                Console.ReadKey();
                                Console.WriteLine("Now you are dead");
                                Console.ReadKey();
                                Environment.Exit(-1);

                                break;

                            case "intodarkness": //5
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
                                    command = "run";
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
                                    command = "run";
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

                                command = "end";

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