using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stier for login filerne 
            string path = "C:/Users/danja/source/repos/Hjemmearbejde Opgave/Ordre.txt";

            // Variabler 
            string tast;
            int budget = 0, antalbilletter = 0, pris = 0, rest;

            // Tjekker filen og laver den hvis de ikke exister
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            do
            {
                // Viser menu valg muligheder 
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Velkommen til Biograf programmet");
                Console.WriteLine("");

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("   ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("1. Budget:");

                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("   ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("2. Billetter:");

                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write("   ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("3. Tjek ud:");

                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("   ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("X. Afslut programmet");

                // Modtager brugerens valg 
                tast = Console.ReadLine();

                Console.Clear();

                // Handter brugerens valg med en switch 
                switch (tast)
                {
                    case "1":
                        // Fodbold - Fan Support casen 
                        Console.WriteLine("Du har valgt Budget casen.");
                        Console.WriteLine("Venligst skriv hvor meget budget du vil have til dit køb.");
                        budget = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        // Kalder til Foldbold.Fansupport metoden og viser resulatet 
                        Console.WriteLine("Du har valgt at have et budget på {0} kr.", budget);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        // Dansekonkurrence casen og spørgelse om den første partners navn 
                        Console.WriteLine("Du har valgt Billetter casen.");
                        Console.WriteLine("Hver billet koster 120 kr.");
                        Console.WriteLine("Venligst skriv hvor mange billetter du vil købe.");
                        antalbilletter = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        // Kalder til Foldbold.Fansupport metoden og viser resulatet 
                        Console.WriteLine("Du har valgt at købe {0} billetter.", antalbilletter);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        // Dansekonkurrence casen og spørgelse om den første partners navn 
                        Console.WriteLine("Du har valgt Tjek ud casen.");

                        pris = antalbilletter * 120;
                        rest = budget - pris;

                        if(budget >= pris)
                         {
                            Console.WriteLine("Din kvittering er udskrivet neden under.");
                            Console.WriteLine("");
                            // Viser kombinerede info 
                            Console.WriteLine("Dette køb koster {0} kr.", pris);
                            Console.WriteLine("Du har {0} kroner tilbage.", rest);
                            Console.WriteLine("Du købte {0} billetter.", antalbilletter);
                            Console.WriteLine("");
                            Console.WriteLine("Tak for købet! Programmet lukker nu.");
                            tast = "x";
                            File.WriteAllText(path, pris + "\n" + rest + "\n" + antalbilletter + "\n");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Fejl på Tjek ud! - Beløb overskrevet.");
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "x":
                        // Forlader programmet 
                        Console.WriteLine("Du har afsluttet programmet.");
                        Console.ReadKey();
                        break;

                    default:
                        // Handter forkerte indskrivelser 
                        if (tast != "1" || tast != "2" || tast != "3" || tast != "x")
                        {
                            Console.WriteLine("Fejl! - Du har trykket noget forkert. Venligst prøv igen.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                }
            } while (tast != "x");

            // Slutning af programmet 

            Console.WriteLine("Hav en god dag!");

            Console.ReadKey();
        }
    }
}
