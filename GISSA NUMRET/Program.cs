using System;

namespace GISSA_NUMRET
{
    class Program
    {
        static void Main(string[] args)
        {
            //En variabel som lagrar antalet gissningar som användaren gör
            int counter = 0;
            //Programmet ska slumpa ut ett tal mellan 1 och 100
            Random slumpare = new Random();
            int slumptal = slumpare.Next(1, 101);
            Console.WriteLine("Hej! Välkommen till spelet Gissa Talet.");
            Console.WriteLine("Du ska nu gissa ett tal mellan ett och hundra. Sätt igång och börja.");
            Console.ReadKey();

            //Användaren ska gissa ett nummer
            //Try Catch

            try
            {
            int input = Convert.ToInt32(Console.ReadLine());

            //Notering tillbaks till användaren när gissningen är fel. Högre/lägre 
            do
            {
                if (input < slumptal)
                {
                    Console.WriteLine("Du gissade fel. Talet är högre än vad du gissade.");
                    counter++;

                }

                else
                {
                    Console.WriteLine("Du gissade fel. Talet är lägre än vad du gissade.");
                    counter++;

                }
                Console.WriteLine("Du får en ny chans, gissa igen!");
                input = Convert.ToInt32(Console.ReadLine());


            }
            while (input != slumptal);
            //Grattis när det rätta talet gissas
            {
                counter++;
                Console.WriteLine("Grattis! Du tog det på " + counter + " antal gissningar! ");
            }
            }
            catch 
            {
                Console.WriteLine("Fel! Du kan bara skriva in siffror!");
                Console.WriteLine("Försök igen!");
            }

        }
    }
}
