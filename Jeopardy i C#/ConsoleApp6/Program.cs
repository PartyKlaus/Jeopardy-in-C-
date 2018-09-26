using System;

namespace ConsoleApp6
{
    class Program
    {
        private static string spørgsmål, error;
        private static int overallPoint, pointScore;
        

        static void Main(string[] args)
        {
            for (int i = 25; i > 0; i--)
            {
                Console.WriteLine($"Points: {overallPoint += pointScore} \n");


                Console.WriteLine("Vælg en kategori");
                Console.WriteLine("    1: Sport");
                Console.WriteLine("    2: Musik");
                Console.WriteLine("    3: Hovedstader");
                Console.WriteLine();
                Console.WriteLine();

                //Læser brugerens tast
                String kategorikey = Console.ReadKey().KeyChar.ToString();

                Console.Clear();

                while (!kategorikey == "1");
                {
                    switch (kategorikey)
                    {
                        case "1":
                            spørgsmål = "Sport";
                            break;

                        case "2":
                            spørgsmål = "Musik";
                            break;

                        case "3":
                            spørgsmål = "Hovedstader";
                            break;

                        default:
                            error = "default1";
                            Console.WriteLine("Ugyldig tast.Tryk på hvilken som helst tast for at prøve igen");
                            break;
                    }

                } 



                


                Console.WriteLine("    1: 200$");
                Console.WriteLine("    2: 400$");
                Console.WriteLine("    3: 600$");
                Console.WriteLine("    4: 800$");
                Console.WriteLine("    5: 1000$");

                String pointKey = Console.ReadKey().KeyChar.ToString();

                Console.Clear();

                if (spørgsmål == "Sport")
                {
                    switch (pointKey)
                    {
                        case "1":
                            pointScore = 200;
                            Console.WriteLine("Hvor mange spillere er der på hvert et hold i fodbold?");

                            break;

                        case "2":
                            pointScore = 400;
                            Console.WriteLine("Hvad står DBU for?");
                            break;

                        case "3":
                            pointScore = 600;
                            Console.WriteLine("Hvor mange spillere er der på hvert hold i håndbold?");
                            break;

                        case "4":
                            pointScore = 800;
                            Console.WriteLine("Hvem blev kåret som som den bedste fodboldspiller i 2015?");
                            break;

                        case "5":
                            pointScore = 1000;
                            Console.WriteLine("Hvor højt hænger en basketball kurv fra gulvet?");
                            break;

                        default:
                            Console.WriteLine("Ugyldig tast. Tryk på hvilken som helst tast for at prøve igen");
                            break;
                    }

                }
                else if (spørgsmål == "Musik")
                {

                    switch (pointKey)
                    {
                        case "1":
                            pointScore = 200;
                            Console.WriteLine("Hvem har skrevet sangen work");
                            break;

                        case "2":
                            pointScore = 400;
                            Console.WriteLine("Blak har skrevet en sang hvor de synger et pigenavn er nede med det. Hvad er navnet på pigen?");
                            break;

                        case "3":
                            pointScore = 600;
                            Console.WriteLine("En sanger der er helt vild med guld, champagne og lækre modeller");
                            break;

                        case "4":
                            pointScore = 800;
                            Console.WriteLine("Hvad er dj gruppen Major Lazer største hit?");
                            break;

                        case "5":
                            pointScore = 1000;
                            Console.WriteLine("Hvem har skrvet ''kærligheden brænder''?");
                            break;
                    }

                }
                else if (spørgsmål == "Hovedstader")
                {

                    switch (pointKey)
                    {
                        case "1":
                            pointScore = 200;
                            Console.WriteLine("Hovedstaden i Danmark?");
                            break;

                        case "2":
                            pointScore = 400;
                            Console.WriteLine("Hovedstaden i Sverige?");
                            break;

                        case "3":
                            pointScore = 600;
                            Console.WriteLine("Hovedstaden i Ungarn?");
                            break;

                        case "4":
                            pointScore = 800;
                            Console.WriteLine("Hovedstaden i Tyrkiet?");
                            break;

                        case "5":
                            pointScore = 1000;
                            Console.WriteLine("Hovedstaden i Marokko?");
                            break;
                    }

                }
                Console.ReadLine();
                Console.Clear();

            }

        }
        
    }
}
