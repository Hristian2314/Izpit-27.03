using static System.Runtime.InteropServices.JavaScript.JSType;

namespace uzpitvane
{
    internal class Program
    {
        int[] grades = new int[26];
        static void Main(string[] args)
        {
            int[] grades = new int[26];

            Console.WriteLine(" Napishete ocenkite na nomera 1-13");
            string[] names = { " Rado, Hristian, MIsho, Lubo, Staskata, Hristomir, Tedo, sami, silvia, " };

            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine($" kakva ocenka na ucenika iskate kato zapichva ot purvi nomer ");

                grades[i] = int.Parse(Console.ReadLine());

                if (grades[i] < 2 || grades[i] > 6)
                {
                    Console.WriteLine("nevalidna ocenka, pitaitde ocenki v diapazona 2-6");


                }
                Console.WriteLine($" Ocenka na uchenika : {grades[i]}");
                grades[i]++;

            }

                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine(" Hora s oceka Slab v klasa");


                for (int j = 0; j < 13; j++)
                {
                    if (grades[j] == 2)
                    {
                        Console.WriteLine($"Uceik " +
                            $" e samo ");
                        break;
                    }

                }


            
        }
        static void Test()
        {
            int[] grades = new int[] { 26 };

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                number++;
                Console.WriteLine($" kakva ocenka na ucenika iskate ");

                grades[i] = int.Parse(Console.ReadLine());

                if (grades[i] < 2 || grades[i] > 6)
                {
                    Console.WriteLine("nevalidna ocenka, pitaitde ocenki v diapazona 2-6");
                    i--;

                }
                Console.WriteLine($" Ocenka na uchenika : {grades[i]}");



                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine(" Hora s oceka Slab v klasa");


                for (int j = 0; j < 13; j++)
                {
                    if (grades[j] == 2)
                    {
                        Console.WriteLine($"Uceik {number} e samo ");
                        break;
                    }

                }

            }

        }
    }
}


