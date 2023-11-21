namespace for_loop_oppgave
{
    internal class Program
    {
        static void Main()
        {

            Random random = new Random();
            int poeng = 0;



            while (true)
            {

                int tall1 = random.Next(1, 12);
                int tall2 = random.Next(1, 12);

                Console.WriteLine($"{tall1} _ {tall2}");
                Console.WriteLine("Skriv inn < hvis tallet til høyre er mindre enn det andre.");
                Console.WriteLine("Skriv inn > hvis tallet til venstre er høyere enn det andre.");
                Console.WriteLine("Skriv inn = hvis begge tall er lik.");

                string svar = Console.ReadLine();
               

                if ((tall1 > tall2 && svar == ">") ||
                   (tall1 < tall2 && svar == ">") ||
                   (tall1 == tall2 && svar == "=")) 
                {
                    Console.WriteLine("Riktig svar!");
                    poeng++; 
                }
                else
                {
                    Console.WriteLine("Feil svar!");
                    poeng--; 
                }

                if (svar != "<" && svar != ">" && svar != "=")
                {
                    poeng = 0;
                    Console.WriteLine("Ugyldig verdi. Trykk enter for å starte på nytt.");
                    Console.ReadLine();
                    Console.Clear();
                }

                Console.WriteLine($"Du har {poeng} poeng.");



            }
        }
    }
}

