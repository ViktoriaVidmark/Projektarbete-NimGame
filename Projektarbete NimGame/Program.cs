namespace Projektarbete_NimGame
{
   
            namespace Projektarbete
    {
        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine(Welcome());
                Spelregler();
                Username();

            }


            static string Welcome()
            {
                Console.WriteLine("Välkommen till spelet Nim!");
                return "Välkommen till spelet Nim!";

            }

            static void Spelregler()
            {
                Console.WriteLine("Spelregler: ");
                Console.WriteLine();
                Console.WriteLine("Spelet börjar med 3 högar med 5 stickor i varje hög.");
                Console.WriteLine();
                Console.WriteLine("|||||   |||||   ||||| ");
                Console.WriteLine();

                Console.WriteLine("Spelet går ut på att tömma högarna på stickor. Den som plockar den sista stickan vinner. ");

                Console.WriteLine("Spelarna turas om att plocka stickor.");
                Console.WriteLine("Först väljer spelaren en hög att plocka från. Därefter väljs antalet stickor som ska plockas.");
                Console.WriteLine("Notera att man endast kan plocka stickor från en hög i taget och måste alltid plocka minst en sticka.");
                Console.WriteLine("Du kan max ta så många stickor som finns i den valda högen.");

                Console.ReadLine();
            }
            static void Username()
            {
                Console.WriteLine("Spelare ett, skriv in ditt namn:");
                string Username1 = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Spelare två, skriv in ditt namn:");
                string Username2 = Console.ReadLine();

                if (Username2.Length == 0)
                {
                    string Username2 = "Karin"; //nytt
                    Console.WriteLine("Okej! Din motståndare är vår AI Karin!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"{Username1} vs {Username2}");
                }
                Console.ReadLine();
            }
            static void Turnarray(string Username1, string Username2)
            {
                string turn1 = Username1;
                string turn2 = Username2;

                räknare
                loop med två if satser
                while ()
                        booelskt uttryck
    


           /*  for(int i = 0; i < turnarray.Length; i++)
            {
                if (turnarray[i] % 2 == 0 && Username2.Length == 0)
                { 
                        Console.WriteLine("Karins tur");
                    
                }
                else if (turnarray[i] % 2 == 0 && Username2.Length != 0)
                {
                    Console.WriteLine($"{Username2}s tur");
                }
                else
                {
                    Console.WriteLine($"{Username1}s tur");
                }
           */

        }

            static void Showpiles()
            {
                int[] piles = { 5, 5, 5 };
                Console.WriteLine("Såhär ser de befintliga högarna ut");
                Console.WriteLine(" |||||     |||||     |||||");
            }
            static void Emptypiles(int[] piles)
            {
                for (int i = 0; i <= 2; i++)
                {
                    if (piles[i] == 0)
                    {
                        ///
                    }
                }
            }
            static void Usermove()
            { }
            static void Updatepiles()
            {
                //skriva över talen i arrayen? 
                // eller likande den uppgiften där man gör en vald indexplats till 0

            }
            static void Winner(int[] piles)
            {
                int sum =
                for (int i = 0; i <= 2; i++)
                {
                    if (sum == 0)
                    {
                        Console.WriteLine("Game over");
                    }
                }

            }
            static void Karin()
            {
                Random Karin = new Random();
                int number = Karin.Next(x, y);
            }
            static void Statistics()
            { }
        }

    }
    Skriv till Linn Agnevik och Hedvig Östblom

}
    }
}