using System;
using System.Globalization;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Välkommen till 21:an !!");
            Console.WriteLine(" ");

            Random newcard = new Random();

            string meny = "0";

            string previouswinner = "Huset";

            while (meny != "4")
            {
                Console.WriteLine(" ");
                Console.WriteLine("välj ett av alternativen:");
                Console.WriteLine(" ");

                Console.WriteLine("1. spela 21an ");
                Console.WriteLine("2. regler för 21an ");
                Console.WriteLine("3. senaste vinnare ");
                Console.WriteLine("4. avsluta program ");
                Console.WriteLine(" ");

                meny = Console.ReadLine();

                switch (meny)
                {
                    case "1":

                        int datorscore = 0;
                        int playerscore = 0;
                        Console.WriteLine("två kort kommer att dras till hus och spelare");
                        datorscore += newcard.Next(1, 11);
                        datorscore += newcard.Next(1, 11);
                        playerscore += newcard.Next(1, 11);
                        playerscore += newcard.Next(1, 11);
                        string playerchoice = "j";
                        while (playerchoice != "n" && playerscore < 21)
                        {
                            Console.WriteLine($"din poäng:{playerscore}");
                            Console.WriteLine($"dator poäng:{datorscore}");
                            Console.WriteLine("vill du dra ett till kort?");
                            playerchoice = Console.ReadLine();

                            switch (playerchoice)
                            {
                                case "j":
                                    int newscore = newcard.Next(1, 11);
                                    playerscore += newscore;
                                    Console.WriteLine("ditt kort är värt: " + newscore);
                                    Console.WriteLine($"din totalpoäng är nu:{playerscore}");
                                    break;
                                case "n":
                                    break;
                                default:
                                    Console.WriteLine("du har valt något annat alternativ än j eller n ");
                                    break;
                            }
                        }
                        if (playerscore < 21)
                        {
                            while (datorscore < playerscore)
                            {
                                int newdatorscore = newcard.Next(1, 11);
                                datorscore += newdatorscore;
                                Console.WriteLine("datorn drog " + datorscore + " poäng");
                            }
                            if (datorscore > 21)
                            {
                                Console.WriteLine("grattis du har vunnit. skriv in ditt namn här: ");
                                previouswinner = Console.ReadLine();
                            }
                            else if (datorscore > playerscore && datorscore < 21)
                            {
                                Console.WriteLine("du har förlorat");
                            }
                        }
                        else
                        {
                            Console.WriteLine("du har över 21 poäng, du har förlorat");
                        }


                        break;
                    case "2":
                        Console.WriteLine(" \n Ditt mål är att tvinga huset över 21 poäng");
                        Console.WriteLine("du och huset börjar med två kort var");
                        Console.WriteLine("du får dra fler kort tills du är över 21 eller nöjd");
                        Console.WriteLine("hamnar du över 21 förlorar du");
                        Console.WriteLine("är du under 21 men huset är över 21 vinner du");
                        Console.WriteLine("är du under 21 men huset är högre än dig och under 21 vinner huset");
                        break;
                    case "3":
                        Console.WriteLine(previouswinner + "\n");
                        break;

                    case "4":
                        Console.WriteLine("\n tack för att du spelade 21 \n");
                        break;

                    default:
                        Console.WriteLine("\n Du har valt ett tal annat än 1, 2, 3 och 4. Försök igen\n");
                        break;
                }
            }
        }
    }

}